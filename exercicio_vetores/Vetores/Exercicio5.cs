using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vetores5
{
    public class Exercicio5
    {
        public static void SmallElements()
        {
            int[] value = new int[10];
            int smallNumber = int.MaxValue;
            int position = 0;

            for(int i = 0; i < value.Length; i += 1)
            {
            Console.WriteLine($"Digite o valor da posição {i +1}!");
            value[i] = int.Parse(Console.ReadLine()!);
                if(smallNumber > value[i])
                {
                    smallNumber = value[i];
                    position = i;
                }
            }
            Console.WriteLine($"O menor número é {smallNumber} e sua posição é {position}");
        }
    }
}