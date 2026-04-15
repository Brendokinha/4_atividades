double peso, altura, imc;
 
 Console.WriteLine("===CALCULADORA IMC ATIVADA===");
 Console.WriteLine("Digite o peso (kg)");
 peso = double.Parse(Console.ReadLine());

 Console.WriteLine("Digite a altura (m)");
 altura = double.Parse(Console.ReadLine());

 imc = peso/(altura * altura);

 if (imc <= 1.85)
{
    Console.WriteLine("Abaixo do peso");
}
else if(imc <= 25)
{
    Console.WriteLine("peso normal");
}
else
{
    Console.WriteLine("sobrepeso");
}