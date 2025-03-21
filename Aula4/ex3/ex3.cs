using System;

class Program {
static void Main(){

int personagem;

Console.WriteLine("Para começar, escolha uma classe de personagem. Você pode escolher entre 3 categorias selecionando 1/n o número correspondente:Guerreira(1), Mago(2) e Arqueira(3)");
Console.WriteLine("Insira o número correspondente ao personagem escolhido: ");

personagem = int.Parse(Console.ReadLine());

if (personagem == 1){
    Console.WriteLine("Ataque Pesado e Defesa Total");
} else if (personagem == 2){
    Console.WriteLine("Bola de Fogo e Escudo de Gelo");
}else if (personagem == 3){
    Console.WriteLine("Flecha Precisa e Disparo Triplo");
} else {
    Console.WriteLine("Essa é uma opção inválida.");
}
}
}

