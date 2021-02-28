using System;
using System.Globalization;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novosalario, percentual, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                novosalario = (salario * 0.15) + salario;
                reajuste = salario * 0.15;
                percentual = 0.15 * 100;

            }
            else if (salario <= 800.00)
            {
                novosalario = (salario * 0.12) + salario;
                reajuste = salario * 0.12;
                percentual = 0.12 * 100;
            }
            else if (salario <= 1200.00)
            {
                novosalario = (salario * 0.10) + salario;
                reajuste = salario * 0.10;
                percentual = 0.10 * 100;
            }
            else if (salario <= 2000.00)
            {
                novosalario = (salario * 0.07) + salario;
                reajuste = salario * 0.07;
                percentual = 0.07 * 100;
            }
            else
            {
                novosalario = (salario * 0.04) + salario;
                reajuste = salario * 0.04;
                percentual = 0.04 * 100;
            }
            Console.WriteLine("Novo salario: " + novosalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");

        }
    }
}
