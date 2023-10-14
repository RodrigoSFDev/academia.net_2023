using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio13
    {
        public static void TotalSalary()
        {
            Console.Write("Digite o valor do salário mínimo: ");
            decimal salarioMinimo;
            decimal.TryParse(Console.ReadLine(), out salarioMinimo);

            Console.Write("Digite o preço de custo de cada bicicleta: ");
            decimal precoCusto;
            decimal.TryParse(Console.ReadLine(), out precoCusto);

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            int bicicletasVendidas;
            int.TryParse(Console.ReadLine(), out bicicletasVendidas);

            decimal salarioBase = 2 * salarioMinimo;
            decimal comissao = bicicletasVendidas * precoCusto * 0.15M;
            decimal salarioFinal = salarioBase + comissao;

            Console.WriteLine("O salário do vendedor é: R$ " + salarioFinal);
        }
    }
}