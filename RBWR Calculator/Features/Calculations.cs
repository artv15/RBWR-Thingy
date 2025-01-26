using System;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace RBWR_Calculator.Features
{
    public class Calculations
    {
        private const double QuadraticC = -0.000002121531845;
        private const double QuadraticD = 0.07616;
        private const double QuadraticE = 10.36918;

        internal static double CalculateApr(double totalRequested)
        {
            return CalculateQuadraticApr(totalRequested);
        }

        private static double CalculateQuadraticApr(double totalRequested)
        {
            return QuadraticC * Math.Pow(totalRequested, 2) + QuadraticD * totalRequested + QuadraticE;
        }

        public static double CalculateMWeFromApr(double apr)
        {
            if (apr <= QuadraticE)
                return 0;

            double a = QuadraticC;
            double b = QuadraticD;
            double c = QuadraticE - apr;

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return double.NaN;
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);

            double solution1 = (-b + sqrtDiscriminant) / (2 * a);
            double solution2 = (-b - sqrtDiscriminant) / (2 * a);

            if (solution1 >= 0)
            {
                return solution1;
            }
            if (solution2 >= 0)
            {
                return solution2;
            }
            return double.NaN;
        }

        internal static double CalculateFlow(double mwe)
        {
            return 1.05829103 * mwe + 225.96447;
        }
    }
}