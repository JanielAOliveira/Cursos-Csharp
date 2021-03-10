using System;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            //int f = 1;
            for(int i = 1; i <= n; i++)
            {   
               fatorial = fatorial * i;
               
            }
            Console.WriteLine(fatorial);
            
        }
    }
}
