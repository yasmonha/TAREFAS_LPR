using System;

string[] nomesHerois = new string[5];
string[] poderesHerois = new string[5];
int[] pontuacoesHerois = new int[5];
int contadorHerois = 0;

int[] equipeSelecionada = new int[3];
int tamanhoEquipe = 0;

void CadastrarHeroi()
{
    if (contadorHerois < 5)
    {
        Console.WriteLine($"Cadastro do {contadorHerois + 1}º Herói");
        Console.WriteLine("Podem ser cadastrados até 5 heróis.");
        Console.Write("Digite o nome do herói: ");
        nomesHerois[contadorHerois] = Console.ReadLine();

        Console.Write("Digite o poder do herói: ");
        poderesHerois[contadorHerois] = Console.ReadLine();

        Console.Write("Digite a pontuação do herói: ");
        pontuacoesHerois[contadorHerois] = int.Parse(Console.ReadLine());

        contadorHerois++;
        Console.WriteLine("Herói cadastrado com sucesso!");
    }
    else
    {
        Console.WriteLine("O limite de 5 heróis já foi atingido!");
    }
}

void SelecionarEquipe()
{
    if (contadorHerois == 0)
    {
        Console.WriteLine("Nenhum herói cadastrado para selecionar.");
        return;
    }

    Console.WriteLine("Lista de Heróis Cadastrados:");
    for (int i = 0; i < contadorHerois; i++)
    {
        Console.WriteLine($"{i + 1}. Nome: {nomesHerois[i]}, Poder: {poderesHerois[i]}, Pontuação: {pontuacoesHerois[i]}");
    }

    Console.WriteLine("Selecione 3 heróis para sua equipe digitando os números correspondentes (separados por espaço):");
    string[] selecoes = Console.ReadLine().Split(' ');

    if (selecoes.Length != 3)
    {
        Console.WriteLine("Você deve selecionar exatamente 3 heróis.");
        return;
    }

    tamanhoEquipe = 0; 
    foreach (string selecao in selecoes)
    {
        if (int.TryParse(selecao, out int indice))
        {
            indice--; // indice baseado em zero
            if (indice >= 0 && indice < contadorHerois)
            {
                equipeSelecionada[tamanhoEquipe++] = indice;
            }
            else
            {
                Console.WriteLine($"Seleção inválida: {selecao}");
            }
        }
        else
        {
            Console.WriteLine($"Entrada inválida: {selecao}");
        }
    }

    if (tamanhoEquipe == 3)
    {
        Console.WriteLine("Equipe selecionada com sucesso!");
    }
    else
    {
        Console.WriteLine("A equipe não foi selecionada corretamente. Tente novamente.");
        tamanhoEquipe = 0;
    }
}

int CalcularPontuacaoTotal()
{
    int pontuacaoTotal = 0;
    for (int i = 0; i < tamanhoEquipe; i++)
    {
        pontuacaoTotal += pontuacoesHerois[equipeSelecionada[i]];
    }
    return pontuacaoTotal;
}

void ExibirEquipe()
{
    if (tamanhoEquipe == 0)
    {
        Console.WriteLine("Nenhuma equipe foi selecionada.");
        return;
    }

    Console.WriteLine("\n----- Equipe Selecionada -----");

    for (int i = 0; i < tamanhoEquipe; i++)
    {
        int indice = equipeSelecionada[i];
        Console.WriteLine($"Nome: {nomesHerois[indice]}, Poder: {poderesHerois[indice]}, Pontuação: {pontuacoesHerois[indice]}");
    }

    int pontuacaoTotal = CalcularPontuacaoTotal();
    Console.WriteLine($"Pontuação Total da Equipe: {pontuacaoTotal}\n");
}
void MenuPrincipal()
{
    while (true)
    {
        Console.WriteLine("\n----- Sistema de Seleção de Heróis da Marvel -----");
        Console.WriteLine("1. Cadastrar Herói");
        Console.WriteLine("2. Selecionar Equipe");
        Console.WriteLine("3. Exibir Equipe");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opção: ");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            CadastrarHeroi();
        }
        else if (escolha == 2)
        {
            SelecionarEquipe();
        }
        else if (escolha == 3)
        {
            ExibirEquipe();
        }
        else if (escolha == 4)
        {
            Console.WriteLine("Saindo do programa...");
            return;
        }
        else
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
        }
    }
}

MenuPrincipal();