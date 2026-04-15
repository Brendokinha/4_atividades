string senha;
{
Console.WriteLine("digite sua senha: ");
senha = Console.ReadLine();

while (senha != "Senai123")
{
    Console.WriteLine("negado!");
    Console.WriteLine("Tente novamente: ");
    senha = Console.ReadLine();
}
 Console.WriteLine("aprovado!");
}
