int idade;

Console.WriteLine("-----Bem vindo ao sistema!-----");
Console.WriteLine("Por Favor, escreva tua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 18)
{
    Console.WriteLine("---- ACESSO NEGADO ----");
}
else
{
    Console.WriteLine("---- ACESSO PERMITIDO ----");
}