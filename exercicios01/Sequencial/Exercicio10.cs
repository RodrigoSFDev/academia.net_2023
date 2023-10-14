using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio10
    {
        public static void NumberOfBanknotes()
        {
            Console.WriteLine("Digite o valor que deseja sacar:");
            int value, n200, n100, n50, n20, n10, n5, n2;
            int.TryParse(Console.ReadLine(), out value);
            n200 = value / 200;
            value = value - (n200 * 200);
            Console.WriteLine($"Notas de 200: {n200}");

            n100 = value / 100;
            value = value - (n100 * 100);
            Console.WriteLine($"Notas de 100: {n100}");

            n50 = value / 50;
            value = value - (n50 * 50);
            Console.WriteLine($"Notas de 50: {n50}");

            n20 = value / 20;
            value = value - (n20 * 20);
            Console.WriteLine($"Notas de 20: {n20}");

            n10 = value / 10;
            value = value - (n10 * 10);
            Console.WriteLine($"Notas de 10: {n10}");

            n5 = value / 5;
            value = value - (n5 * 5);
            Console.WriteLine($"Notas de 5: {n5}");

            n2 = value / 2;
            value = value - (n2 * 2);
            Console.WriteLine($"Notas de 2: {n2}");
        }
    }
}