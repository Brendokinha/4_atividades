string exercicio;
int total;
int atual;

Console.Write("Qual o nome do exercício?");
exercicio = Console.ReadLine();

Console.Write("Quantas repetições você vai fazer?");
total = int.Parse(Console.ReadLine());

for (atual = 1;  atual <= total; atual++)
{
    Console.WriteLine($"{exercicio}: Repetição {atual} de {total} ");

}
Console.WriteLine("Série concluída! Descanso iniciado.");
