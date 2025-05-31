public abstract class Animal //nessa linha estamos criando uma classe pulbica animal
{
    public string? Nome { get; set; }
    public  int Idade { get; set; }
    public double Peso { get; set; }
    public string? Especie { get; set; }

    public Animal(string Nome, int Idade, double Peso, string Especie)
    {
        Nome = Nome;
        Idade = Idade;
        Peso = Peso;
        Especie = Especie;
    }

    public abstract void EmitirSom();
    public abstract void Movimentar();

}