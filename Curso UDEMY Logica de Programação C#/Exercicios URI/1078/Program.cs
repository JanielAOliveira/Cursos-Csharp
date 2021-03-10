using System;

namespace exer_resolvido_for_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //if (n >= 2 && n <=1000)
            //{
                for(int i = 1; i <= 10; i++)
                {
                    int resultado = i * n;
                    Console.WriteLine(i + " x " + n + " = " + resultado);
                }
            //}
        }
    }
}
