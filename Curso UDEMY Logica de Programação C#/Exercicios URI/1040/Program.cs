using System;
using System.Globalization;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;

            string [] valores = Console.ReadLine().Split(' ');
            n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(valores[3], CultureInfo.InvariantCulture);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

         

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado");          
            }
            else if (media >= 5.0 && media < 7.0)
            {
                Console.WriteLine("Aluno em exame.");

                
                double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                
                double mediafinal;
                mediafinal = (exame + media) / 2;
                

                if (mediafinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediafinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            
        }
    }
}


