using System;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 0; i < n; i++)
            {
                int segundo = inicio + 1;
                int terceiro = inicio + 2;
                Console.WriteLine(inicio + " " + segundo + " " + terceiro + " PUM");

                inicio = inicio + 4;

            }
        }
    }
}
