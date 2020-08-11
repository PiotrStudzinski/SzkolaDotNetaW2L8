using System;
using System.Diagnostics.CodeAnalysis;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for(int i = 1; i <= 20; i++)
            {
                sum += (1.0 / i);
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
