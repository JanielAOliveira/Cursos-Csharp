using System;
using System.Globalization;

namespace exer_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            char[] sexo = new char[n];

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vet[1]);

            }
            double maioraltura = alturas[0];
            double menoraltura = alturas[0];
            for(int i = 0; i < n; i++)
            {
                if (alturas[i] < menoraltura)
                {
                    menoraltura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menoraltura.ToString("f2", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (alturas[i] > maioraltura)
                {
                    maioraltura = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maioraltura.ToString("f2", CultureInfo.InvariantCulture));

            double soma_altura_M = 0.0;
            double cont_mulheres = 0;
            double media;
            for(int i = 0; i < n; i++)
            {
                if(sexo[i] == 'F')
                {
                    soma_altura_M = soma_altura_M + alturas[i];
                    cont_mulheres++;
                }
                
            }
            if(cont_mulheres == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                media = soma_altura_M / cont_mulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("f2", CultureInfo.InvariantCulture));
            }
            int cont_homem = 0;

            for (int i = 0; i < n; i++)
            {
                   
                if (sexo[i] == 'M')
                {
                    cont_homem++;
                }
            }
            Console.WriteLine("Numero de homens = " + cont_homem);
        }
    }
}
