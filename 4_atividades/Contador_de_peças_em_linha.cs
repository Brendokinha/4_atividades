
int quantidade;
int contador = 1;

Console.WriteLine("diga a quantidade de produtos: ");
quantidade=int.Parse(Console.ReadLine());

while (contador <= quantidade)
{
    Console.WriteLine($"Produto n° {contador} processando" );
    contador++;
}
 