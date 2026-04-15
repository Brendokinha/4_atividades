using System;

class pogram
{
    static void Main()
    {
        //1. definição do vetor - guardar 5 medidas
        double[] medidas = new double[5];

        //2. Entrada de dados com FOR
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"insira a medida da {i + 1}° peça (mm): ");
            medidas[i] = double.Parse(Console.ReadLine());

            //verifica o valor dentro do vetor
            if (medidas[i] >= 10.0 && medidas[i] <= 10.5)
            {
                 Console.WriteLine($"Peças{i}: {medidas[i]}mm -> [APROVADO]");
            }

            else
            {
                Console.WriteLine($"Peça: {i}: {medidas[i]}mm -> [REPROVADO]");
            }
        }
        
        
    }
}