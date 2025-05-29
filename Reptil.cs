public class Reptil : Animal
{
    public Reptil(string Nome, int Idade, double Peso, string Especie) : base(Nome, Idade, Peso, Especie) { }

    public void Rastejar()
    {
        Console.WriteLine($"{Nome} está rastejando...");
    }
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está fazendo um som sssSSSssSSss");
    }
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está se movimentnado em S ");
    }
}