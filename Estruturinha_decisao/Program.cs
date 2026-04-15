//1. entrada de dados
Console.Write("digite a primeirinha notinha:");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segundinha notinha: ");
double nota2 = double.Parse(Console.ReadLine());

//calculo da média bb
double media = (nota1 + nota2);

// Estruta de decisão 
if (media >= 7)
{
    Console.WriteLine("aprovadissimo amore!! Média: " + media);
}

else
{
    Console.WriteLine("Rprovadão FOGO FOGO FOGO FOGO FOGO!! média: " + media);
}