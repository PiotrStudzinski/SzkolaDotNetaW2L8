using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the number: ");
            uint number = uint.Parse(Console.ReadLine());

            string binary = "";

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    binary += "0";
                }
                else
                {
                    binary += "1";
                }

                number /= 2;
            }

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }

    }
}
