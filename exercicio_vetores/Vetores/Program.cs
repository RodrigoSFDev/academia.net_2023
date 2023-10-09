// See https://aka.ms/new-console-template for more information
using Vetores01;
using Vetores2;
using Vetores3;
using Vetores4;
using Vetores5;
using Vetores6;

{
  Console.WriteLine("Digite o número do exercício que você deseja rodar:");
        int exercicio;
        int.TryParse(Console.ReadLine(), out exercicio);

        switch (exercicio)
        {
            case 1:
                Exercicio1.NumberEven();
                break;
            case 2:
                Exercicio2.SumOFElements();
                break;
            case 3:
                Exercicio3.PrimeNumbers();
                break;
            case 4:
              Exercicio4.multElements();
                break;    
            case 5:
              Exercicio5.SmallElements();
                break;    
            case 6:
              Exercicio6.ReverseSequence();
                break;    
            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
}