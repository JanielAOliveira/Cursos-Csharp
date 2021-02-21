using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idias, anos, meses, dias, resto;

            idias = int.Parse(Console.ReadLine());

            anos = idias / 365;
            resto = idias % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
