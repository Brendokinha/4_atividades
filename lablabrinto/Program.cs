Console.WriteLine("Perfil (professor ou aluno) ");
string perfil = Console.ReadLine();

Console.WriteLine("esta no horario de aua?: (true/false): ");
bool estanohorario = bool.Parse(Console.ReadLine());

if (perfil == "professor" || (perfil == "aluno" && estanohorario == true))
{
    Console.WriteLine("\n aprovado");
}

else
{
    Console.WriteLine("\n nigga");
}