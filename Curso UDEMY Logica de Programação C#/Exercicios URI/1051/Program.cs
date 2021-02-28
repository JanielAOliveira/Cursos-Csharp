using System;
using System.Globalization;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double taxapagar;
            

            if (salario <= 2000.00)
            {
                taxapagar = 0.0;
                
            }
            else if (salario <= 3000.00)
            {
                taxapagar = (salario - 2000.00) * 0.08;
                           
            }
            else if (salario <= 4500.00)
            {
                taxapagar = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
                
            }
            else 
            {
                taxapagar = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }
                if(taxapagar == 0)
                {
                    Console.WriteLine("Isento");
                }
                else
                {
                    Console.WriteLine("R$ " + taxapagar.ToString("F2", CultureInfo.InvariantCulture));
                }


        }
    }
}
