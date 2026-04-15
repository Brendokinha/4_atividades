using System.ComponentModel;

double precoDoProduto;
double contaTotal = 0;
int codigoDaCategoria;
int ProdutoAtual;

Console.WriteLine("--- BEM- VINDO A LAMCHOMETE ESCOLA SENAIS BARRA FUNDA ---");
for(ProdutoAtual = 1; ProdutoAtual <=5; ProdutoAtual++)
{
        Console.WriteLine("PASSANDO O PRODUTO NUMERO: "+ProdutoAtual);
        Console.WriteLine("Qual é o preço deste produto? R$ ");
        precoDoProduto = double.Parse(Console.ReadLine());

        Console.WriteLine("Categoria: 1- Limpeza | 2- alimento | 3- eletronico");
        Console.Write("Qual o código da categoria? ");
        codigoDaCategoria = int.Parse(Console.ReadLine());

    switch (codigoDaCategoria)
    {
        case 1:
        case 2:
        contaTotal = contaTotal + precoDoProduto;
        Console.WriteLine("Produto comum somado");
        break;

        case 3:
        contaTotal = contaTotal+ (precoDoProduto * 1.10);
        Console.WriteLine("Eletronico somado com taxa de 10%");
        break;

        default:
        Console.WriteLine("Código errado!");
        break;

    }
}
Console.WriteLine("VALOR TOTAL A PAGAR:" +contaTotal);