using System;
class Program
{
    static void Main()
    {
        //declaração de variaveis
        int[] estoque = new int[5];

        //FOR para guardar os pedidos
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite a qtd para a caixa {i}: ");
            estoque[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n----RELATORIO----");
        for(int i = 0; i < 5; i++)
        {
            if(estoque[i] < 10)
            {
                Console.WriteLine($"Caixa {i}: Repor");
            }
            else
            {
                Console.WriteLine($"Caixa {i}: OK");
            }
        }
    }
}
