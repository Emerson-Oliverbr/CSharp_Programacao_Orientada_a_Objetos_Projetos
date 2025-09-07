using System.Globalization;

namespace BoletimEscolar;

internal class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno: ");
        aluno.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        aluno.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        aluno.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        if (aluno.NotaFinal() > 60.0)
        {
            Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine($"Nota Final: {aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("REPROVADO");
            Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture)} Pontos");
        }
    }
}