public class Calculadora
{
    public int Soma(int a, int b)
    {
        return a + b;
    }

    public double Soma(double a, double b)
    {
        return a + b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        a = calc.Soma(1, 2);
        b = calc.Soma(1.0, 2.0);
    }
}