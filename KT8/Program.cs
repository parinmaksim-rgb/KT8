using System;

namespace KT8_CheckedUnchecked_BestPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SumChecked(new[] {{ 1, 2, 3 }}) = {SumCalculator.SumChecked(new[] { 1, 2, 3 })}");

            Console.Write("SumChecked(new[] { int.MaxValue, 1 }) -> ");
            int sumResult = SumCalculator.SumChecked(new[] { int.MaxValue, 1 });
            Console.WriteLine($"Возвращено значение: {sumResult}");

            int n1 = SumCalculator.ParseInput("42");
            Console.WriteLine($"ParseInput(\"42\") -> n == {n1}, без исключений");

            int n2 = SumCalculator.ParseInput("abc");
            Console.WriteLine($"ParseInput(\"abc\") -> возвращает {n2}, без исключений");
        }
    }
}