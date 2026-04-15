int vidadragao = 100;
int escolha;
int turno;
int danogerado;

Console.WriteLine("=== DESAFIO DO DRAGÃO ===");
Console.WriteLine("Você tem 5 turnos para derrotar a fera!");

//inicio do laço for
for (turno = 1; turno <= 5; turno++)
{
    Console.WriteLine("\n---------------------------------------------------");
    Console.WriteLine($"TURNO {turno} | VIDA DO DRAGÃO: {vidadragao} HP");
    Console.WriteLine("[1] Ataque com espada");
    Console.WriteLine("[2] Lança Magia");
    Console.WriteLine("[3] flertar");


    escolha = int.Parse(Console.ReadLine());

    if(escolha == 1)
    {
        danogerado = 20;
        vidadragao = vidadragao - danogerado;
        Console.WriteLine($"Você golpeou o Dragão {danogerado} de dano");
    }
    else if (escolha == 2)
    {
        danogerado = 35;
        vidadragao = vidadragao - danogerado;
        Console.WriteLine($"magia fodona! causou {danogerado} de dano");
    }
    else
    {
        Console.WriteLine("Você boto o pau pra fora, mas o draagão riu de ti e cortou teu bilau fora");
    }

    //Verificar se o dragão foi de4rrotado
    if (vidadragao <=0)
    {
        Console.WriteLine("o dragão Morreu");
        break;
    }

}
if (vidadragao > 0)
{
    Console.WriteLine("o dragão te mato pq tu é mongol");
}

