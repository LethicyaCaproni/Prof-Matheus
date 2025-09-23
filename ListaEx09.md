using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine();

        // Transforma em vetor de caracteres
        char[] vetor = entrada.ToCharArray();

        Console.WriteLine($"\nQuantidade de caracteres: {vetor.Length}");

        Console.Write("\nVetor em ordem inversa: ");
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i]);
        }

        Console.WriteLine(); // quebra de linha
    }
}
