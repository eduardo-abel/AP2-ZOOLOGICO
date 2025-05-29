public abstract class Funcionario
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Cargo { get; set; }

    public Funcionario(string Nome, int Idade, string Cargo)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Cargo = Cargo;
    }
    public abstract void Trabalhar();
    
}