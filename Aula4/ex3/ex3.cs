/*Exercício 3) C#
Suponha que você está desenvolvendo um jogo
de RPG. Você é responsável por implementar a
mecânica de habilidades especiais para
diferentes classes de personagens. Cada classe
tem suas próprias habilidades especiais.
Crie um programa que permita ao jogador
escolher uma classe de personagem e, em
seguida, exiba suas habilidades especiais
correspondentes. 
*/
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

