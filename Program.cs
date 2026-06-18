//Ativ 1 - Saudacoes PLayer
using System.ComponentModel.Design;

Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome} sua jornada de 100 horas no mundo de C# começou. Boa sorte!");
Console.WriteLine("-------------------------------------");


//Ativ2 - total de Xp
Console.Write("Xp recebidos da primeira missao: ");
int xp1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Xp recebido da segunda missao: ");
int xp2 = Convert.ToInt32(Console.ReadLine());

int total = xp1 + xp2;
Console.WriteLine($"O total do Xp recebido na missao foi de: {total}");

Console.WriteLine("-------------------------------------");


//Ativ 3 - Loja de pocoes
int pocao = 75;
Console.WriteLine($"A pocao custa {pocao} Quantas pocoes vai querer comprar?");

int quantidade = Convert.ToInt32(Console.ReadLine());

int valor = quantidade * pocao;
Console.WriteLine($"O valor total a ser pago é de: {valor}");
Console.WriteLine("---------------------------------------");


//Ativ 4 - Conversor de Coordenadas
Console.Write("Diga quantos metros seu personagem andou: ");

// int totalpixels = 64;
double andou = Convert.ToInt64(Console.ReadLine());
double totalpixels = 64 * andou;

Console.WriteLine($"O personagem andou {totalpixels} pixels");
Console.WriteLine("---------------------------------------");


//Ativ 5 - Media de Xp
Console.Write("Quantos Pontos voce recebeu na primeira partida: ");
int p1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Pontos recebidos na segunda partida: ");
int p2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Pontos recebidos na terceira partida: ");
int p3 = Convert.ToInt32(Console.ReadLine());

double media = p1 + p2 + p3 /3.0;
Console.WriteLine($"A media é de: {media}");
Console.WriteLine("---------------------------------------");

//Ativ 6 - Termometro de Survival Game
Console.Write("Digite quantos graus esta fazendo: ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine($"A temperatura esta em {fahrenheit}F");
Console.WriteLine("---------------------------------------");

//Ativ 7 - ID de Itens Relacionados
Console.WriteLine("Digite o ID da Skin desejada: ");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Skin Anterior: {id -1}");
Console.WriteLine($"Skin Atual: {id}");
Console.WriteLine($"Proxima Skin: {id +1}");
Console.WriteLine("---------------------------------------");

//Ativ 8 - Alerta de Hp Critico
Console.WriteLine("HP maximo do personagem: ");
double hpmax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quantos de vida voce tem atualmente: ");
double hpatual = Convert.ToInt32(Console.ReadLine());

double vida = (hpatual
    / hpmax) * 75;

if (vida < 25)
{
    Console.WriteLine("ALERTA: Vida Crítica! Use uma poção!");
}
else
{
    Console.WriteLine("Hp estavel}");
}
Console.WriteLine("---------------------------------------");


//Ativ 9 - Classificacao Etaria

Console.WriteLine("Digite quantos anos voce tem: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Autorizado");
}
else
{
    Console.WriteLine("Nao Autorizado");
}
Console.WriteLine("---------------------------------------");

//Ativ 10 - Confronto PVP

Console.Write("O time Alpha tem quantas kills: ");
int alpha = Convert.ToInt32(Console.ReadLine());
Console.Write("O time Omega tem quantas kills: ");
int omega = Convert.ToInt32(Console.ReadLine());

if (alpha > omega){
    Console.WriteLine("O time Alpha Ganhou");
}
else if (omega > alpha)
{
    Console.WriteLine("O time Omega Ganhou");
}
else{
    Console.WriteLine("Ambas Equipes empataram em kills");
}


    Console.WriteLine("---------------------------------------");

//Ativ 11 - Sistema de faccoes
 Console.Write("Digite o seu ID de registro: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (id % 2 == 0)
        {
            Console.WriteLine("Facção designada: Magos do Alvorecer");
        }
        else
        {
            Console.WriteLine("Facção designada: Guerreiros da Noite");
        }
    }

    static void ExecutarEx12()
    {
        Console.WriteLine("--- 12. Validação de Cheat Code ---");
        Console.Write("Username: ");
        string user = Console.ReadLine();
        Console.Write("Password: ");
        string pass = Console.ReadLine();

        if (user == "godmode" && pass == "666")
        {
            Console.WriteLine("Trapaça Ativada: Modo Imortal Habilitado");
        }
        else
        {
            Console.WriteLine("Código Inválido");
        }
    }

     //ativ12 -  Peso do Inventário de Carga
        Console.Write("Peso atual da mochila (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        if (peso > 50.0)
        {
            Console.WriteLine("Aviso: Sobrecarga de peso detectada! O personagem não consegue correr.");
        }
        else
        {
            Console.WriteLine("Peso dentro do limite. Você pode correr normalmente.");
        }
    }

    //Ativ 13 - Ranking Competitivo por MMR
        Console.Write("Digite sua pontuação de MMR: ");
        int mmr = Convert.ToInt32(Console.ReadLine());

        if (mmr < 1000)
        {
            Console.WriteLine("Classificação: Rank Bronze");
        }
        else if (mmr >= 1000 && mmr <= 2000)
        {
            Console.WriteLine("Classificação: Rank Prata");
        }
        else
        {
            Console.WriteLine("Classificação: Rank Ouro");
        }
    }

//Ativ 15 - Spawner Sequencial de Inimigos
        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine($"Inimigo #{i} gerado.");
        }
    }

//Ativ 16 - Spawn do Boss
        Console.WriteLine("O escudo do Boss será ativado nos seguintes rounds:");
        for (int i = 2; i <= 100; i += 2)
        {
            Console.WriteLine($"Round {i}");
        }
    }

//Ativ 17 - Contagem Regressiva do Round
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("FIGHT! COMEÇOU O ROUND!");
    }

//Ativ 18 - Farm Semanal Acumulado
        int totalMoedas = 0;

        for (int i = 1; i <= 7; i++)
        {
            Console.Write($"Moedas farmadas no Dia {i}: ");
            totalMoedas += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"\nMontante total arrecadado na semana: {totalMoedas} moedas.");
    }

//Ativ 19 - Multiplicador de Combo de Dano 
        Console.Write("Qual o dano base do ataque do herói? ");
        double danoBase = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}x Acertos | Dano Total: {danoBase * i}");
        }
    }

//Ativ 20 - Quebrador de Baús
        string senha = "";

        while (senha != "ABRACADABRA")
        {
            Console.Write("Tente adivinhar a palavra-chave do baú lendário: ");
            senha = Console.ReadLine();

            if (senha != "ABRACADABRA")
            {
                Console.WriteLine("Incorreto! O baú permanece trancado.\n");
            }
        }
        Console.WriteLine("Baú destrancado! Você encontrou itens lendários!");
    }

//Ativ 21 - Dungeon Customizável
        Console.Write("Quantas salas (N) a dungeon terá? ");
        int nSalas = Convert.ToInt32(Console.ReadLine());

        double somaDificuldade = 0;

        for (int i = 1; i <= nSalas; i++)
        {
            Console.Write($"Dificuldade da Sala {i} (1 a 100): ");
            somaDificuldade += Convert.ToDouble(Console.ReadLine());
        }

        double media = somaDificuldade / nSalas;
        Console.WriteLine($"\nA média de dificuldade geral do mapa é: {media}");
    }

//Ativ 22 - Simulador de Drop Rate (Loot Box) ---");
        int lootComum = 0;
        int lootRaro = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Raridade da {i}ª caixa (0 a 100): ");
            int raridade = Convert.ToInt32(Console.ReadLine());

            if (raridade < 50)
            {
                lootComum++;
            }
            else
            {
                lootRaro++;
            }
        }

        Console.WriteLine("\n--- Balanço do Inventário ---");
        Console.WriteLine($"Loot Comum: {lootComum}");
        Console.WriteLine($"Loot Raro: {lootRaro}");
    }

//Ativ 23 - Recorde Absoluto de Pontos (High Score) ---");
        int maiorPontuacao = 0;
        int pontuacaoAtual = -1;

        Console.WriteLine("Digite as pontuações dos jogadores. (Digite 0 para encerrar)");

        while (pontuacaoAtual != 0)
        {
            Console.Write("Pontuação: ");
            pontuacaoAtual = Convert.ToInt32(Console.ReadLine());

            if (pontuacaoAtual > maiorPontuacao)
            {
                maiorPontuacao = pontuacaoAtual;
            }
        }
        Console.WriteLine($"\nA Captação foi encerrada. Maior pontuação registrada: {maiorPontuacao}");
    }

//Ativ 24 - Gasto e Esvaziamento de Mana ---");
        int mana = 1000;

        while (mana > 0)
        {
            Console.WriteLine($"Mana Atual: {mana}");
            Console.Write("Quanto de mana o feitiço custou? ");
            int gasto = Convert.ToInt32(Console.ReadLine());

            mana -= gasto; 
        }

        Console.WriteLine("\nMana Esgotada! Recarregue.");
    }

//Ativ 25 - Painel MVP (Most Valuable Player) ---");
        int totalAbatesCla = 0;
        int maiorNumeroAbates = -1;
        string nomeMVP = "";

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"\nJogador {i}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Número de Abates (Kills): ");
            int abates = Convert.ToInt32(Console.ReadLine());

            totalAbatesCla += abates;

    
            if (abates > maiorNumeroAbates)
            {
                maiorNumeroAbates = abates;
                nomeMVP = nome;
            }
        }

        Console.WriteLine("\n--- RELATÓRIO DO ROUND ---");
        Console.WriteLine($"Somatório de Abates do Clã: {totalAbatesCla} Kills");
        Console.WriteLine($"MVP da Rodada: {nomeMVP} com {maiorNumeroAbates} eliminações!");
