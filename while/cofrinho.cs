int saldo = 0;
Console.WriteLine("=== MEU COFRINHO DIGITAL ===");

while(saldo < 500)
{
    Console.WriteLine("Saldo atual R$:" +saldo);
    saldo = saldo + 50;
    
    Console.WriteLine("Depositando Saldo Novo de R$50,00" +saldo);
}
Console.WriteLine("Parabens! Você atingiu sua meta.");