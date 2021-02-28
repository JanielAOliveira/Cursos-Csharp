using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horainicial, horafinal, minutoinicial, minutofinal;

            string[] vet = Console.ReadLine().Split(' ');
            horainicial = int.Parse(vet[0]);
            minutoinicial = int.Parse(vet[1]);
            horafinal = int.Parse(vet[2]);
            minutofinal = int.Parse(vet[3]);


            int instanteinical = horainicial * 60 + minutoinicial;
            int instantefinal = horafinal * 60 + minutofinal;

            int duracao;

            if (instanteinical < instantefinal)
            {
                duracao = instantefinal - instanteinical;
            }
            else
            {
                duracao =  (24 * 60 - instanteinical) + instantefinal;
            }
            int duracaoh = duracao / 60;
            int duracaom = duracao % 60;
                        
            
            Console.WriteLine("O JOGO DUROU " + duracaoh + " HORA(S) E " + duracaom + " MINUTO(S)" );



        }
    }
}
