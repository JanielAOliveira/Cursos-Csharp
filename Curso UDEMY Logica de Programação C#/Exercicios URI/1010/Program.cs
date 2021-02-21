using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, num1, cod2, num2;
            double valor1, valor2, total;

            string[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            num1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = num1 * valor1 + num2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
