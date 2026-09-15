using System;

namespace KT8_CheckedUnchecked_BestPractices
{
    public static class SumCalculator
    {
        public static int SumChecked(int[] numbers)
        {
            try
            {
                int sum = 0;
                checked
                {
                    foreach (int number in numbers)
                    {
                        sum += number;
                    }
                }
                return sum;
            }
            catch (OverflowException)
            {
                Console.WriteLine("[Предупреждение] Произошло переполнение при суммировании.");
                return int.MaxValue;
            }
        }

        public static int ParseInput(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            return 0;
        }
    }
}