using System;
using System.Net.Mail;
class Program
{
    static void Main()
    {
        string nome;

        int idade;

        string série;

        int RA;

        string email;



        Console.Write("seu digite seu nome bonitinho, aluno querido: ");
        nome = Console.ReadLine(); 

        Console.WriteLine("digite sua idadezinha, flor: ");
       idade = int.Parse(Console.ReadLine());

       Console.WriteLine("digite sua série: ");
       série = Console.ReadLine();

       Console.WriteLine("digite aqueles números lá: ");
       RA = int.Parse(Console.ReadLine());

       Console.WriteLine("Digite seu email (Tudo bem se for vergonhoso): ");
       email = Console.ReadLine();

       Console.WriteLine("----- Um segundinho, amor <3 -----");
       Console.WriteLine("Nomezinho" + nome);
       Console.WriteLine("idade sei la: " + idade);
       Console.WriteLine("serie QUACK QUACK!: " + série);
       Console.WriteLine("Aqueles numero doido lá: " + RA);
       Console.WriteLine("Emailzinho: " + email);

       Console.ReadKey();

    }
}