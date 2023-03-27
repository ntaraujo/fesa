public class Pessoa
{
    private string Nome { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
    
    public void Falar()
    {
        System.Console.WriteLine("Olá, meu nome é" + Nome);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("João");
        pessoa1.Falar();
    }
}