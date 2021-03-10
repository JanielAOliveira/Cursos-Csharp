using System;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0, maior, menor;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());


            if(x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            for(int i = menor; i <= maior; i++)
            {  
                if(i % 13 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}
