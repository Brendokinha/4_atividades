using System;
public class primeiramatriz
{
    public static void Main()
    {
        int[,] matriz = new int[2,2];

        //atribuindo valores anualmente
        //linhas depois colunas
        matriz[0,0] = 10;
        matriz[0,1] = 20;
        matriz[1,0] = 30;
        matriz[1,1] = 40;

        Console.WriteLine("valores da matriz:\n");
        Console.WriteLine($"[{0},{0}] = {matriz[0,0]}");
        Console.WriteLine($"[{0},{1}] = {matriz[0,1]}");
        Console.WriteLine($"[{1},{0}] = {matriz[1,0]}");
        Console.WriteLine($"[{1},{1}] = {matriz[1,1]}");

    }
}