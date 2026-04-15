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

switch (categoria)
{
    case 1:
    valorfinal = valor * 0.90; //10% porcento de desconto
    break;

    case 2:
    valorfinal = valor * 0.85; //15% porcento de desconto
    break;

    case 3:
    valorfinal = valor * 0.80; //20% porcento de desconto
    break;

    default:
    valorfinal = valor;
    Console.WriteLine("AVISO!! categoria sem desconto: ");
    break;
}
Console.WriteLine($"Valor Original: R$ {valor}");
Console.WriteLine($"Valor com descontos: R$ {valorfinal}");
