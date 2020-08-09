using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            do
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            } while (count <= 1000);
        }
    }
}
