using System;

class Program {
    static void Main()
    {
        int quantidade, numero, somaPares = 0, quantidadePares = 0;
        double media;

        Console.WriteLine("Digite a quantidade de numeros a serem calculados: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Agora, digite os numeros PARES escolidos de acordo com a quantidade e separados por espaço: ");
        string[] numeros = Console.ReadLine().Split(' ');
        
        int i = 0;

        while (i < quantidade)
        {   numero = int.Parse(numeros[i]);

            if (numero % 2 == 0) 
            {
                somaPares += numero;
                quantidadePares++;
            }

            i++;
        }

        
        if (quantidadePares > 0)
        {
            media = (double)somaPares / quantidadePares;
            Console.WriteLine($"A media aritmética dos numeros pares é: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum numero par foi digitado.");
        }
    }
}