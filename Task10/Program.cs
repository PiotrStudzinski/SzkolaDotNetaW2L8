using System;
using System.Threading;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the number: ");
            uint numberOne = uint.Parse(Console.ReadLine());

            Console.Write("Give the number: ");
            uint numberTwo = uint.Parse(Console.ReadLine());

            uint leastMultiple;
            uint first = numberOne;
            uint second = numberTwo;

            while (numberOne != numberTwo)
            {
                if (numberOne > numberTwo)
                {
                    numberOne -= numberTwo;
                }
                else
                {
                    numberTwo -= numberOne;
                }
            }
            leastMultiple = (first * second) / numberOne;
            Console.WriteLine($"Least Common Multiple is: {leastMultiple}");
        }
    }
}
