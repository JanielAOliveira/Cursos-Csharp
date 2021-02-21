using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, pi = 3.14159, esfera;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            esfera = (4.0/3) * pi * (Math.Pow(R, 3.0));


            Console.WriteLine("VOLUME = " + esfera.ToString("F3", CultureInfo.InvariantCulture));
            
        }
    }
}
