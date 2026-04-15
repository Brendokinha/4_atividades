
int categoria;
double valor, valorfinal;

Console.WriteLine("Informe o valor do produto: R$");
valor = double.Parse(Console.ReadLine());
Console.WriteLine("\nMENU DE CATEGORIAS:");
Console.WriteLine("1- Alimentos:");
Console.WriteLine("2- Limpeza:");
Console.WriteLine("3- Eletrônico:");
Console.WriteLine("Escolha a categorian(1-3): ");
categoria = int.Parse(Console.ReadLine());

if (categoria == 1)
{
    valorfinal = valor * 0.90; //10% de desconto
}
else if (categoria == 2)
{
    valorfinal = valor * 0.95; //5% DE DESCONTO
}
else if (categoria == 3)
{
    valorfinal = valor * 0.80; //20% desconto
}
else
{
    valorfinal = valor;
    Console.WriteLine("AVISO!! Categoria sem desconto.");
}
Console.WriteLine($"Valor Original: R$ {valor}");
Console.WriteLine($"Valor com descontos: R$ {valorfinal}");
