//2) Matriz inversa e transposta

//Escreva um programa que gere uma matriz 3x5,
//populada automaticamente, e, com base nela,
//gere duas novas matrizes:
//-Uma matriz inversa, na qual os elementos
//  sejam exibidos na ordem contrária, do último
//  para o primeiro.
//- Uma matriz transposta, transformando a matriz
//  original 3x5 em uma matriz 5x3.


int tamanhoLinha = 3, tamanhoColuna = 5;

Console.WriteLine("-------Matriz inversa e transposta-------");
Console.WriteLine("-----------------------------------------");

int[,] matriz = new int[tamanhoLinha, tamanhoColuna];
int[,] matrizInvertida = new int[tamanhoLinha, tamanhoColuna];
int[,] matrizTransposta = new int[tamanhoColuna, tamanhoLinha];

PopularMatriz(matriz);

Console.WriteLine("\nMatriz original:");
ImprimirMatriz(matriz, tamanhoLinha, tamanhoColuna);

InverterMatriz(matriz, matrizInvertida);

Console.WriteLine("\nMatriz invertida:");
ImprimirMatriz(matrizInvertida, tamanhoLinha, tamanhoColuna);

TransporMatriz(matriz, matrizTransposta);

Console.WriteLine("\nMatriz transposta:");
ImprimirMatriz(matrizTransposta, tamanhoColuna, tamanhoLinha);

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
}
void InverterMatriz(int[,] matriz, int[,] matrizInvertida)
{
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            matrizInvertida[
                tamanhoLinha - 1 - linha,//Menos 1 porque o indice comeca no 0 e menos a linha para inverter 
                tamanhoColuna - 1 - coluna
            ] = matriz[linha, coluna];
        }
    }
}

void TransporMatriz(int[,] matriz, int[,] matrizTransposta)
{
    for (int linha = 0; linha < tamanhoLinha; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            matrizTransposta[coluna, linha] = matriz[linha, coluna];
        }
    }
}