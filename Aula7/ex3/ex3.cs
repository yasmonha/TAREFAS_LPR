using System;

class Program
{
    static void Main()
    {
        string[] cidades = { "Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo" };
        int[,] distancias = {
            { 0,   524, 521, 882 },
            { 524,   0, 434, 586 },
            { 521, 434,   0, 429 },
            { 882, 586, 429,   0 }
        };

        while (true)
        {
            Console.WriteLine("Cidades:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            Console.Write("Informe o número da cidade de origem: ");
            int origem = int.Parse(Console.ReadLine());

            Console.Write("Informe o número da cidade de destino: ");
            int destino = int.Parse(Console.ReadLine());

            if (origem == destino)
            {
                Console.WriteLine("Origem e destino são iguais. Por favor, renicie o programa.");
                break;
            }

            Console.WriteLine($"A distância entre {cidades[origem]} e {cidades[destino]} é {distancias[origem, destino]} km.\n");
        }
    }
}