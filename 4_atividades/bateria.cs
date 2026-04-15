
int hora = 0;
double consumoporhora = 5;

Console.Write("digite a carga inicial da bateria (0 a 100)");
double bateria = double.Parse(Console.ReadLine());

while (bateria >0)
{
    hora = hora + 1;
    bateria =  bateria - consumoporhora;
    if (bateria < 0)
    {
        bateria = 0;
    }
    Console.WriteLine($"hora: {hora} - carga; {bateria}");
    if(bateria <=20 && bateria > 0)
    {
        Console.WriteLine("ALERTA! carga baixa, modo de economia baixa");
    
    }
}
Console.WriteLine("STATUS: bateria 0%. dispositivo desligado.");