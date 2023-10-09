using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores01
{
    public class Exercicio1
    {
        public static void  NumberEven()
        {
            int[] vetor = new int[10];
            int even = 0;
            int odd = 0;

            for(int i =0; i < vetor.Length; i += 1)
            {
                Console.WriteLine($"Digite o valor da posição: {i +1}");
                vetor[i] = int.Parse(Console.ReadLine()!);
            }

            for(int i = 0; i < vetor.Length; i += 1)
            {
                if(vetor[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"A quantidade números pares é: {even}");
            Console.WriteLine($"A quantidade números impares é: {odd}");
        }
    }
}