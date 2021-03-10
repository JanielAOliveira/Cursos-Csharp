using System;

namespace _1144
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
                int segundo2 = segundo + 1;
                int terceiro2 = terceiro +1;

                Console.WriteLine($"{inicio} {segundo} {terceiro}");
                Console.WriteLine($"{inicio} {segundo2} {terceiro2}");

                
            }
        }
    }
}
