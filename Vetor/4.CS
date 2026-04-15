using System;
class pogram
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] notas = new double[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"===CADASTRO DO {i + 1}º Aluno");
            Console.WriteLine("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"nota de {nomes[i]}:");
             notas[i] = double.Parse(Console.ReadLine());

              Console.WriteLine(); //linhA ewm branco para organizar

        }

        //exibição de dadods
        Console.WriteLine("\n====BOLETIM ESCOLAR====");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Aluno: {nomes[i].PadRight(10)} |  Nota: {notas[i]:F1}");
        }
    }
}