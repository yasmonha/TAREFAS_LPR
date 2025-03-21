using System;

class Program{
static void Main(){
    

    Console.WriteLine("Digite um número interiro qualquer: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero %2==0){
        Console.WriteLine("Esse número é par.");
    } else {Console.WriteLine("Esse número é ímpar.");}

}
}
