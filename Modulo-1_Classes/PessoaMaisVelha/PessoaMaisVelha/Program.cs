namespace pessoaMaisVelha;

internal class Program
{
    static void Main(String[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        Pessoa pessoa2 = new Pessoa();
        
        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: ");
        pessoa1.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        pessoa1.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Dados da segunda pessoa: ");
        Console.Write("Nome: ");
        pessoa2.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        pessoa2.Idade = int.Parse(Console.ReadLine());

        if (pessoa1.Idade > pessoa2.Idade)
        {
            Console.WriteLine("Pessoa mais velha! " + pessoa1.Nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha! " + pessoa2.Nome);
        }
    }
}