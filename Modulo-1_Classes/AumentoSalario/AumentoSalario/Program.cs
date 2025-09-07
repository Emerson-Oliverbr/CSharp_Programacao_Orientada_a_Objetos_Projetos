using System.Globalization;

namespace AumentoSalario;

internal class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("Salario bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine($"Funcionario: {funcionario}");
        Console.Write("Digite uma porcentagem para aumentar o salario: ");
        double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.AumentarSalario(aumento);
        Console.WriteLine($"Dados atualizados: {funcionario}");
    }
}