using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.Write("Digite a quantidade de números que deseja sortear: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        Console.WriteLine("\nNúmeros sorteados:");
        for (int i = 0; i < N; i++)
        {
            vetor[i] = random.Next(0, 100); // sorteia entre 0 e 99
            Console.Write(vetor[i] + " ");
        }

        Console.Write("\n\nDigite um número para buscar no vetor: ");
        int num = int.Parse(Console.ReadLine());

        bool encontrado = false;
        for (int i = 0; i < N; i++)
        {
            if (vetor[i] == num)
            {
                Console.WriteLine($"O número {num} foi encontrado na posição {i} do vetor.");
                encontrado = true;
            }
        }
