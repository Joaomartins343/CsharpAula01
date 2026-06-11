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

