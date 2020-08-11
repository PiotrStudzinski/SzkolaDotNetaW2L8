using System;
using System.Globalization;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOne = 1;
            int counterTwo = 0;

            Console.Write("Give an integer: ");
            uint number = uint.Parse(Console.ReadLine());

            for (uint i = 1; i <= number; i++)
            {
                if (counterOne > counterTwo)
                {
                    Console.Write($"{i} ");
                    counterTwo++;
                }
                else
                {
                    counterTwo = 0;
                    counterOne++;
                    Console.WriteLine();
                    i--;
                }
            }
        }
    }
}
