using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio5
    {
        public static void AverageConsumption()
        {
            int combustivel = 50;
            int km = 400;
            int medioKmL = km / combustivel;
            Console.WriteLine($"Combustivel: {combustivel}, Km: {km}, Km/L: {medioKmL}");
        }
    }
}