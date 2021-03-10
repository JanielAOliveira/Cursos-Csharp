using System;
using System.Globalization;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;

            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if(y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double) x / y;
                    Console.WriteLine(div.ToString("F1",CultureInfo.InvariantCulture));
                }

                



            }
        }
    }
}
