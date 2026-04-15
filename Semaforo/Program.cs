using System.Data.Common;

Console.WriteLine("Qual é a cor do semáforo? (verde/amarelo/vermelho) ");
string cor = Console.ReadLine();

if (cor == "verde")
{
    Console.WriteLine(" Siga em frente amor! ");
}
else if (cor == "amarelo")
{
    Console.WriteLine("ATENÇÃO: reduza a velocidade");
}
else if (cor == "vermelho")
{
    Console.WriteLine("pare: aguarde o sinal verde!");
}
else if (cor == "rosa")
{
    Console.WriteLine("mano, em q planeta tu vive? daltonico do caralho");
}
else
{
    Console.WriteLine("ERRO 143: cor inválida");
}


