using System;

namespace armariobebe
{
    class program
    {
         static void Main(string[] args)
        { //criar o espaço (3)
            string[] aluno = new string[3];

            //Lendo os nomes
            Console.WriteLine("digite o primeiro nome: ");
            aluno [0] = Console.ReadLine();//

             Console.WriteLine("digite o segundo nome: ");
            aluno [1] = Console.ReadLine(); 

             Console.WriteLine("digite o terceiro nome: ");
            aluno [2] = Console.ReadLine();

            Console.WriteLine("\n Os nomes que foram armazenados são. . . . ");
            Console.WriteLine(aluno [0]);
            Console.WriteLine(aluno [1]);
            Console.WriteLine(aluno [2]);

        }
    }
    
}
