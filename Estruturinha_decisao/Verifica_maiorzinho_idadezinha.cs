// 1.entrada de dados
Console.Write("digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

//2. Decisão. Se a idade é 18 ou mais
if (idade >= 18)
{
    Console.WriteLine("Você é de maior carai: " + idade);
}

else
{
    Console.WriteLine("tu é de menor, SAI DAQUI: " + idade);
}
