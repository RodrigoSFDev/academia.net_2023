using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores3
{
    public class Exercicio3
    {
        public static void PrimeNumbers()
        {
            int[] vetor = new int[10];
            List<int> vetorPrime = new ();

        for(int i =0; i < vetor.Length; i += 1)
            {
                Console.WriteLine($"Digite o valor da posição[index] {i}!");
                vetor[i] = int.Parse(Console.ReadLine()!);
            }

            for(int i = 0; i < vetor.Length; i += 1)
            {
                if(vetor[i] == 1)
                {
                    vetorPrime.Add(i);
                }
                if(vetor[i] == 2)
                {
                    vetorPrime.Add(i);
                }
                if(vetor[i] == 3)
                {
                    vetorPrime.Add(i);
                }
                if(vetor[i] == 5)
                {
                    vetorPrime.Add(i);
                }
                if(vetor[i] == 7)
                {
                    vetorPrime.Add(i);
                }
                if (vetor[i] % 2 != 0 && vetor[i] % 5 != 0 && vetor[i] % 7 !=0 && vetor[i] % 3 != 0)
                {
                    vetorPrime.Add(i);
                }
            }
            Console.WriteLine($"Esses são as posições dos números primos: {string.Join(", ",vetorPrime)}");
        }
    }
}