double vlr, vlrf, forma;

Console.WriteLine("====BEM VINDO AO CAIXA====");
Console.WriteLine("\n qual foi o valor gasto?");
vlr = double.Parse(Console.ReadLine());

Console.WriteLine("\n==Opções de pagamento==");
Console.WriteLine("1- Á vista| 2- Cartão| 3- Parcelado");
Console.WriteLine("\n Selecione a forma de pagamento (1-3): ");
forma = double.Parse(Console.ReadLine());
//

switch (forma)
{
    case 1:
    vlrf = vlr * 0.90;
    Console.WriteLine($"Valor origial {vlr}, valor com desconto {vlrf}");

    break;

    case 2:
    vlrf = vlr;
    Console.WriteLine($"Valor origial {vlr}, valor com desconto {vlrf}");
    break;

    case 3:
    vlrf = vlr * 0.05;
    Console.WriteLine($"Valor origial {vlr}, valor com desconto {vlrf}");
    break;
}

