﻿using System;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int x = int.Parse(Console.ReadLine());

            while(x != 0)
            {
                if (x % 2 != 0)
                {
                    x = x + 1;
                }

                soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }

        }
    }
}
