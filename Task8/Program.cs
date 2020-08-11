using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any text: ");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}
