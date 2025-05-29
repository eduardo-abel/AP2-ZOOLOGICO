﻿List<Animal> animais = new List<Animal>();
List<Funcionario> funcionarios = new List<Funcionario>();

bool executando = true;

while (executando)
{
    Console.Clear();
    Console.WriteLine("=== Sistema de Gerenciamento do Zoológico ===");
    Console.WriteLine("1. Cadastro de Animais");
    Console.WriteLine("2. Cadastro de Funcionários");
    Console.WriteLine("3. Interação ");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");

    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            CadastrarAnimal(animais);
            break;
        case "2":
            CadastrarFuncionario(funcionarios);
            break;
        case "3":
            InteragirAnimalFuncionario(animais, funcionarios);
            break;
        case "4":
            executando = false;
            Console.WriteLine("Sistema finalizado");
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

    if (executando)
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}

static void CadastrarAnimal(List<Animal> animais)
{
    Console.Clear();
    Console.WriteLine("=== Cadastro de Animal ===");
    Console.WriteLine("Tipos: 1 - Mamífero | 2 - Ave | 3 - Réptil");
    Console.Write("Digite o tipo de animal: ");

    string? tipo = Console.ReadLine();

    Console.Write("Nome: ");
    string? nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Peso: ");
    double peso = double.Parse(Console.ReadLine());

    Console.Write("Espécie: ");
    string? especie = Console.ReadLine();
    Animal? animal = null;

    switch (tipo)
    {
        case "1":
            animal = new Mamifero(nome, idade, peso, especie);
            break;
        case "2":
            animal = new Ave(nome, idade, peso, especie);
            break;
        case "3":
            animal = new Reptil(nome, idade, peso, especie);
            break;
        default:
            Console.WriteLine("Tipo inválido.");
            return;
    }

    animais.Add(animal);
    Console.WriteLine($"Animal registrado com sucesso: Nome: {animal.Nome}, Idade: {animal.Idade}, Peso: {animal.Peso}kg, Espécie: {animal.Especie}.");
}

static void CadastrarFuncionario(List<Funcionario> funcionarios)
{
    Console.Clear();
    Console.WriteLine("=== Cadastro de Funcionário ===");
    Console.WriteLine("Cargos: 1 - Veterinário | 2 - Zelador");
    Console.Write("Digite o cargo do funcionário: ");
    string? cargo = Console.ReadLine();

    Console.Write("Nome: ");
    string? nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Funcionario? funcionario = null;

    switch (cargo)
    {
        case "1":
            funcionario = new Veterinario(nome, idade);
            break;
        case "2":
            funcionario = new Zelador(nome, idade);
            break;
        default:
            Console.WriteLine("Cargo inválido. aperte Enter para voltar ao menu.");
            return;
    }

    funcionarios.Add(funcionario);
    Console.WriteLine($"Funcionário registrado com sucesso: Nome: {funcionario.Nome}, Idade: {funcionario.Idade}, Cargo: {funcionario.Cargo}.");
}

static void InteragirAnimalFuncionario(List<Animal> animais, List<Funcionario> funcionarios)
{
    Console.Clear();

    if (animais.Count == 0 || funcionarios.Count == 0)
    {
        Console.WriteLine("É preciso ter pelo menos um animal e um funcionário cadastrados.");
        return;
    }

    Console.WriteLine("Animais disponíveis:");
    foreach (var animal in animais)
        Console.WriteLine($" • {animal.Nome}");

    Console.Write("Digite o nome do animal: ");
    string nomeAnimal = Console.ReadLine();
    var animalSelecionado = animais.FirstOrDefault(a => a.Nome.Equals(nomeAnimal, StringComparison.OrdinalIgnoreCase));

    if (animalSelecionado == null)
    {
        Console.WriteLine("Animal não encontrado.");
        return;
    }

    Console.WriteLine("Funcionários disponíveis:");
    foreach (var funcionario in funcionarios)
        Console.WriteLine($"• {funcionario.Nome} ({funcionario.Cargo})");

    Console.Write("Digite o nome do funcionário: ");
    string nomeFuncionario = Console.ReadLine();
    var funcionarioSelecionado = funcionarios.FirstOrDefault(f => f.Nome.Equals(nomeFuncionario, StringComparison.OrdinalIgnoreCase));

    if (funcionarioSelecionado == null)
    {
        Console.WriteLine("Funcionário não encontrado.");
        return;
    }

    Console.Clear();
    Console.WriteLine("--- Interação ---");
    Console.WriteLine($"{funcionarioSelecionado.Nome} está interagindo com {animalSelecionado.Nome}");

    animalSelecionado.EmitirSom();
    animalSelecionado.Movimentar();
    funcionarioSelecionado.Trabalhar();

    if (funcionarioSelecionado is ICuidador zelador)
    {
        zelador.CuidarLimpar(animalSelecionado);
        zelador.Alimentar(animalSelecionado);
    }

    if (funcionarioSelecionado is ItratamentoAnimal veterinario)
    {
        veterinario.ConsultarAnimal(animalSelecionado);
        veterinario.RealizarTratamento(animalSelecionado);
    }
   
}