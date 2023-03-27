public class ContaBancaria
{
    public string Titular {get; set; }
    public string Saldo {get; set; }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            System.Console.WriteLine("Saldo insuficiente.");
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Titular = "Maria";
        conta1.Depositar(1000);
        conta1.Sacar(500);
        System.Console.WriteLine(conta1.Saldo);
    }
}