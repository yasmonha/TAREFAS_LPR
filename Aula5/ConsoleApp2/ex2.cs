using System;

class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101); 
        int chute;
        int tentativas = 0;

        Console.WriteLine("Tente acertar o numero aleatorio de 1 a 100 com o menor numero de tentativas possiveis!!");

        do
        {
            Console.Write("Digite seu chute: ");
            chute = int.Parse(Console.ReadLine());
            tentativas++;

            if (chute > valorInteiro)
            {
                Console.WriteLine("Chutou alto :(, tente novamente.");
            }
            else if (chute < valorInteiro)
            {
                Console.WriteLine("Chutou baixo :(, tente novamente.");
            }
            else
            {
                Console.WriteLine("ACERTOUUUU!!!");
                Console.WriteLine($"Voce conseguiu acertar em {tentativas} tentativas.");
            }

        } while (chute != valorInteiro); 
    }
}