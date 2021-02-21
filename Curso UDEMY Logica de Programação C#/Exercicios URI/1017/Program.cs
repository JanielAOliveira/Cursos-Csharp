using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int kmh, horas;
            double total;

            
            horas = int.Parse(Console.ReadLine());
            kmh = int.Parse(Console.ReadLine());
        

            total = kmh / 12.0 * horas;

            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
