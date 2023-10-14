using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio2
    {
        public static void ArithmeticAverage()
        {
            Console.WriteLine("Digite um número:");
            double valorA;
            double.TryParse(Console.ReadLine(), out valorA);
            Console.WriteLine("Digite um segundo número:");
            double valorB;
            double.TryParse(Console.ReadLine(), out valorB);
            Console.WriteLine("Digite um terceiro número:");
            double valorC;
            double.TryParse(Console.ReadLine(), out valorC);
            Console.WriteLine("Digite um quarto número:");
            double valorD;
            double.TryParse(Console.ReadLine(), out valorD);
            double media = (valorA + valorB + valorC + valorD) / 4;
            Console.WriteLine($"A média aritmética de {valorA}, {valorB}, {valorC} e {valorD} é: {media}");
        }
    }
}