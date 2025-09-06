using System.Globalization;

namespace SalarioMedio;

internal class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        Funcionario funcionario2 = new Funcionario();
        
        Console.WriteLine("Dados do primeiro funcionário: ");
        Console.Write("Nome: ");
        funcionario1.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        funcionario1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Dados do segundo funcionário: ");
        Console.Write("Nome: ");
        funcionario2.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        funcionario2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;
        
        Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
    }
}

