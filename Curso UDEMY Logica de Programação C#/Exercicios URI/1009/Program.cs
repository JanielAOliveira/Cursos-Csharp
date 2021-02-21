using System;
using System.Globalization;
namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totvendas, total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totvendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            total = salario + totvendas * 0.15;
            
            
            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
