using System;
using System.Globalization;

namespace for_while
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            char repetir;
            do
            {
            Console.Write("Digite a temperatura em celsius: ");
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            F = 9.0 * C / 5.0 + 32.0;
            Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("deseja repetir (s/n)? ");
            repetir = char.Parse(Console.ReadLine());
            }
            while(repetir == 's');
        }
    }
}
