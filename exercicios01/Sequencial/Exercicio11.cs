using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sequencial
{
    public class Exercicio11
    {
        public static void NumberOfVotes()
        {
            int voteValid, voteBlank, voteNull, totalVoters;
            Console.WriteLine("Digite a quantidade de votos válidos:");
            int.TryParse(Console.ReadLine(), out voteValid);

            Console.WriteLine("Digite a quantidade de votos em branco:");
            int.TryParse(Console.ReadLine(), out voteBlank);

            Console.WriteLine("Digite a quantidade de votos nulos:");
            int.TryParse(Console.ReadLine(), out voteNull);
            double percentBlank, percentNull, percentValid;
            totalVoters = voteBlank + voteNull + voteValid;

            percentBlank = (voteBlank * 100) / totalVoters;
            percentNull = (voteNull * 100) / totalVoters;
            percentValid = (voteValid * 100) / totalVoters;

            Console.WriteLine($"Foram um total de {totalVoters} eleitores nessa eleição");
            Console.WriteLine($"Resultado dos votos em porcentagem foram: {percentBlank}% Brancos, {percentNull}% Nulos e {percentValid}% Válidos");
        }
    }
}