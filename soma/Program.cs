using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main()
    {
        int num2;

        int num1;

        int soma;

        Console.WriteLine("digite aqueles números lá: ");
        num1 = int.parse(Console.ReadLine());

        Console.WriteLine("digite aqueles números lá: ");
        num2 = int.parse(Console.ReadLine());

        soma = int.Parse(num1 + num2);
        Console.WriteLine(soma);
    }

}
