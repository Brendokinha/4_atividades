using System.Security.Cryptography.X509Certificates;

int tabuada;
int resultado;
int multiplicador;

Console.Write("digite um numero: ");
tabuada = int.Parse(Console.ReadLine());
for(multiplicador = 1; multiplicador <=10; multiplicador++)
{
    resultado = tabuada*multiplicador;
    Console.WriteLine($"{tabuada} X {multiplicador} = {resultado}");
}
