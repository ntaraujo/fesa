public static class Utilitario
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int c = Utilitario.Somar(1, 2);
    }
}