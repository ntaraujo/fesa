public class Pessoa
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        // set { nome = value; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome não pode ser nulo ou vazio.");
            }
            nome = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "João";
        System.Console.WriteLine(pessoa.Nome);
    }
}