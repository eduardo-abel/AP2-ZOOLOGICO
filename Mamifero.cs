public class Mamifero : Animal
{
    public Mamifero(string Nome, int Idade, double Peso, string Especie) : base(Nome, Idade, Peso, Especie) { }

    public void Amamentar()
    {
        Console.WriteLine($"{Nome} está amamentando.");
    }
    public override void EmitirSom()
    {
        Console.WriteLine($" {Nome} Está fazendo um som... ");
    }
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome}, está se movimentando :)");
    }
}