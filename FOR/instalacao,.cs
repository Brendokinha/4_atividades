//declaração de variaveiss

int porcentagem;
int cont;

Console.WriteLine("iniciando a instalação...");
//o laço vai de um a dez
for (cont = 1; cont <=10; cont++)
{
  porcentagem = cont * 10;
  Console.WriteLine($"progresso :D {porcentagem}%");
}
Console.WriteLine("\n Sistema instalado com sucesso!");