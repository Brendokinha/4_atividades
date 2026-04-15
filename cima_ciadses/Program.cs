using System;

namespace armariobebe
{
class Pogram
{
    static void Main()
    {//criando o vetor 3
        double[] clima = new double [3];

        //entrada de dados
        Console.WriteLine("\n---ENTRADA DE DADOS---");
        Console.WriteLine("digite a temperatira da cidade 1:");
        clima[0] = double.Parse(Console.ReadLine());

        Console.WriteLine("digite a temperatira da cidade 2:");
        clima[1] = double.Parse(Console.ReadLine());

        Console.WriteLine("digite a temperatira da cidade 3:");
        clima[2] = double.Parse(Console.ReadLine());
        //
        
        if (clima[0] < 20)
            {
                Console.WriteLine("cidade 1: esta frio");
            }
            else if(clima[0] >= 25)
            {
                 Console.WriteLine("cidade 1: esta agradavel");
            }
            else if (clima[0] > 25)
            {
                 Console.WriteLine("cidade 1: esta quente");
            }
    }
}
}