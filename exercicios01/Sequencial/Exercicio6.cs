using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio6
    {
        public static void Screws()
        {
            Console.WriteLine("Informe os dados para o Parafuso A:");
            Console.WriteLine("Código do Parafuso A: ");
            string codigoA = Console.ReadLine()!;
            Console.WriteLine("Quantidade de peças do Parafuso A: ");
            int quantidadeA;
            int.TryParse(Console.ReadLine(), out quantidadeA);
            Console.WriteLine("Valor unitário do Parafuso A: ");
            double valorUnitarioA;
            double.TryParse(Console.ReadLine(), out valorUnitarioA);
            Console.WriteLine("Porcentagem de IPI para o Parafuso A (%): ");
            double ipiA;
            double.TryParse(Console.ReadLine(), out ipiA);

            Console.WriteLine("Informe os dados para o Parafuso B:");
            Console.WriteLine("Código do Parafuso B: ");
            string codigoB = Console.ReadLine()!;
            Console.WriteLine("Quantidade de peças do Parafuso B: ");
            int quantidadeB;
            int.TryParse(Console.ReadLine(), out quantidadeB);
            Console.WriteLine("Valor unitário do Parafuso B: ");
            double valorUnitarioB;
            double.TryParse(Console.ReadLine(), out valorUnitarioB);
            Console.WriteLine("Porcentagem de IPI para o Parafuso B (%): ");
            double ipiB;
            double.TryParse(Console.ReadLine(), out ipiB);


            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Parafuso A - Código: {codigoA}");
            Console.WriteLine($"Quantidade: {quantidadeA}");
            Console.WriteLine($"Valor Unitário: R$ {valorUnitarioA:F2}");
            Console.WriteLine($"IPI: {ipiA}%");

            Console.WriteLine($"\nParafuso B - Código: {codigoB}");
            Console.WriteLine($"Quantidade: {quantidadeB}");
            Console.WriteLine($"Valor Unitário: R$ {valorUnitarioB:F2}");
            Console.WriteLine($"IPI: {ipiB}%");
        }
    }
}