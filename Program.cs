using System;

namespace AverageCalculator
{
    class AvarageCalculator
    {
       static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            
            double average = CalculateAverage(numbers);
            
            Console.WriteLine($"The average is: {average}");
        }
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
