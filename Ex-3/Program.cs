//3) Somatória de matriz

//Desenvolva um programa que crie e preencha uma
//matriz quadrada de números inteiros, de tamanho
//que será informado pelo usuário. Mostre os
//cálculos da somatória e os valores de cada linha
//individualmente, cada coluna, da diagonal
//principal e da diagonal inversa.

int tamanhoLinha = 0;
int tamanhoColuna = 0;

Console.WriteLine("-------Somatória matriz-------");
Console.WriteLine("------------------------------");
tamanhoLinha = int.Parse(Console.ReadLine());
tamanhoColuna = tamanhoLinha;

int[,] matriz = new int[tamanhoLinha, tamanhoColuna];

PopularMatriz(matriz);
ImprimirMatriz(matriz, tamanhoLinha, tamanhoColuna);
SomatoriaLinhas(matriz);
SomatoriaColunas(matriz);
SomatoriaDiagonal(matriz);
SomatoriaDiagonalInversa(matriz);

void PopularMatriz(int[,] matriz)
{
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            matriz[linha, coluna] = Random.Shared.Next(1, 99);
        }
    }
}

void ImprimirMatriz(int[,] matriz, int tamanhoLinha, int tamanhoColuna)
{
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            Console.Write($"[{matriz[linha, coluna]}]\t");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine("\n");
}

void SomatoriaLinhas(int[,] matriz)
{
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        int soma = 0;

        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            soma += matriz[linha, coluna];
        }

        Console.WriteLine($"Soma da {linha +1}º linha: {soma}");
    }
}

void SomatoriaColunas(int[,] matriz)
{
    for (int coluna = 0; coluna < tamanhoLinha; coluna++)
    {
        int soma = 0;

        for (int linha = 0; linha < tamanhoColuna; linha++)
        {
            soma += matriz[linha, coluna];
        }

        Console.WriteLine($"Soma da {coluna + 1}º coluna: {soma}");
    }
}

void SomatoriaDiagonal(int[,] matriz)
{
    int soma = 0;

    for (int i = 0; i < tamanhoLinha; i++)
    {
        soma += matriz[i, i];
    }

    Console.WriteLine($"Soma da diagonal principal é: {soma}");
}

void SomatoriaDiagonalInversa(int[,] matriz)
{
    int soma = 0;

    for (int i = 0; i < tamanhoLinha; i++)
    {
        soma += matriz[tamanhoLinha - 1 - i, i];
    }

    Console.WriteLine($"Soma da diagonal inversa é: {soma}");

}