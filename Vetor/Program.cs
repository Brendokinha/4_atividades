using System;
class Pogram
{
    static void Main()
    {
        string[] aluno = new string[3];

        //colocando dados nas gavetas (botando valor na variavel)

        aluno[0] = "Ana";
        aluno[1] = "Brenda";
        aluno[2] = "Carlos";

        //exibir apenas um aluno especifico usando indicie
        Console.WriteLine("O primeiro aluno da lista é: " + aluno[1]);

        
    }
}