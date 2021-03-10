using System;
using System.Globalization;

namespace exer_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            double[] valores = new double[n];
            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                valores[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                
            }
            double soma = 0.0;
            //double media = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma = soma + valores[i];
            }
            double media = soma / n;
            Console.WriteLine(media.ToString("f3", CultureInfo.InvariantCulture));
            for(int i = 0; i < n; i++)
            {
                if(valores[i] < media)
                {
                    Console.WriteLine(valores[i].ToString("f1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
