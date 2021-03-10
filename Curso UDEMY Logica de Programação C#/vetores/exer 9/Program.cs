using System;
using System.Globalization;

namespace exer_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            string[] mercadoria = new string[n];
            double[] preco_compra = new double[n];
            double[] preco_venda = new double[n];

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                mercadoria[i] = vet[0];
                preco_compra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                preco_venda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            int cont_abaixo_10 = 0;
            int cont_10_20 = 0;
            int cont_acima_20 = 0;
            for(int i = 0; i < n; i++)
            {
                double lucro = preco_venda[i] - preco_compra[i];
                double porcentagem_lucro = lucro / preco_compra[i] * 100.0;

                if(porcentagem_lucro < 10.0)
                {
                    cont_abaixo_10++;
                }
                else if(porcentagem_lucro <= 20.0)
                {
                    cont_10_20++;
                }
                else
                {
                    cont_acima_20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + cont_abaixo_10 );
            Console.WriteLine("Lucro entre 10% e 20% " + cont_10_20 );
            Console.WriteLine("Lucro acima de 20%: " + cont_acima_20);

            double totalCompra = 0.0;
            double totalVenda = 0.0;
            for (int i = 0; i < n; i++) 
            {
                totalCompra = totalCompra + preco_compra[i];
                totalVenda = totalVenda + preco_venda[i];
            }

            double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
