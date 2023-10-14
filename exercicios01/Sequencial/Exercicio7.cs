using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio7
    {
        public static void SellerDetails()
        {
            Console.WriteLine("Digite o número do vendedor:");
            int numVendedor;
            int.TryParse(Console.ReadLine(), out numVendedor);
            Console.WriteLine("Salário fixo do vendedor:");
            double salarioFixo;
            double.TryParse(Console.ReadLine(), out salarioFixo);
            Console.WriteLine("Total de Vendas em R$:");
            double totalVendas;
            double.TryParse(Console.ReadLine(), out totalVendas);
            Console.WriteLine("Percentual que ganha sobre o total de vendas:");
            double porcentagemVendas;
            double.TryParse(Console.ReadLine(), out porcentagemVendas);
            double salarioTotal = salarioFixo + ((totalVendas * porcentagemVendas)/ 100);

            Console.WriteLine($"Número do vendedor: {numVendedor} \nSalário total: {salarioTotal}");

        }
    }
}