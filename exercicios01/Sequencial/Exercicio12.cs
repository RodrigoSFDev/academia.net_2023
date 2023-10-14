using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio12
    {
        public static void TaxiResult()
        {
            Console.Write("Digite a marcação do odômetro no início do dia: ");
            int inicioOdometro;
            int.TryParse(Console.ReadLine(), out inicioOdometro);

            Console.Write("Digite a marcação do odômetro no final do dia: ");
            int finalOdometro;
            int.TryParse(Console.ReadLine(), out finalOdometro);

            Console.Write("Digite o número de litros de combustível gastos: ");
            decimal litrosGastos;
            decimal.TryParse(Console.ReadLine(), out litrosGastos);

            Console.Write("Digite o valor total recebido dos passageiros: ");
            decimal valorRecebido;
            decimal.TryParse(Console.ReadLine(), out valorRecebido);

            int totalQuilometragem = finalOdometro - inicioOdometro;

            decimal mediaConsumo = totalQuilometragem / litrosGastos;

            decimal lucroDia = valorRecebido - (litrosGastos * 6.9M);

            Console.WriteLine($"A média do consumo é: {mediaConsumo}Km/l");
            Console.WriteLine($"O lucro líquido do dia é: R$ {lucroDia}");
        }
    }
}