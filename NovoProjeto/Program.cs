using System;
class Program
{
    static void Main()
    {
        //declarar variavel para armazenar o nome
        string nome;

        //Declarar variável para armazenar a idade
        int idade;

        //Pede para o usuário digitar o nome
        Console.Write("digite seu nomezinho fofo: ");
        nome = Console.ReadLine(); // Le o texto digitado

        //Pede para o usuário digitar a idade
        Console.WriteLine("digite sua idade fofa kawaii: ");
       idade = int.Parse(Console.ReadLine()); // Le e converte para numero

       //Mostrar o resultado
       Console.WriteLine("----- ESPERE AI CARALHO -----");
       Console.WriteLine("Nomezinho: " + nome);
       Console.WriteLine("idade kawaii: " + idade);

       //Aguarda tecla
       Console.ReadKey();

    }
}