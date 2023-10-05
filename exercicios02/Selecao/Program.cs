// See https://aka.ms/new-console-template for more information
// { Exercicio 1
//   Console.WriteLine("Digite o valor da Base:");
//   int baseT = int.Parse(Console.ReadLine()!);
//   Console.WriteLine("Digite o valor da Altura:");
//   int alturaT = int.Parse(Console.ReadLine()!);
//   int areaT = (baseT * alturaT)/2;
//   Console.WriteLine($"A área do triangulo é: {areaT}");
// }

// { Exercicio 2
//   Console.WriteLine("Digite um número para saber se ele é par ou ímpar");
//   int numero = int.Parse(Console.ReadLine()!);

//   if(numero % 2 == 0)
//   {
//     Console.WriteLine($"O número {numero} é PAR!!");
//   } else
//   {
//     Console.WriteLine($"O número {numero} é ÍMPAR!!");
//   }
// }

// { Exercicio 3
//   Console.WriteLine("Digite o Primeiro valor");
//   int numero1 = int.Parse(Console.ReadLine()!);
//   Console.WriteLine("Digite o Segundo valor");
//   int numero2 = int.Parse(Console.ReadLine()!);
//   Console.WriteLine("Digite o Terceiro valor");
//   int numero3 = int.Parse(Console.ReadLine()!);
//   Console.WriteLine("Digite o Quarto valor");
//   int numero4 = int.Parse(Console.ReadLine()!);

//   int media = (numero1 + numero2 + numero3 + numero4)/4;
//   List<int> numerosMaiores = new List<int>();
//   if(numero1 > media)
//   {
//     numerosMaiores.Add(numero1);
//   }
//   if(numero2 > media)
//   {
//     numerosMaiores.Add(numero2);
//   }
//   if(numero3 > media)
//   {
//     numerosMaiores.Add(numero3);
//   }
//   if(numero4 > media)
//   {
//     numerosMaiores.Add(numero4);
//   }
//   Console.WriteLine($"Os números superior a média {media} => {string.Join(", ", numerosMaiores)}");

// }

  // { Exercicio 4
  //   Console.WriteLine("Digite quantas horas o Professor1 trabalhou:");
  //   int prof1 = int.Parse(Console.ReadLine()!);
  //   Console.WriteLine("Digite quantas horas o Professor2 trabalhou:");
  //   int prof2 = int.Parse(Console.ReadLine()!);
  //   Console.WriteLine("Digite o valor de 1h trabalhada");
  //   double valorHora = double.Parse(Console.ReadLine()!);
  //   if(prof1 * valorHora > prof2 * valorHora)
  //   {
  //     Console.WriteLine("Professor1 tem o maior salário total");
  //   } else
  //   {
  //     Console.WriteLine("Professor2 tem o maior salário total");
  //   }
  // }

  // { Exercicio 5
  //   Console.WriteLine("Digite a primeira nota");
  //   double nota1 = double.Parse(Console.ReadLine()!);
  //   Console.WriteLine("Digite a segunda nota");
  //   double nota2 = double.Parse(Console.ReadLine()!);
  //   double media = (nota1 + nota2)/2;

  //   if(media >= 7)
  //   {
  //     Console.WriteLine("Aprovado");
  //   } 
  //   if(media < 7)
  //   {
  //     Console.WriteLine("Por favor, digitar a nota final de exame:");
  //     double exameFinal = double.Parse(Console.ReadLine()!);
  //     double mediaFinal = (exameFinal + media)/2;
  //     if(mediaFinal >= 5)
  //     {
  //       Console.WriteLine("Aprovado");
  //     } else
  //     {
  //       Console.WriteLine("Reprovado");
  //     }
      
  //   }
  // }

  // { Exercicio 6
  //   Console.WriteLine("Digite seu nome");
  //   string nome = Console.ReadLine()!;
  //   Console.WriteLine("Digite sua altura(M)");
  //   double altura = double.Parse(Console.ReadLine()!);
  //   Console.WriteLine("Digite seu peso(kg)");
  //   double peso = double.Parse(Console.ReadLine()!);
  //   double imc = peso / (altura * altura);
  //   if(imc < 18)
  //   {
  //     Console.WriteLine($"Olá, {nome.ToUpper()}, seu IMC é {imc:F2} ele é menor que 18-> baixo peso");
  //   }

  //   if(imc > 18 && imc < 25)
  //   {
  //     Console.WriteLine($"Olá, {nome.ToUpper()}, seu IMC é {imc:F2} ele é maior que 18 e menor que 25 -> peso normal");
  //   }

  //   if(imc > 25 && imc < 30)
  //   {
  //     Console.WriteLine($"Olá, {nome.ToUpper()}, seu IMC é {imc:F2} ele é maior que 25 e menor que 30 -> sobrepeso");
  //   }

  //   if(imc > 30 && imc < 35)
  //   {
  //     Console.WriteLine($"Olá, {nome.ToUpper()}, seu IMC é {imc:F2} ele é maior que 30 e menor que 35 -> obesidade");
  //   }

  //   if(imc > 35)
  //   {
  //     Console.WriteLine($"Olá, {nome.ToUpper()}, seu IMC é {imc:F2} ele é maior que 35 -> obesidade grau sério");
  //   }
  // }

  // { Exercicio 7
  //   Console.WriteLine("Escreva uma frase:");
  //   string frase = Console.ReadLine()!;
  //   Console.WriteLine("Escreva uma palava para verificar se tem dentro da frase:");
  //   string palavra = Console.ReadLine()!;
  //   if(frase.Contains(frase))
  //   {
  //     Console.WriteLine($"A palavra: {palavra}, encontra-se na frase");
  //   } else
  //   {
  //   Console.WriteLine($"A palavra: {palavra}, não encontra-se na frase");
  //   }
  // }

  {
    for (int i = 0; i < 20; i++) 
    { 
      int res = i * 2; 
      Console.WriteLine(res.ToString()); 
    }

  }