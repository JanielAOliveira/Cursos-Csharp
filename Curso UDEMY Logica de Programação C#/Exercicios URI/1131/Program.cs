using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int inter, gremio, novogrenal = 1, grenais = 0;
            int vitointer = 0;
            int vitogremio = 0;
            int empate = 0;
            
            
            while (novogrenal == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');
                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);

                grenais = grenais + 1;

                if (inter > gremio)
                {
                    vitointer = vitointer + 1;
                }
                else if (gremio > inter)
                {
                    vitogremio = vitogremio + 1;
                }
                else
                {
                    empate = empate + 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novogrenal = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitointer);
            Console.WriteLine("Gremio:" + vitogremio);
            Console.WriteLine("Empates: " + empate);

            if (vitointer > vitogremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitogremio > vitointer)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }


        }
    }
}
