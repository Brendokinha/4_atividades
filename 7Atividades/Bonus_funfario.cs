
int anos;
double salario;
double Bonus;

Console.WriteLine("===== BEM VINDO =====");
Console.WriteLine("\n Vamos calcular seu bõnus?");
Console.WriteLine("\n ---------------------------");
Console.WriteLine("Digite teu salário:");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite quantos anos:");
anos = int.Parse(Console.ReadLine());

if(anos >= 10)
{
    Bonus = salario * 0.80;
    Console.WriteLine("Parabéns! seu bônus foi de 20%");
    Console.WriteLine("Bonus aplicado! total:" + Bonus);
}

else if (anos >= 5 && anos <= 10)
{
    Bonus = salario * 0.90;
    Console.WriteLine("Parabéns! seu bônus foi de 10%");
    Console.WriteLine("Bonus aplicado! total:" + Bonus);
}

else
{
    Bonus= salario * 0.95;
    Console.WriteLine("Parabéns! seu bônus foi de 5%");
    Console.WriteLine("Bonus aplicado! total:" + Bonus);
}
