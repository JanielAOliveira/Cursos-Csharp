using System;


namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorab, maior;

            string [] numeros = Console.ReadLine().Split(' ');
            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            c = int.Parse(numeros[2]);

            maiorab = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorab + c + Math.Abs(maiorab - c)) / 2;


            Console.WriteLine(maior + " eh o maior");
        }
    }
}
