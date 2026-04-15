using System; //importa o namespace system, que contem classes fundamentais como a C

namespace aulalogicasenais //Define uma classe chamada pogram
{
    class program //define uma classe chamada pogram
    {
    //O método main éo ponto de entrada (Entry Point) dp pograma
    //é por aqui que o windowns começa a ler e executar o seu softwar
    static void Main(string[] args)
    {
        //!.Declaração do vetor (array) de 5 posições
        int[] numeros = new int[5];
        int contador = 0;

        Console.WriteLine("---ENTRADA DE DADOS (USANDO WHILE (EMQUANTO))---");
        //ENTRUTURA DE REPETICÃO while

        while(contador < numeros.Length)
            {
                Console.WriteLine($"digite o {contador + 1}° número: ");
                //Convert.ToInt32 é necessário pois o console.ReadLine retorna string

                numeros[contador] = Convert.ToInt32(Console.ReadLine());
                contador++;

            }
            //3. Estrutura de uma repetição For
            for(int i = 0; i < numeros.Length; i++)
            {
                //se o resto da divisão for 0 o numero é par
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número {numeros[i]} na posição {i+1} é PAR");
                }
            }
            Console.WriteLine("pressio ne qualquer tecla para encerrar...");
            Console.ReadKey();
    }

    }
}
