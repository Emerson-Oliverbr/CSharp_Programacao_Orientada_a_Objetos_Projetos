using System.Globalization;

namespace Estoque;
internal class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("Desktop", 1000.00, 10);

        produto.Nome = "TV-4K";

        Console.WriteLine(produto.Nome);
        Console.WriteLine(produto.Preco);

        /*
        Console.WriteLine("Entre com os dados do Produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preco unitário: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);       

        Produto produto = new Produto(nome, preco);

        Console.WriteLine($"Dados do produto: {produto}");
        Console.Write("Digite o número de produtos a ser adicionados do estoque: ");
        int qtde = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qtde);
        Console.WriteLine($"Dados do Atualizados: {produto}");
        Console.Write("Digite o número de produtos a serem removido do estoque: ");
        qtde = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(qtde);
        Console.WriteLine($"Dados do Atualizados: {produto}");
        */
    }
}