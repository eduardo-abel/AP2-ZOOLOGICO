public class Ave : Animal
{
    public Ave(string Nome, int Idade, double Peso, string Especie) : base(Nome, Idade, Peso, Especie) { }

    public void voar()
    {
        Console.WriteLine($"{Nome} está voando. ");
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está fazendo um som de Ave..");
    }
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está se movimentando pra lá e pra cá.");
    }
}