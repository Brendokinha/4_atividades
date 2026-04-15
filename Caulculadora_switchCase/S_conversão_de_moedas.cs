double valor, valorfinal = 0;
int moeda;

Console.WriteLine("====BEM VINDO AO CAIXA====");
Console.WriteLine("Valor reais deseja converter?: ");
valor = double.Parse(Console.ReadLine()); //

Console.WriteLine("===CONVERÇÕES DIPONIVEIS===");
Console.WriteLine("1- Dólar ");
Console.WriteLine("2- Euro ");
Console.WriteLine("3- Peso argentino ");
Console.WriteLine("4- Libra Estalina ");
Console.WriteLine("===========================");
Console.WriteLine("Escolha para qual moeda você quer converter: ");
moeda = int.Parse(Console.ReadLine()); //

switch (moeda)
{
   case 1:
   valorfinal =  valor / 5.00;
   break;

   case 2:
   valorfinal =  valor / 5.50;
   break;

   case 3:
   valorfinal =  valor * 160.00;
   break;

   case 4:
   valorfinal =  valor / 6.50;
   break;

   default: //nao esqueça do default! se nao da pau
   valorfinal = valor;
   Console.WriteLine("========FALHA========");
   Console.WriteLine("Tente novamente!");
   break;

}
Console.WriteLine("===== CONVERTENDO... =====");
Console.WriteLine($"Concluído! seu dinheiro convertido: R$ {valorfinal}");