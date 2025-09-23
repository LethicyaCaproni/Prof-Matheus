using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho do vetor (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        Console.WriteLine("\nDigite os elementos do vetor:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite o valor que deseja buscar: ");
        int valor = int.Parse(Console.ReadLine());

        // Mostra o vetor
        Console.WriteLine("\nElementos do vetor:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        // Conta ocorrências
        int contador = 0;
        for (int i = 0; i < N; i++)
        {
            if (vetor[i] == valor)
            {
                contador++;
            }
        }

        Console.WriteLine($"\n\nO valor {valor} aparece {contador} vez(es) no vetor.");
    }
}
