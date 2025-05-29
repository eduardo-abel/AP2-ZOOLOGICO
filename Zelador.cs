public class Zelador : Funcionario, ICuidador
{
    public Zelador(string Nome, int Idade) : base(Nome, Idade, "Zelador") { }

    public override void Trabalhar()
    {
        Console.WriteLine($"O zelador chamado {Nome} está trabalhando agora. ");
    }
    public void CuidarLimpar(Animal animal)
    {
        Console.WriteLine($"O zelador chamado {Nome} Limpou e cuidou do habitat de {animal.Nome}");
    }
    public void Alimentar(Animal animal)
    {
        Console.WriteLine($"o zelador {Nome} alimentou o animal {animal.Nome}");
    }
}