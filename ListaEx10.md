using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de lançamentos do dado (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] lancamentos = new int[N];
        int[] ocorrencias = new int[6]; // índices 0-5 representam as faces 1-6

        Random random = new Random();

        Console.WriteLine("\nResultados dos lançamentos:");
        for (int i = 0; i < N; i++)
        {
            // sorteia valores de 1 a 6
            lancamentos[i] = random.Next(1, 7);
            Console.Write(lancamentos[i] + " ");

            // contabiliza ocorrência
            ocorrencias[lancamentos[i] - 1]++;
        }

        Console.WriteLine("\n\nNúmero de ocorrências de cada face:");
        for (int face = 0; face < 6; face++)
        {
            Console.WriteLine($"Face {face + 1}: {ocorrencias[face]} vez(es)");
        }
    }
}
