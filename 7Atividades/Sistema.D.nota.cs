int nota;

Console.WriteLine("===Bem vindo ao sistemas de notas do SENAI===");
Console.WriteLine("\n --TABELA DE DESEMPENHO--");
Console.WriteLine("\n Exelente. | Satisfatório. | Ainda não atingido. ");
Console.WriteLine("\n=====================================================");
Console.WriteLine("Digite a sua nota:");
nota = int.Parse(Console.ReadLine());

if (nota >=90 )
{
    Console.WriteLine("Desempenho: Excelente");
}
else if (nota >= 70 && nota <90)
{
    Console.WriteLine("Desempenho: Satisfatório");
}
else
{
    Console.WriteLine("Desempenho: Ainda não atingido");
}