using System;
public class NotasAulas
{
    public static void Main()
    {
        double[,] NotasAulas = new double[3,2];

        NotasAulas[0,0] = 8.5;
        NotasAulas[0,1] = 7.0;
        NotasAulas[1,0] = 6.0;
        NotasAulas[1,1] = 9.5;
        NotasAulas[2,0] = 10.0;
        NotasAulas[2,1] = 8.0;

        Console.WriteLine("Relatorio de notas: ");
        for(int i = 0; i < 3; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"[Nota {j + 1}: {NotasAulas[i, j]}]");
            }
            Console.WriteLine();
        }
    }
}