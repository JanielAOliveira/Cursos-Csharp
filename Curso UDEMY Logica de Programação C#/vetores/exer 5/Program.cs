using System;
using System.Globalization;

namespace exer_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            int soma = 0;
            double media;
            int quantidadepares = 0;
            for(int i = 0; i < n; i++)
            {
                //int soma = 0;
                if(vet[i] % 2 == 0)
                {
                   soma = soma + vet[i];
                   quantidadepares++;
                    
                }
                
            }
            if(quantidadepares == 0)
            {
                Console.WriteLine("Não há números pares");
            }
            else
            {
                media = (double) soma / quantidadepares;
                Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
