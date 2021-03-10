using System;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;

            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    cont = i * i;
                    Console.WriteLine(i + "^2 = " + cont);
                }
                
                
            }
            

        }
    }
}
