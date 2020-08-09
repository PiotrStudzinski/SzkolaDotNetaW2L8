using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the number of elements in the Fibonacci sequence: ");
            byte elements = byte.Parse(Console.ReadLine());

            ulong first = 0;
            ulong second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);

            for (byte i = 1; i < elements - 1; i++)
            {
                ulong current = first + second;
                Console.WriteLine(current);

                first = second;
                second = current;
            }
        }
    }
}
