using System;
class Program //temq ter o nome do projeto no class
{
        static void Main()
    {
        int[] numeros = new int[3];
        Console.WriteLine("digite o primeiro numero: ");
        numeros[0] =  int.Parse(Console.ReadLine());

        Console.WriteLine("digite o segundo numero: ");
        numeros[1] =  int.Parse(Console.ReadLine());

        Console.WriteLine("digite o terceiro numero: ");
        numeros[2] =  int.Parse(Console.ReadLine());

        Console.WriteLine("\n Valor digitados: ");
        Console.WriteLine(numeros[0]);
        Console.WriteLine(numeros[1]);
        Console.WriteLine(numeros[2]);

        
    }
}