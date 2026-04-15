//perguntar a porra da temperatura
Console.Write("Qual é o clima?: ");
double graus = double.Parse(Console.ReadLine());

Console.Write("Temperatura Limite: ");
double templimite = double.Parse(Console.ReadLine());

if(graus <= templimite)
{
    Console.WriteLine("AAAAAAAAAA VAI PEGAR FOGO. Ligar ventilador se não essa porra pega fogo");
}

else
{
    Console.WriteLine("temperatura normal amor. desligador ventilador");
}
