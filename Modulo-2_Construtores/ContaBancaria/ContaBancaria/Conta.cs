namespace ContaBancaria;

public class Conta
{
    public int Numero { get; private set; }
    public string Nome { get; set; }
    public double Saldo { get; private set; }

    public Conta(int numero, string nome) 
    {
        Numero = numero;
        Nome = nome;
    }

    public Conta(int numero, string nome, double saldo) : this(numero, nome)
    {
        Saldo = saldo;
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }

    public void Saque(double quantia)
    {
        Saldo -= quantia + 5.0;
    }

    public override string ToString()
    {
        return $"Conta: {Numero}, Titular: {Nome}, Saldo: R$ {Saldo:F2} ";
    }

}