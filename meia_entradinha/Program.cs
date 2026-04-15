// Pergunte o valor do ingresso
Console.Write("Qual é o valor do ingresso? ");
double preco = double.Parse(Console.ReadLine());

//2. Pergunta idade do cliente
Console.Write("Qual é a sua idade? ");
int idade = int.Parse(Console.ReadLine());

//Lógica de decisão
if (idade <18)
{
    double meiaEntrada = preco/2;
    Console.WriteLine("Você tem direito a meia entrada");
    Console.WriteLine("Valor a pagar R$ " + meiaEntrada);
}
else
{
    Console.WriteLine("Você para o valor inteiro");
    Console.WriteLine("Valor a pagar: R$ " + preco);
}