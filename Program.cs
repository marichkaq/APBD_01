using System;

namespace AverageCalculator
{
    class AvarageCalculator
    {
        public static double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty", nameof(array));
            }

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }
    }
}