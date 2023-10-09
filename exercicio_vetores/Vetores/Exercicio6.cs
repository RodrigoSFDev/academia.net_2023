using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores6
{
    public class Exercicio6
    {
        public static void ReverseSequence()
        {
            int[] numberSequence = new int[10];
            int[] numberReverse = new int[10];

            for(int i = 0; i < numberSequence.Length; i += 1)
            {
            Console.WriteLine($"Digite o valor da posição {i +1}!");
            numberSequence[i] = int.Parse(Console.ReadLine()!);
            }
            for(int i = numberSequence.Length - 1;i >= 0; i -= 1 )
            {
                numberReverse[numberSequence.Length - 1 - i] = numberSequence[i];
            }
            Console.WriteLine(string.Join(", ", numberSequence));
            Console.WriteLine(string.Join(", ", numberReverse));
        }
    }
}