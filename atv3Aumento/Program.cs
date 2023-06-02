using System;
class Program
{
	static void Main(string[] args)
	{
        // lalalalalla
        while (true)
        {
            Console.Clear();
            Console.Write("Dígite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Dígite seu salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dígite sua data de admissão: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());


            Empregado a = new Empregado(nome, salario, data);

            Console.WriteLine("\nIrá receber aumento? \n1 - sim \n2 - não");

            int sim = Convert.ToInt32(Console.ReadLine());


            switch (sim)
            {

                case 1:
                    Console.Write("Dígite o valor do aumento: ");
                    double aumento = Convert.ToDouble(Console.ReadLine());
                    a.Aumento(aumento);
                    Console.WriteLine($"\n{nome}, você começou na data {data}, seu salario é de {salario.ToString("c2")} e com aumento fica {a.GetSalario().ToString("c2")}");
                    break;
                case 2:
                    Console.WriteLine($"\n{nome}, você começou na data {data}, seu salario é de {salario.ToString("c2")}");
                    break;

            }

            Console.WriteLine("\nSoma total:" + Empregado.somas.ToString("c2")+"\n");
            Console.WriteLine("Adicionar outro funcionario na folha de pagamento?");
            Console.WriteLine("1 - sim\n2 - não");

            int digi= Convert.ToInt32(Console.ReadLine());

            if (digi == 2)
            {
                break;
            }
        }
        
    }
}