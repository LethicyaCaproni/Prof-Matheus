using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.Write("Digite o tamanho dos vetores (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetorA = new int[N];
        int[] vetorB = new int[N];
        int[] vetorC = new int[N];

        Console.WriteLine("\nVetor A:");
        for (int i = 0; i < N; i++)
        {
            vetorA[i] = random.Next(1, 10); // números de 1 a 9
            Console.Write(vetorA[i] + " ");
        }

        Console.WriteLine("\n\nVetor B:");
        for (int i = 0; i < N; i++)
        {
            vetorB[i] = random.Next(1, 10); 
            Console.Write(vetorB[i] + " ");
        }

        // Multiplicação elemento a elemento
        for (int i = 0; i < N; i++)
        {
            vetorC[i] = vetorA[i] * vetorB[i];
        }

        Console.WriteLine("\n\nVetor C (resultado da multiplicação):");
        for (int i = 0; i < N; i++)
        {
            Console.Write(vetorC[i] + " ");
        }
    }
}
