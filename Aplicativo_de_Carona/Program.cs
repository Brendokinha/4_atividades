// perguntar o preço da corrida
Console.Write("Qual é o valor da corrida cralho? : ");
double preco = double.Parse(Console.ReadLine());

// perguntar o saldo do cliente
Console.Write("qual é teu saldo nessa caralha pobre fudido? :");
int saldo = int.Parse(Console.ReadLine());

//logica fudida
if (saldo >=preco)
{
    Console.WriteLine("boa corrida amore! motorista esta a caminho!");
}

else
{
    Console.WriteLine("saldo insuficiente, recarregue pobrezão");
}