using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        
        Produto prod1 = new Produto();
        Console.WriteLine("PRODUTO 1 - CADASTRO");
        Console.WriteLine("Digite o nome do produto: ");
        prod1.nome = Console.ReadLine();
        Console.WriteLine("Digite o preço do produto: ");
        prod1.preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a quantidade disponível do produto: ");
        prod1.qntd = Convert.ToInt32(Console.ReadLine());
        prod1.MostrarAtributos();
        Console.WriteLine("Valor total do estoque: R$ " + prod1.ValorTotalEstoque());
        int qntdAdicionada;
        int qntdRemovida;
        Console.WriteLine("Digite a quantidade que deseja adicionar: ");
        qntdAdicionada = Convert.ToInt32(Console.ReadLine());
        prod1.AdicionarProduto(qntdAdicionada);
        prod1.MostrarAtributos();
        Console.WriteLine("Digite a quantidade que deseja remover: ");
        qntdRemovida = Convert.ToInt32(Console.ReadLine());
        prod1.RemoverProduto(qntdRemovida);
        prod1.MostrarAtributos();
    }
}