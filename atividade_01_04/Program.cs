using System;

class Program
{
    static void Main()
    {
        
        int[,] estoque = new int[2, 2];

      
        estoque[0, 0] = 15; // Parafusos
        estoque[0, 1] = 20; // Porcas
        estoque[1, 0] = 10; // Buchas
        estoque[1, 1] = 30; // Arruelas

    
        int totalInferior = estoque[1, 0] + estoque[1, 1];
     
        Console.WriteLine("Total de itens na prateleira inferior: " + totalInferior);
    }
}