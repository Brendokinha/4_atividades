
Console.WriteLine("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2+ nota3 )/3;
if (media >= 7.0)
{
    Console.WriteLine("Situação: ARRASOOOOOOOO! APROVADO");
}

else if (media >= 5.0)
{
    Console.WriteLine("Situação: Recuperação. a culpa é da escola memo");
}

else
{
    Console.WriteLine("Situação: Repetiu. sla, senta e chora, se eu fosse tu eu batia na professora");
}


