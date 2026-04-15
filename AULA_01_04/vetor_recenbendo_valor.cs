using System;
public class vetor_recenbendo_valor
{
    public static void Main()
    {
        int[] numeros = new int[3];
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor para a posição [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"posição[{i}] = {numeros[i]}");
        }
    }
}