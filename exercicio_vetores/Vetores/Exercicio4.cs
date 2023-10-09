using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores4
{
    public class Exercicio4
    {
        public static void multElements()
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetorResult = new int[10];

        for(int i =0; i < vetor1.Length; i += 1)
            {
                Console.WriteLine($"Digite o valor da posição {i +1} do Primeiro Vetor!");
                vetor1[i] = int.Parse(Console.ReadLine()!);
            }
        for(int i =0; i < vetor2.Length; i += 1)
            {
                Console.WriteLine($"Digite o valor da posição {i +1} do Segundo Vetor!");
                vetor2[i] = int.Parse(Console.ReadLine()!);
            }

            for(int i = 0; i < vetor1.Length; i += 1)
            {
                for( int j = 0; j < vetor2.Length; j += 1)
                {
                    if(i == j)
                    {
                        vetorResult[i] = vetor1[i] * vetor2[j];
                    }
                }
            }
            Console.WriteLine($"Resultado da somo do Vetor1 e Vetor2: {string.Join(", ", vetorResult)}");
        }
    }
}