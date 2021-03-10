using System;
using System.Globalization;

namespace exer_7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            int n;

            n = int.Parse(Console.ReadLine());
            string[] nomes = new string [n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for(int i = 0; i < n; i++)
                {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
                }
                Console.WriteLine("Alunos aprovados");
                //double soma;
                double media;
                for(int i = 0; i < n; i++)
                {
                    media = (nota1[i] + nota2[i]) / 2;
                    // = soma / 2;
                    if(media >= 6)
                    {
                        Console.WriteLine(nomes[i]);

                    }
                }


            }
        }
    }
}
