using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio4
    {
        public static void Aammdd()
        {
            string data = "29/10/1993";
            string []newData = data.Split("/");
            string ano = newData[2];
            Console.WriteLine($"{newData[2]}/{newData[1]}/{newData[0]}");
            Console.WriteLine($"{ano.Substring(2)}/{newData[1]}/{newData[0]}");
        }
    }
}