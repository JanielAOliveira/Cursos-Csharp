using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n ; i++)
            {

                x = int.Parse(Console.ReadLine());

                if(x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if(x < 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
            }
        }
    }
}
