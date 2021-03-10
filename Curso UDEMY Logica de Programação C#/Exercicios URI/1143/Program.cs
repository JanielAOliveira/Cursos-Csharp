using System;

namespace _1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for(int i = 1; i <= n; i++)
            {

                int inicio = i;
               int segundo = i * i;
               int terceiro = i * i * i;
               Console.WriteLine(inicio + " " + segundo + " " + terceiro);

            }
        }
    }
}
