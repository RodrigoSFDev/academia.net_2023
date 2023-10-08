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

// { Exercicio 4
//   string data = "29/10/1993";
//   string []newData = data.Split("/");
//   string ano = newData[2];
//   Console.WriteLine($"{newData[2]}/{newData[1]}/{newData[0]}");
//   Console.WriteLine($"{ano.Substring(2)}/{newData[1]}/{newData[0]}");
// }

// { Exercicio 5
//   int combustivel = 50;
//   int km = 400;
//   int medioKmL = km / combustivel;
//   Console.WriteLine($"Combustivel: {combustivel}, Km: {km}, Km/L: {medioKmL}");
// }

// { Exercicio 6
//         Console.WriteLine("Informe os dados para o Parafuso A:");
//         Console.WriteLine("Código do Parafuso A: ");
//         string codigoA = Console.ReadLine()!;
//         Console.WriteLine("Quantidade de peças do Parafuso A: ");
//         int quantidadeA;
//         int.TryParse(Console.ReadLine(), out quantidadeA);
//         Console.WriteLine("Valor unitário do Parafuso A: ");
//         double valorUnitarioA;
//         double.TryParse(Console.ReadLine(), out valorUnitarioA);
//         Console.WriteLine("Porcentagem de IPI para o Parafuso A (%): ");
//         double ipiA;
//         double.TryParse(Console.ReadLine(), out ipiA);

//         Console.WriteLine("Informe os dados para o Parafuso B:");
//         Console.WriteLine("Código do Parafuso B: ");
//         string codigoB = Console.ReadLine()!;
//         Console.WriteLine("Quantidade de peças do Parafuso B: ");
//         int quantidadeB;
//         int.TryParse(Console.ReadLine(), out quantidadeB);
//         Console.WriteLine("Valor unitário do Parafuso B: ");
//         double valorUnitarioB;
//         double.TryParse(Console.ReadLine(), out valorUnitarioB);
//         Console.WriteLine("Porcentagem de IPI para o Parafuso B (%): ");
//         double ipiB;
//         double.TryParse(Console.ReadLine(), out ipiB);


//         Console.WriteLine("\nResultados:");
//         Console.WriteLine($"Parafuso A - Código: {codigoA}");
//         Console.WriteLine($"Quantidade: {quantidadeA}");
//         Console.WriteLine($"Valor Unitário: R$ {valorUnitarioA:F2}");
//         Console.WriteLine($"IPI: {ipiA}%");

//         Console.WriteLine($"\nParafuso B - Código: {codigoB}");
//         Console.WriteLine($"Quantidade: {quantidadeB}");
//         Console.WriteLine($"Valor Unitário: R$ {valorUnitarioB:F2}");
//         Console.WriteLine($"IPI: {ipiB}%");
// }

// { Exercicio 7
//   Console.WriteLine("Digite o número do vendedor:");
//   int numVendedor;
//   int.TryParse(Console.ReadLine(), out numVendedor);
//   Console.WriteLine("Salário fixo do vendedor:");
//   double salarioFixo;
//   double.TryParse(Console.ReadLine(), out salarioFixo);
//   Console.WriteLine("Total de Vendas em R$:");
//   double totalVendas;
//   double.TryParse(Console.ReadLine(), out totalVendas);
//   Console.WriteLine("Percentual que ganha sobre o total de vendas:");
//   double porcentagemVendas;
//   double.TryParse(Console.ReadLine(), out porcentagemVendas);
//   double salarioTotal = salarioFixo + ((totalVendas * porcentagemVendas)/ 100);

//   Console.WriteLine($"Número do vendedor: {numVendedor} \nSalário total: {salarioTotal}");

// }

// { Exercicio 8
//   Console.WriteLine("Digite a temperatura em graus Celsius:");
//   double celsius;
//   double.TryParse(Console.ReadLine(),  out celsius);
//   double fahrenheit = (9 * celsius + 160)/5;
//   Console.WriteLine($"{celsius} em Celsius é igual a {fahrenheit} em Fahrenheit");
// }

// {
//   Console.WriteLine("Digite o valor da compra:");
//   double compra;
//   double.TryParse(Console.ReadLine(), out compra);
//   Console.WriteLine("Digite o valor da entrada");
//   double entrada;
//   double.TryParse(Console.ReadLine(), out entrada);
//   double parcelas = (compra - entrada)/2;

//   if( entrada >= parcelas)
//   {
//     Console.WriteLine($"Ficaram duas parcelas de: {parcelas}");
//   } else {
//     Console.WriteLine("O valor da entrada tem que ser maior");
//   }

//   if(compra == entrada){
//     Console.WriteLine("Pagamento efetuado à vista");
//   }
// }

// { Exercicio 9
//   Console.WriteLine("Digite o valor do produto:");
//   double valueOfProduct;
//   double.TryParse(Console.ReadLine(), out valueOfProduct);
//   double valuePart = Math.Floor(valueOfProduct / 3);
//   double valueInflow = valueOfProduct - (valuePart * 2);
//   Console.WriteLine($"O valor do produto é {valueOfProduct}, a entrada deve ser de {valueInflow} e ficara duas parcelas de {valuePart}");
// }

// { Exercicio 10
//   Console.WriteLine("Digite o valor que deseja sacar:");
//   int value, n200, n100, n50, n20, n10, n5, n2;
//   int.TryParse(Console.ReadLine(), out value);
//   n200 = value / 200;
//   value = value - (n200 * 200);
//   Console.WriteLine($"Notas de 200: {n200}");

//   n100 = value / 100;
//   value = value - (n100 * 100);
//   Console.WriteLine($"Notas de 100: {n100}");

//   n50 = value / 50;
//   value = value - (n50 * 50);
//   Console.WriteLine($"Notas de 50: {n50}");

//   n20 = value / 20;
//   value = value - (n20 * 20);
//   Console.WriteLine($"Notas de 20: {n20}");

//   n10 = value / 10;
//   value = value - (n10 * 10);
//   Console.WriteLine($"Notas de 10: {n10}");

//   n5 = value / 5;
//   value = value - (n5 * 5);
//   Console.WriteLine($"Notas de 5: {n5}");

//   n2 = value / 2;
//   value = value - (n2 * 2);
//   Console.WriteLine($"Notas de 2: {n2}");
// }

// { Exercicio 11
//   int voteValid, voteBlank, voteNull, totalVoters;
//   Console.WriteLine("Digite a quantidade de votos válidos:");
//   int.TryParse(Console.ReadLine(), out voteValid);

//   Console.WriteLine("Digite a quantidade de votos em branco:");
//   int.TryParse(Console.ReadLine(), out voteBlank);

//   Console.WriteLine("Digite a quantidade de votos nulos:");
//   int.TryParse(Console.ReadLine(), out voteNull);
//   double percentBlank, percentNull, percentValid;
//   totalVoters = voteBlank + voteNull + voteValid;

//   percentBlank = (voteBlank * 100) / totalVoters;
//   percentNull = (voteNull * 100) / totalVoters;
//   percentValid = (voteValid * 100) / totalVoters;

//   Console.WriteLine($"Foram um total de {totalVoters} eleitores nessa eleição");
//   Console.WriteLine($"Resultado dos votos em porcentagem foram: {percentBlank}% Brancos, {percentNull}% Nulos e {percentValid}% Válidos");
// }

// { Exercicio 12
//           Console.Write("Digite a marcação do odômetro no início do dia: ");
//         int inicioOdometro;
//         int.TryParse(Console.ReadLine(), out inicioOdometro);

//         Console.Write("Digite a marcação do odômetro no final do dia: ");
//         int finalOdometro;
//         int.TryParse(Console.ReadLine(), out finalOdometro);

//         Console.Write("Digite o número de litros de combustível gastos: ");
//         decimal litrosGastos;
//         decimal.TryParse(Console.ReadLine(), out litrosGastos);

//         Console.Write("Digite o valor total recebido dos passageiros: ");
//         decimal valorRecebido;
//         decimal.TryParse(Console.ReadLine(), out valorRecebido);

//         int totalQuilometragem = finalOdometro - inicioOdometro;

//         decimal mediaConsumo = totalQuilometragem / litrosGastos;

//         decimal lucroDia = valorRecebido - (litrosGastos * 6.9M);

//         Console.WriteLine($"A média do consumo é: {mediaConsumo}Km/l");
//         Console.WriteLine($"O lucro líquido do dia é: R$ {lucroDia}");
// }

{
          Console.Write("Digite o valor do salário mínimo: ");
        decimal salarioMinimo;
        decimal.TryParse(Console.ReadLine(), out salarioMinimo);

        Console.Write("Digite o preço de custo de cada bicicleta: ");
        decimal precoCusto;
        decimal.TryParse(Console.ReadLine(), out precoCusto);

        Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
        int bicicletasVendidas;
        int.TryParse(Console.ReadLine(), out bicicletasVendidas);

        decimal salarioBase = 2 * salarioMinimo;
        decimal comissao = bicicletasVendidas * precoCusto * 0.15M;
        decimal salarioFinal = salarioBase + comissao;

        Console.WriteLine("O salário do vendedor é: R$ " + salarioFinal);
}