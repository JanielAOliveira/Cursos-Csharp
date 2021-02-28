using System;
using System.Globalization;

namespace Sintaxe_Cumulativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double multa;

            minutos = int.Parse(Console.ReadLine());

            multa = 50.0;

            if(minutos > 100)
            {
                multa += (minutos - 100) * 2;
            }
            Console.WriteLine("Valor a pagar: R$" + multa.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
