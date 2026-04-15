int temp;
Console.WriteLine("===VERIFICADOR DE CLIMA===");
Console.WriteLine("\n Qual é a temperatura?");
temp = int.Parse(Console.ReadLine());

if(temp <= 25)
{
    Console.WriteLine("===ATIVANDO O AQUECEDOR===");
}
else if (temp >= 15 || temp <= 25)
{
    Console.WriteLine("===TEMPERATURA IDEAL===");
}
else if (temp >= 25)
{
    Console.WriteLine("===ATIVANDO O RESFRIAMENTO===");
}