﻿using System;
using System.Globalization;

namespace Exer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * b + 2 * a;
            diagonal = Math.Sqrt(Math.Pow(b , 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
