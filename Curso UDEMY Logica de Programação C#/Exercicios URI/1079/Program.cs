using System;
using System.Globalization;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double n1, n2, n3, media;
                string[] vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));


            }
        }
    }
}
