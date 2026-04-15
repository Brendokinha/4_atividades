
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[3];
        Console.Write("Digite o primeiro numero: ");
        numeros[0] = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        numeros[1] = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro numero: ");
        numeros[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nValor digitados: ");
        Console.WriteLine(numeros[0]);
        Console.WriteLine(numeros[1]);
        Console.WriteLine(numeros[2]);
        
    }
}