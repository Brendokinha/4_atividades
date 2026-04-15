//tabuada

int num1;
int multiplicador;
int resultado;

Console.Write("qual tabuada voce deseja ver? ");
num1 = int.Parse(Console.ReadLine());

for (multiplicador = 1; multiplicador <=10; multiplicador++)
{
    resultado = num1 * multiplicador;

    Console.WriteLine($"{num1} X {multiplicador} = {resultado}");

}
