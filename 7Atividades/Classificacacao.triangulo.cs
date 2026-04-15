int vlr1;
int vlr2;
int vlr3;
string classificacao;

Console.WriteLine("---- Bem vindo! ----");
Console.WriteLine("\n--Vamos botar três valores--");

Console.WriteLine("Bote o primeiro valor: ");
vlr1 = int.Parse(Console.ReadLine());

Console.WriteLine("Bote o segundo valor: ");
vlr2 = int.Parse(Console.ReadLine());

Console.WriteLine("Bote o terceiro valor: ");
vlr3 = int.Parse(Console.ReadLine());
//

if (vlr1 == vlr2 && vlr2 == vlr3)
{
    Console.WriteLine("triangulo classificado como: Equilatero");
}
else if (vlr1 == vlr2 ||vlr1 == vlr3|| vlr2 == vlr3 )
{
Console.WriteLine("triangulo classificado como: isoceles");
}

else
{
    Console.WriteLine("triangulo classificado como: Escaleno");
}
