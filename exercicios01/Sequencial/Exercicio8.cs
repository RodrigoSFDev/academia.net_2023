using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio8
    {
        public static void TemperatureConversion()
        {
            Console.WriteLine("Digite a temperatura em graus Celsius:");
            double celsius;
            double.TryParse(Console.ReadLine(),  out celsius);
            double fahrenheit = (9 * celsius + 160)/5;
            Console.WriteLine($"{celsius} em Celsius é igual a {fahrenheit} em Fahrenheit");
        }
    }
}