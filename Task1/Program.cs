using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i != 1)
                {
                    int x = 0;
                    bool isPrime = true;
                    x = i / 2;
                    for (int j = 2; j <= x; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"w przedziale od 1 do 100 jest {count} liczb pierwszych.");
        }
    }
}
