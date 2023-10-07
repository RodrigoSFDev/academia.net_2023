// See https://aka.ms/new-console-template for more information
// { Exercicio 1
//   Console.Write("Digite um número inteiro positivo:");
//   bool isBool = int.TryParse(Console.ReadLine(), out int numero); 
//   if(numero > 0 && isBool)
//   {
//         Console.Write($"Números inteiros pares entre 1 e {numero}: ");
//     for(int i = 1; i < numero; i++)
//     {
//       if(i % 2 == 0)
//       {
//         Console.Write(i);
//         if (i + 2 <= numero)
//             {
//                 Console.Write(", ");
//             }
//       }
//     }
//   }
//   else
//   {
//     Console.WriteLine("Valor incorreto!");
//   }
// }

// { Exercicio 2
//   string yesOrNo;
//   do{

//   Console.Write("Digite um número inteiro positivo:");
//   bool isBool = int.TryParse(Console.ReadLine(), out int numero); 
//   if(numero > 0 && isBool)
//   {
//         Console.Write($"Números inteiros pares entre 1 e {numero}: ");
//     for(int i = 1; i < numero; i++)
//     {
//       if(i % 2 == 0)
//       {
//         Console.Write(i);
//         if (i + 2 <= numero)
//             {
//                 Console.Write(", ");
//             }
//       }
//     }
//   }
//   else
//   {
//     Console.WriteLine("Valor incorreto!");
//   }
//     Console.Write("Deseja informar outro número (s/n)?");
//     yesOrNo = Console.ReadLine().ToLower();
// } while(yesOrNo == "s");
// }

// { Exercicio 3
//   int numero;
//   do
//   {
//     Console.Write("Digite um número inteiro:");
//     int.TryParse(Console.ReadLine(), out numero);

//     Console.Write($"Números inteiros pares entre 1 e {numero}: ");
//     for(int i = 1; i < numero; i++)
//     {
//       if(i % 2 == 0)
//       {
//         Console.Write(i);
//         if (i + 2 <= numero)
//             {
//                 Console.Write(", ");
//             }
//       }
//     }  

//   } while (numero != 0);
// }

// { exercicio 4
//   string voto;
//   int joao = 0;
//   int zeca = 0;
//   int branco = 0;
//   do
//   {
//   Console.WriteLine("DIgite sua opcão de Voto (JOÃO, ZECA ou em BRANCO:)");
//   voto = Console.ReadLine()!.ToUpper();

//   switch (voto)
//   {
//     case "JOÃO":
//     joao += 1;
//     break;

//     case "ZECA":
//     zeca += 1;
//     break;

//     case "BRANCO":
//     branco += 1;
//     break;
    
//     default:
//     Console.WriteLine("Opção inválida!");
//     break;
//   }

//   } while (voto != "FIM");

//   Console.WriteLine($"O candidato JOÃO teve {joao} de vatos");
//   Console.WriteLine($"O candidato ZECA teve {zeca} de vatos");
//   Console.WriteLine($"Votos em BRANCO: {branco}");
// }

// { Exercicio 5
//   string? voto;
//   int joao = 0;
//   int zeca = 0;
//   int branco = 0;
//   int nulos = 0;
//   int votosTotais = 0;
//   do
//   {
//   Console.WriteLine("Digite sua opcão de Voto (JOÃO, ZECA ou em BRANCO:)");
//   voto = Console.ReadLine()!.ToUpper();

//   switch (voto)
//   {
//     case "JOÃO":
//     joao += 1;
//     break;

//     case "ZECA":
//     zeca += 1;
//     break;

//     case "BRANCO":
//     branco += 1;
//     break;
    
//     default:
//     nulos += 1;
//     break;
//   }

//   } while (voto != "FIM");
//   if(joao > zeca)
//   {
//   Console.WriteLine($"O candidato JOÃO venceu as eleições com um total de {joao} de votos");
//   }
//   else
//   {
//     Console.WriteLine($"O candidato ZECA venceu as eleições com um total de {zeca} de votos");
//   }
//   votosTotais = zeca + joao + branco + nulos;
//   Console.WriteLine($"Foram um total de {votosTotais} pessoas que votaram nessa eleição");
// }

// { Exercicio 6
//   int idade = 0;
//   do
//   {
//     Console.WriteLine("Digite sua idade:");
//     int.TryParse(Console.ReadLine(), out idade);
//   } while (idade <= 0);
//   Console.WriteLine($"Sua idade é: {idade}");
// }

{
  Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;
if (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _))
{
    Console.WriteLine("Nome incorreto!");
    

    return;
}

Console.Write("Digite sua idade: ");
bool idadeValida = int.TryParse(Console.ReadLine(), out int idade);
if (!idadeValida || idade <= 0)
{
    Console.WriteLine("Idade incorreta!");
    return;
}

Console.Write("Digite seu salário: ");
bool salarioValido = double.TryParse(Console.ReadLine(), out double salario);
if (!salarioValido || salario <= 0)
{
    Console.WriteLine("Salário incorreto!");
    return;
}

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Salário: {salario:F2}");
}