using System;

namespace FitnessTracker.utils
{
    static class CalculatePercentage
    {
        public static double GetPercentage(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("The denominator cannot be zero.");
            }

            return (num1 / num2) * 100;
        }
    }
}
