using System;

class Program
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

        int quantidadeImpares = ContarImpares(vetor);

        Console.WriteLine($"Quantidade de números ímpares no vetor: {quantidadeImpares}");
    }

    static int ContarImpares(int[] vetor)
    {
        int contador = 0;
        foreach (int numero in vetor)
        {
            if (numero % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }
}
