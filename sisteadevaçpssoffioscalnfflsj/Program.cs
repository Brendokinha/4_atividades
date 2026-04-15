
Console.Write("digite sua idade nesse cu ai: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Categoria: múmia jurassica");
}
else if (idade >= 13)
{
    Console.WriteLine("Categoria: feto");
}
else if (idade >= 5)
{
    Console.WriteLine("categoria: espermatozoide");
}
else
{
    Console.WriteLine("volta pra casa. Pode competir aquiu nao");
}