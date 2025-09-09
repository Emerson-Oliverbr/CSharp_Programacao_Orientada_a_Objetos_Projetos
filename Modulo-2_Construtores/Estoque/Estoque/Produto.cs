using System.Globalization;

namespace Estoque;
public class Produto
{
    public string? Nome;
    public double Preco;
    public int Quantidade;

    public Produto()
    {
        Quantidade = 10;
    }

    public Produto(string nome, double preco) : this()
    {
        Nome = nome;
        Preco = preco;
    }
    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;      
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return $"{Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}