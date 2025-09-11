using System.Globalization;
namespace ContaBancaria;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta = char.Parse(Console.ReadLine());

        Conta conta = null;
        
        if (resposta == 's' || resposta == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta = new Conta(numero, titular, deposito);
        }

        else
        {
            conta = new(numero, titular);
        }
        Console.WriteLine($"Dados da conta: {conta}");

        Console.Write("Entre um valor para depósito: ");
        double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(valorDeposito);
        Console.WriteLine($"Dados da conta atualizados: {conta}");

        Console.Write("Entre um valor para saque: ");
        double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(valorSaque);
        Console.WriteLine($"Dados da conta atualizados: {conta}");
    }
}