using EstudoClass;

// Console.WriteLine("Digite seu nome completo:");
// string nome = Console.ReadLine()!;

// Console.WriteLine("Digite sua data de nascimento nesse formato DD/MM/AAAA:");
// string data = Console.ReadLine()!;

// Console.WriteLine("Digite seu CPF:");
// int cpf = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Digite seu RG:");
// int rg = Convert.ToInt32(Console.ReadLine());

// Pessoa pessoa = new()
// {
//   nome = nome,
//   data = data,
//   cpf = cpf,
//   rg = rg
// };

// Console.WriteLine("Esses são seus dados:");
// Console.WriteLine($"Nome: {pessoa.nome}");
// Console.WriteLine($"Data de nascimento: {pessoa.data}");
// Console.WriteLine($"CPF: {pessoa.cpf}");
// Console.WriteLine($"RG: {pessoa.rg}");


// Console.WriteLine("Digite o nome completo do aluno:");
// string nome = Console.ReadLine()!;

// Console.WriteLine("Digite a sala do aluno:");
// string sala = Console.ReadLine()!;

// Console.WriteLine("Digite a número da matricula do aluno:");
// int matricula = Convert.ToInt32(Console.ReadLine());

// Aluno aluno = new()
// {
//   nome = nome,
//   sala = sala,
//   matricula= matricula
// };

// Console.WriteLine("Esses são os dados do aluno:");
// Console.WriteLine($"Nome: {aluno.nome}");
// Console.WriteLine($"Sala: {aluno.sala}");
// Console.WriteLine($"Número da matricula: {aluno.matricula}");



    // Personagem meuPersonagem = new Personagem();

    // Console.Write("Digite o nome do personagem: ");
    // meuPersonagem.Nome = Console.ReadLine();

    // Console.Write("Digite a posição inicial do personagem: ");
    // meuPersonagem.Posicao = int.Parse(Console.ReadLine());

    // Console.Write("Digite o item coletado: ");
    // meuPersonagem.ItensColetados.Add(Console.ReadLine());

    // Console.Write("Digite o dano do ataque (0 a 10): ");
    // double dano = double.Parse(Console.ReadLine());
    // meuPersonagem.Atacar(dano);

    // Console.Write("Digite a direção do movimento (1 - frente, 2 - trás, 3 - direita, 4 - esquerda): ");
    // int direcao = int.Parse(Console.ReadLine());
    // meuPersonagem.Movimentar(direcao);

    Console.Write("Digite o título do primeiro livro: ");
    string titulo1 = Console.ReadLine();

    Console.Write("Digite o autor do primeiro livro: ");
    string autor1 = Console.ReadLine();

    Console.Write("Digite o ano de publicação do primeiro livro: ");
    int anoPublicacao1 = int.Parse(Console.ReadLine());

    Livro livro1 = new Livro(titulo1, autor1, anoPublicacao1);

    Console.Write("Digite o título do segundo livro: ");
    string titulo2 = Console.ReadLine();

    Console.Write("Digite o autor do segundo livro: ");
    string autor2 = Console.ReadLine();

    Console.Write("Digite o ano de publicação do segundo livro: ");
    int anoPublicacao2 = int.Parse(Console.ReadLine());

    Livro livro2 = new Livro(titulo2, autor2, anoPublicacao2);