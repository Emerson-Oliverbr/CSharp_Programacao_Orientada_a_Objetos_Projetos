using System.Globalization;

namespace Estoque;
public class Produto
{
    private string? _nome;
    public double Preco { get; private set; }
    public int Quantidade { get; private set; }

    public Produto(){       
    }

    public Produto(string nome, double preco) : this()
    {
        _nome = nome;
        Preco = preco;
    }
    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;      
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 2)
            {
                _nome = value;
            }
        }
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
        return $"{_nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}