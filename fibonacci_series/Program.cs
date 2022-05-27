using System;

namespace fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciSeries(10));
        }

        public static int FibonacciSeries(int n)
        {
            int result = 1;
            int lastResult = 1;
            int lastLastResult = 0;
            for (int i = 0; i < n - 1; i++)
            {
                result = lastResult + lastLastResult;
                lastLastResult = lastResult;
                lastResult = result;
            }

            return result;
        }
    }
}
