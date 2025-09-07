using System.Globalization;

namespace Estoque;

internal class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();
        
        Console.WriteLine("Entre com os dados do Produto: ");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preco unitário: ");
        produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine($"Dados do produto: {produto}");
        Console.Write("Digite o número de produtos a ser adicionados do estoque: ");
        int qtde = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qtde);
        Console.WriteLine($"Dados do Atualizados: {produto}");
        Console.Write("Digite o número de produtos a serem removido do estoque: ");
        qtde = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(qtde);
        Console.WriteLine($"Dados do Atualizados: {produto}");
    }
}
