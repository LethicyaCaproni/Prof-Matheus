using System;

class lista01
{
    static void Main(string[] args)
    {
        Console.Write("Informe o número de elementos (N): ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int soma = SomarElementos(vetor);

        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
    }

    static int SomarElementos(int[] vetor)
    {
        int soma = 0;
        foreach (int numero in vetor)
        {
            soma += numero;
        }
        return soma;
    }
}
