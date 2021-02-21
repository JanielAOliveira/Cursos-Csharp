using System;

namespace uri1018 {
    class Program {
        static void Main(string[] args) 
        {
            int N, quociente, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;
 
        }
    }
}
