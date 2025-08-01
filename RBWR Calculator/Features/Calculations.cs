using System;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace RBWR_Calculator.Features
{
    public class Calculations
    {
        private const double QuadraticCUnit1 = -0.000002121531845;
        private const double QuadraticDUnit1 = 0.07616;
        private const double QuadraticEUnit1 = 10.36918;

        private const double QuadraticCUnit2 = 0.0000062606;
        private const double QuadraticDUnit2 = 0.068219;
        private const double QuadraticEUnit2 = 13.9919;

        internal static double CalculateApr(double totalRequested, bool isUnit1 = true)
        {
            if (isUnit1)
                return CalculateQuadraticAprUnit1(totalRequested);
            else
                return CalculateQuadraticAprUnit2(totalRequested);
        }

        private static double CalculateQuadraticAprUnit2(double totalRequested)
        {
            return QuadraticCUnit2 * Math.Pow(totalRequested, 2) + QuadraticDUnit2 * totalRequested + QuadraticEUnit2;
        }

        private static double CalculateQuadraticAprUnit1(double totalRequested)
        {
            return QuadraticCUnit1 * Math.Pow(totalRequested, 2) + QuadraticDUnit1 * totalRequested + QuadraticEUnit1;
        }

        public static double CalculateMWeFromApr(double apr)
        {
            if (apr <= QuadraticEUnit1)
                return 0;

            double a = QuadraticCUnit1;
            double b = QuadraticDUnit1;
            double c = QuadraticEUnit1 - apr;

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

        internal static double CalculateTurbineValve(double mwe)
        {
            return -0.0000079063 * Math.Pow(mwe, 2) + 0.068857 * mwe + 15.4958;
        }

        internal static double CalculateCondenserFlowU1(double mwe)
        {
            return -0.0001816074 * Math.Pow(mwe, 2) + 3.109592 * mwe + 724.8318;
        }

        internal static double CalculateCoolingU2(double mwe)
        {
            return 0.0000023700 * Math.Pow(mwe, 2) + 0.080997 * mwe + -16.2942;
        }

        internal static double CalculateSealingU2(double mwe)
        {
            return -0.0000411878 * Math.Pow(mwe, 2) + 0.131859 * mwe + -29.2782;
        }
    }
}