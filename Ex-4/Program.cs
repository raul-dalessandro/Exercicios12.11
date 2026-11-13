//4) Boletim escolar

//Desenvolva um programa que gere o boletim escolar
//de um aluno. Critérios:

//As linhas são as matérias, e as colunas são as
//notas de cada bimestre, mais a média e a situação
//do aluno em cada matéria.

//Aprovado se a média for maior ou igual a 7,
//recuperação se a média for entre 5,1 e 6,9
//e reprovado se for menor ou igual a 5.

Console.WriteLine("---------Boletim---------");
Console.WriteLine("-------------------------");

Console.WriteLine("Quantas matérias você possui?");
int quantidadeMaterias = int.Parse(Console.ReadLine());

string[,] boletim = new string[quantidadeMaterias, 7];


PercorrerMaterias(boletim);
MediaNota(boletim);
DescobrirSituacao(boletim);
ImprimirBoletim(boletim, quantidadeMaterias, 7);

void PercorrerMaterias(string [,] boletim)
{
    for (int linha = 0; linha < quantidadeMaterias; linha++)
    {
        Console.WriteLine("Digite o nome da matéria:");
        boletim[linha, 0] = Console.ReadLine();

        for (int coluna = 1; coluna <= 4; coluna++)
        {
            Console.WriteLine($"Digite a nota do {coluna}º bimestre:");
            boletim[linha, coluna] = Console.ReadLine();
        }
        Console.Clear();
    }
}

void MediaNota(string [,] boletim)
{
    for (int linha = 0; linha < quantidadeMaterias; linha++)
    {
        double soma = 0;

        for (int coluna = 1; coluna <= 4; coluna++)
        {
            soma += double.Parse(boletim[linha, coluna]);
        }

        boletim[linha, 5] = (soma / 4).ToString();
    }
}

void DescobrirSituacao(string [,] boletim)
{
    for (int linha = 0; linha < quantidadeMaterias; linha++)
    {
        double media = double.Parse(boletim[linha, 5]);

        if (media >= 7)
        {
            boletim[linha, 6] = "Aprovado";
        }
        else if (media > 5 && media < 7)
        {
            boletim[linha, 6] = "Recuperação";
        }
        else
        {
            boletim[linha, 6] = "Reprovado";
        }
    }
}

void ImprimirBoletim(string [,] matriz, int quantidadeMaterias, int tamanhoColuna) //Ajeitado para parecer um boletim escolar,(pesquisei)
{
    Console.WriteLine(
    "Matéria".PadRight(15) +
    "1º Bi".PadRight(15) +
    "2º Bi".PadRight(15) +
    "3º Bi".PadRight(15) +
    "4º Bi".PadRight(15) +
    "Média".PadRight(15) +
    "Situação".PadRight(15)
    );

    for (int linha = 0; linha < quantidadeMaterias; linha++)
    {
        for (int coluna = 0; coluna < tamanhoColuna; coluna++)
        {
            Console.Write($"{matriz[linha, coluna].PadRight(15)}");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine("\n");
}
