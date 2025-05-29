public class Veterinario : Funcionario, ItratamentoAnimal {
    public Veterinario(string nome, int idade) : base(nome, idade, "Veterinário") { }

    public override void Trabalhar() {
        Console.WriteLine($"Veterinário {Nome} está trabalhando agora.");
    }

    public void RealizarTratamento(Animal animal) {
        Console.WriteLine($"Veterinário {Nome} tratou o animal {animal.Nome}.");
    }

    public void ConsultarAnimal(Animal animal) {
        Console.WriteLine($"Veterinário {Nome} consultou o animal {animal.Nome}.");
    }
}