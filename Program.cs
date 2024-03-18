        public static int FindMaxValue(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.", nameof(array));
            }

            double max = array[0];
            foreach (int value in array)
            {
                if (value > max)
                {
                    max = value; 
                }
            }
            return max;
        }
    }
