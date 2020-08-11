using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the number: ");
            uint number = uint.Parse(Console.ReadLine());

            for (uint i = 1; i < number + 1; i++)
            {
                for (uint j = 1; j <= (number * 2) - 1; j++)
                {
                    if ((j <= number - i) || (j >= number + i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

            for (uint i = number - 1; i > 0; i--)
            {
                for (uint j = 1; j <= (number * 2); j++)
                {
                    if ((j <= number - i) || (j >= number + i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
