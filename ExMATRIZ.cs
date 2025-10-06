using System;
using MinhaBiblioteca;

class ExMATRIZ
{
    public static void gerarMatriz(int[,] mat)
    {
        int linha = mat.GetLength(0);
        int coluna = mat.GetLength(1);
        Random random = new Random();
        for (int i = 0; i < linha; i++)
            for (int j = 0; j < coluna; j++)
                mat[i, j] = random.Next(0, 2) //gerar matriz (os numeros vao mudando, nesse caso é para gerar uma binária)        
    }

    public static void Main()
    {
        Console.WriteLine("Qual o tamanho da matriz:");
        int linha, coluna;
        linha = int.Parse(Console.ReadLine());
        coluna = int.Parse(Console.ReadLine());

        int[,] matriz1 = new int[linha, coluna];
        int[,] matriz2 = new int[linha, coluna];

        gerarMatriz(matriz1);
        gerarMatriz(matriz2);
        Matriz.mostrarMatriz(matriz1);
        Console.WriteLine();
        Matriz.mostrarMatriz(matriz2);

    }
}
