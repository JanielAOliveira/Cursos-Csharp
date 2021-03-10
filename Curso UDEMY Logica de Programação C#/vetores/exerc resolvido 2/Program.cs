﻿using System;
using System.Globalization;

namespace exerc_resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double [] a;

            n = int.Parse(Console.ReadLine());
            a = new double [n];

            string [] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + a[i];
            }

            double media = soma / n;

            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
