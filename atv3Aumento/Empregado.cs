

/*3. Crie uma classe Empregado que possui os seguintes atributos: nome, salário, data de
admissão. Todos os atributos devem ser privados e possuírem os métodos sets e gets.
a) Construa o método construtor para obrigar a inserir todos os atributos do objeto.
b) Construa um método que realize o aumento de salário do funcionário, esse método deve
receber por parâmetro a porcentagem do aumento.
c) Construa um atributo estático na classe Empregado que deve armazenar o valor das
somas dos salários dos funcionários. Caso algum funcionário receber aumento, o valor
desse atributo deve ser atualizado (esse atributo é necessário para verificar quantos de
funcionário a empresa está pagando por mês).*/
using System.Security.Cryptography.X509Certificates;

public class Empregado
{
    private string nome = "";
    private double salario;
    private DateTime data;
    public static double somas = 0;

    public Empregado(string nome, double salario, DateTime data)
    {
        this.nome = nome;
        this.salario = salario;
        this.data = data;
        somas += salario;
    }



   public void Aumento(double x) 
   {
        double re = (x / 100)*salario;
        salario += re;
        somas += re; 
    }

    public string GetNome()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }


        public double GetSalario()
        {  
        return this.salario;
        }

    public void SetSalario(double salario)
    {
        this.salario = salario;
    }

    public DateTime GetData()
    {
       return this.data;  
    }
    public void SetData(DateTime data)
    {
        this.data = data;
    }
}

