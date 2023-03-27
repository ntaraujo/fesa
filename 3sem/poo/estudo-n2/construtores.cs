public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("João", 15);
        System.Console.WriteLine(pessoa.Nome);
    }
}