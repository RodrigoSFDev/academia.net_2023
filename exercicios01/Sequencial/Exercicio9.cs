using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio9
    {
        public static void Installments()
        {
            Console.WriteLine("Digite o valor do produto:");
            double valueOfProduct;
            double.TryParse(Console.ReadLine(), out valueOfProduct);
            double valuePart = Math.Floor(valueOfProduct / 3);
            double valueInflow = valueOfProduct - (valuePart * 2);
            Console.WriteLine($"O valor do produto é {valueOfProduct}, a entrada deve ser de {valueInflow} e ficara duas parcelas de {valuePart}");
        }
    }
}