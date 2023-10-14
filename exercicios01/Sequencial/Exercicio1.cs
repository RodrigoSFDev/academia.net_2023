using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio1
    {
        public static void ArithmeticMean()
        {
            Console.WriteLine("Digite um número:");
            double valorA;
            double.TryParse(Console.ReadLine(), out valorA);
            Console.WriteLine("Digite mais um número:");
            double valorB;
            double.TryParse(Console.ReadLine(), out valorB);
            double media = (valorA + valorB) / 2;
            Console.WriteLine($"A média aritmética de {valorA} mais {valorB} é: {media}");
        }
    }
}