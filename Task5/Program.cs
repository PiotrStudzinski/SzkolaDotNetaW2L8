using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"the power of number {i} is: {Math.Pow(i, 3)}");
            }
        }
    }
}
