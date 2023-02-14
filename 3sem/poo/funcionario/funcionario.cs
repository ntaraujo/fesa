using System;

public class Funcionário
{
    private int codigo;
    private string nome;
    private DateTime nascimento;
    private string cpf;


    public void setCodigo(int valor)
    {
        if (valor <= 0)
        {
            throw new Exception("Código não pode ser negativo");
        }
        else
        {
            codigo = valor;
        }
    }

    //Método de uma linha tipo "arrow" 
    //public int getCodigo() => codigo;
    public int getCodigo()
    {
        return codigo;
    }


    public void setNome(string nome)
    {
        if (string.IsNullOrEmpty(nome))
        {
            throw new Exception("Informe o nome");
        }
        else
        {
            this.nome = nome;
        }
    }
    public string getNome() => nome;

    public void setDataNascimento(DateTime data)
    {
        if (data > DateTime.Now)
        {
            throw new Exception("Pessoa nem nasceu ainda...");
        }
        else
        {
            nascimento = data;
        }
    }

    private int CalculaIdade()
    {
        int idade = (int)DateTime.Now.Subtract(nascimento).TotalDays / 365;
        return idade;
    }
}
