using System;
using System.Globalization;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantia, n, coelhos = 0, ratos = 0, sapos = 0;
            char tipo;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                if(tipo == 'C')
                {
                    coelhos = coelhos + quantia;     
                }
                else if(tipo == 'R')
                {
                    ratos = ratos + quantia;
                }
                else
                {
                    sapos = sapos + quantia;
                }
            }
            int total = coelhos + ratos + sapos;
            double porcentagemcoelhos = (double) coelhos / total * 100.0;
            double porcentagemratos = (double) ratos / total * 100.0;
            double porcentagemsapos = (double) sapos / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemcoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemratos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemsapos.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}
