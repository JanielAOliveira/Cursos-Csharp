using System;

namespace exer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            int [] vet = new int [n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
                
            }
            Console.WriteLine();
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    soma++;
                }
                
            }
            Console.WriteLine(soma);
            

        }
    }
}
