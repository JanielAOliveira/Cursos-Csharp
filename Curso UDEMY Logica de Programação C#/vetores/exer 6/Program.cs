using System;

namespace exer_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];

            
            
            for(int i = 0; i < n; i++)
            {
                string [] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }
            int maioridade = idades[0];
            int posicaomaioridade = 0;
            for(int i = 0; i < n; i++)
            {
                if(idades[i] > maioridade)
                {
                    maioridade = idades[i];
                    posicaomaioridade = i;
                }
            }
            Console.WriteLine("Pessoal mais velha: " + nomes[posicaomaioridade]);
        }
    }
}
