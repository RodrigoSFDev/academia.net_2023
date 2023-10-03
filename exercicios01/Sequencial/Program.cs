// See https://aka.ms/new-console-template for more information
// { Exercicio 1
//   Console.WriteLine("Digite um número:");
//   double valorA;
//   double.TryParse(Console.ReadLine(), out valorA);
//   Console.WriteLine("Digite mais um número:");
//   double valorB;
//   double.TryParse(Console.ReadLine(), out valorB);
//   double media = (valorA + valorB) / 2;
//   Console.WriteLine($"A média aritmética de {valorA} mais {valorB} é: {media}");
// }

// { Exercicio 2
//   Console.WriteLine("Digite um número:");
//   double valorA;
//   double.TryParse(Console.ReadLine(), out valorA);
//   Console.WriteLine("Digite um segundo número:");
//   double valorB;
//   double.TryParse(Console.ReadLine(), out valorB);
//   Console.WriteLine("Digite um terceiro número:");
//   double valorC;
//   double.TryParse(Console.ReadLine(), out valorC);
//   Console.WriteLine("Digite um quarto número:");
//   double valorD;
//   double.TryParse(Console.ReadLine(), out valorD);
//   double media = (valorA + valorB + valorC + valorD) / 4;
//   Console.WriteLine($"A média aritmética de {valorA}, {valorB}, {valorC} e {valorD} é: {media}");
// }

// { Exercicio 3
//   int a = 3;
//   int b = 33;
//   int salva = a;
//   a = b;
//   b= salva;
//   Console.WriteLine($"Esse é o valor de A: {a}! E esse é o valor de B: {b}");
// }

// { Exercicio
//   string data = "29/10/1993";
//   string []newData = data.Split("/");
//   string ano = newData[2];
//   Console.WriteLine($"{newData[2]}/{newData[1]}/{newData[0]}");
//   Console.WriteLine($"{ano.Substring(2)}/{newData[1]}/{newData[0]}");
// }

{
  int combustivel = 50;
  int km = 400;
  int medioKmL = km / combustivel;
  Console.WriteLine($"Combustivel: {combustivel}, Km: {km}, Km/L: {medioKmL}");
}