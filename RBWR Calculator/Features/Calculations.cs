using System;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace RBWR_Calculator.Features
{
    public class Calculations
    {
        private static readonly double _linearA = 0.07342;
        private static readonly double _linearB = 10.99763;

        private static readonly double _quadraticC = -0.000002121531845;
        private static readonly double _quadraticD = 0.07616;
        private static readonly double _quadraticE = 10.36918;

        private static readonly double _hysteresis = 10;
        private static double _meetingPoint;

        internal static void CalculateMeetingPoint()
        {
            double a = _quadraticC;
            double b = _quadraticD - _linearA;
            double c = _quadraticE - _linearB;

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

            if ((totalRequested < _meetingPoint - _hysteresis || forceLinear) && !forceQuadratic) // use linear fully
            {
                return CalculateLinearApr(totalRequested);
            }
            if (totalRequested > _meetingPoint + _hysteresis || forceQuadratic) // use quadratic fully
            {
                return CalculateQuadraticApr(totalRequested);
            }

            double weight = (totalRequested - (_meetingPoint - _hysteresis)) / (2 * _hysteresis);
            return (1 - weight) * CalculateLinearApr(totalRequested) + weight * CalculateQuadraticApr(totalRequested);
        }

        private static double CalculateLinearApr(double totalRequested)
        {
            return _linearA * totalRequested + _linearB;
        }

        private static double CalculateQuadraticApr(double totalRequested)
        {
            return _quadraticC * Math.Pow(totalRequested, 2) + _quadraticD * totalRequested + _quadraticE;
        }

        internal static double CalculateFlow(double apr)
        {
            return 82.8 + (13.7 * apr) + (5.87 * Math.Pow(10, -3) * Math.Pow(apr, 2));
        }
    }
}