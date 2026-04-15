using System;
class Pogram
{
    static void Main()
    {
        string[] nomes = new string[5];
        for (i = 0; i < 5; i++)
        {
            Console.Write($"Digite o nome para a posição {i}:");
            nomes[i] = Console.ReadLine();
        }
        Console.WriteLine("qual posicao vc quer consultar" );
        int posicao = int.Parse(Console.ReadLine());
        //retorna o valor do vertpr

        Console.WriteLine($"Na posicao {posicao} esta o nome {nomes[posicao]}");
    }
}