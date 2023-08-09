using Exercicio_Nivelamento;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Produto produto = new Produto(nome, preco, quantidade);

        produto.MostrarDadosDoProduto();

        Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
        int quantidadeAdicionar = int.Parse(Console.ReadLine()!);
        produto.AdicionarProdutos(quantidadeAdicionar);

        produto.MostrarDadosDoProduto();

        Console.Write("Digite a quantidade a ser removida do estoque: ");
        int quantidadeRemover = int.Parse(Console.ReadLine()!);
        produto.RemoverProdutos(quantidadeRemover);

        produto.MostrarDadosDoProduto();
    }
}