using System;
using System.Globalization;

namespace exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            n = int.Parse(Console.ReadLine());
            double [] vet = new double[n];
            string [] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {   
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            double maior = 0.0;
            int posicaomaior = 0;

            for (int i = 0; i < n; i++)
            {
                if(vet[i] > maior)
                {
                    maior = vet[i];
                    posicaomaior = i;
                }
            }
            Console.WriteLine(maior.ToString("f1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaomaior);
        }
    }        
}
