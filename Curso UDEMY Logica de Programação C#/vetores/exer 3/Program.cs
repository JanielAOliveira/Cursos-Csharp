using System;

namespace exer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string [] valoresa = Console.ReadLine().Split(' ');

            int[] b = new int[n];
            string [] valoresb = Console.ReadLine().Split(' ');

            //int soma;
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(valoresa[i]);
                b[i] = int.Parse(valoresb[i]);

               //soma = a[i] + b[i];
               //Console.Write(soma + " ");
            }
            int [] c = new int[n];
            for(int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i] + " ");

            
            }
        }
    }
}
