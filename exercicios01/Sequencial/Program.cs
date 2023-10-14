// See https://aka.ms/new-console-template for more information
using Sequencial;

{
  Console.WriteLine("Digite o número do exercício que você deseja rodar:");
        int exercicio;
        int.TryParse(Console.ReadLine(), out exercicio);

        switch (exercicio)
        {
            case 1:
                Exercicio1.ArithmeticMean();
                break;
            case 2:
                Exercicio2.ArithmeticAverage();
                break;
            case 3:
                Exercicio3.Sequence();
                break;
            case 4:
              Exercicio4.Aammdd();
                break;    
            case 5:
              Exercicio5.AverageConsumption();
                break;    
            case 6:
              Exercicio6.Screws();
                break;    
            case 7:
              Exercicio7.SellerDetails();
                break;    
            case 8:
              Exercicio8.TemperatureConversion();
                break;    
            case 9:
              Exercicio9.Installments();
                break;    
            case 10:
              Exercicio10.NumberOfBanknotes();
                break;    
            case 11:
              Exercicio11.NumberOfVotes();
                break;    
            case 12:
              Exercicio12.TaxiResult();
                break;    
            case 13:
              Exercicio13.TotalSalary();
                break;    
            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
}
