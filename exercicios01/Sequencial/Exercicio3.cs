using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio3
    {
        public static void Sequence()
        {
            int a = 3;
            int b = 33;
            int salva = a;
            a = b;
            b= salva;
            Console.WriteLine($"Esse é o valor de A: {a}! E esse é o valor de B: {b}");
        }
    }
}