using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerof, horas;
            double salarioh, salario;

            numerof = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salarioh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * salarioh;

            Console.WriteLine("NUMBER = " + numerof);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            

        }
    }
}
