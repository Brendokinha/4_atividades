double n1, n2, resultado;
string operacao;

Console.WriteLine("Digite o primeiro numero amor: ");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numerp: ");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("escolhe a operação (+, -, *, /): ");
operacao = Console.ReadLine();

switch (operacao)
{
    case "+":
    resultado = n1 + n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

     case "-":
    resultado = n1 - n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

     case "*":
    resultado = n1 * n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

     case "/":
    resultado = n1 / n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

    default:
    Console.WriteLine("operação inválida!");
    break;
}
Console.WriteLine("\nPressione Qualquer tecla para sair...");
Console.ReadKey();