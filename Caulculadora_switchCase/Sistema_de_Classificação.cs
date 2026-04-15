int procedencia;
double preco;

Console.WriteLine("Digite o valor do preço do produto:");
preco =  double.Parse(Console.ReadLine());

Console.WriteLine("\n====CÓDIGO DE IDENTIFICACÃO: ====");
Console.WriteLine("1- Sul ");
Console.WriteLine("2- Norte ");
Console.WriteLine("3- Leste ");
Console.WriteLine("4- Oeste ");
Console.WriteLine("5 ou 6- Nordeste ");
Console.WriteLine("7, 8, ou 9- Sudeste ");
Console.WriteLine("10- Centro-Oeste ");
Console.WriteLine("11- Noroeste ");
Console.WriteLine("Digite o código de origem (1 - 11): ");
procedencia = int.Parse(Console.ReadLine());

switch (procedencia)
{
    case 1: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Sul ");
    break;

    case 2: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Norte ");
    break;

    case 3: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Leste ");
    break;

    case 4: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Oeste ");
    break;

    case 5: 
    case 6:
    Console.WriteLine($"Valor: R$ {preco} Origem: Nordeste ");
    break;

    case 7: 
    case 8:
    case 9: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Sudeste ");
    break;

    case 10: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Centro-Oeste ");
    break;

    case 11: 
    Console.WriteLine($"Valor: R$ {preco} Origem: Noroeste ");
    break;


}