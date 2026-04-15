Console.WriteLine("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite sua renda mensal: ");
double renda = double.Parse(Console.ReadLine());

if(idade >= 18 & renda >= 2000) 
{
    Console.WriteLine("aprovado!");
}
else if (idade <=  18& renda <= 2000)
{
    Console.WriteLine("sai daqui");
}
else
{
    Console.WriteLine("o porra");
}