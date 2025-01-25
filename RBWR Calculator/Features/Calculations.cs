using System;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace RBWR_Calculator.Features
{
    public class Calculations
    {
        private const double LinearA = 0.07342488;
        private const double LinearB = 11.00409;

        private const double QuadraticC = -0.000002121531845;
        private const double QuadraticD = 0.07616;
        private const double QuadraticE = 10.36918;

        private const double Hysteresis = 10;
        private static double _meetingPoint;

        internal static void CalculateMeetingPoint()
        {
            double a = QuadraticC;
            double b = QuadraticD - LinearA;
            double c = QuadraticE - LinearB;

            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                MessageBox.Show("Convergence equation has no real roots, this is a sign of a broken build. Auto will always use the linear formula.", "Bad formulas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _meetingPoint = double.NaN; // No real roots
                return;
            }

            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            if (root1 > 0 && root2 > 0)
            {
                _meetingPoint = Math.Min(root1, root2);
            }
            else if (root1 > 0)
            {
                _meetingPoint = root1;
            }
            else if (root2 > 0)
            {
                _meetingPoint = root2;
            }
            else
            {
                _meetingPoint = double.NaN;
                MessageBox.Show("Negative convergence roots, this is a sign of a broken build. Auto will always use the linear formula.", "Bad formulas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static double CalculateApr(double totalRequested)
        {
            if (double.IsNaN(_meetingPoint) && Form.Instance.FormulaUsage == Form.FormulaStatus.Auto) // fallback to linear
            {
                return CalculateLinearApr(totalRequested);
            }

            bool forceLinear = Form.Instance.FormulaUsage == Form.FormulaStatus.Linear;
            bool forceQuadratic = Form.Instance.FormulaUsage == Form.FormulaStatus.Quadratic;

            if ((totalRequested < _meetingPoint - Hysteresis || forceLinear) && !forceQuadratic) // use linear fully
            {
                return CalculateLinearApr(totalRequested);
            }
            if (totalRequested > _meetingPoint + Hysteresis || forceQuadratic) // use quadratic fully
            {
                return CalculateQuadraticApr(totalRequested);
            }

            double weight = (totalRequested - (_meetingPoint - Hysteresis)) / (2 * Hysteresis);
            return (1 - weight) * CalculateLinearApr(totalRequested) + weight * CalculateQuadraticApr(totalRequested);
        }

        private static double CalculateLinearApr(double totalRequested)
        {
            return LinearA * totalRequested + LinearB;
        }

        private static double CalculateQuadraticApr(double totalRequested)
        {
            return QuadraticC * Math.Pow(totalRequested, 2) + QuadraticD * totalRequested + QuadraticE;
        }

        internal static double CalculateFlow(double mwe)
        {
            return 1.05829103 * mwe + 225.96447;
        }
    }
}