using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, km;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            km = X / Y;

            Console.WriteLine(km.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


        }
    }
}
