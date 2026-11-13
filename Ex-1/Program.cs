//1) Matriz com ordem direta e inversa

//Escreva um programa que crie uma matriz de números
//inteiros com a quantidade de linhas e colunas
//informada pelo usuário. Essa matriz deve ser
//populada automaticamente e exibida do primeiro
//ao último elemento e, em seguida, do último
//ao primeiro.

using System.Security.Cryptography;

int n1 = 0;
int n2 = 0;


Console.WriteLine("--------Primeiro Último--------");
Console.WriteLine("-------------------------------");

Console.WriteLine("Digite dois quaisquer números inteiros:");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());
int[,] m1 = new int[n1, n2];

void PopularMatrix()
{
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            m1[i, j] = RandomNumberGenerator.GetInt32(1, 9);
        }
    }
}

void ExibirPrimUlti()
{
    Console.WriteLine("Matriz normal:");
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            Console.Write($"{m1[i, j]}");
        }
    }
}

void ExibirUltiPrim()
{
    Console.WriteLine("\nMatriz invertida:");
    for (int i = (n1-1); i >= 0; i--)
    {
        for (int j = (n2-1); j >= 0; j--)
        {
            Console.Write($"{m1[i, j]}");
        }
    }
}

PopularMatrix();
ExibirPrimUlti();
ExibirUltiPrim();

Console.ReadKey();


