int tabuada;
int multiplicador;
int resultado;

//o laço de fora escolhe qual tabuada estamos fazendo
for (tabuada = 1; tabuada <=10; tabuada++)
{
    Console.WriteLine($"---tabuada do {tabuada}--- ");

for (multiplicador = 1; multiplicador <=10; multiplicador++)
{
    resultado = tabuada * multiplicador;
    Console.WriteLine($"{tabuada} X {multiplicador} = {resultado} ");
}
}