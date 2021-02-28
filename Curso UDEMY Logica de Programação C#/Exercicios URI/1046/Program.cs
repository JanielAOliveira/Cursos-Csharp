using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            
            if (horaFinal <= horaInicial) 
            {
                tempo = horaFinal + 24 - horaInicial;
            }
            else
            {
                tempo = Math.Abs(horaInicial - horaFinal);
            }   

            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
        }
    }
}


