using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a sequência de DNA (até 50 bases - A, T, C, G): ");
        string dna = Console.ReadLine().ToUpper();

        if (dna.Length > 50)
        {
            Console.WriteLine("Erro: a sequência não pode ter mais de 50 bases.");
            return;
        }

        char[] complementar = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complementar[i] = 'T';
                    break;
                case 'T':
                    complementar[i] = 'A';
                    break;
                case 'C':
                    complementar[i] = 'G';
                    break;
                case 'G':
                    complementar[i] = 'C';
                    break;
                default:
                    Console.WriteLine($"Caractere inválido na posição {i + 1}: {dna[i]}");
                    return;
            }
        }

        Console.WriteLine("Sequência original:     " + dna);
        Console.WriteLine("Sequência complementar: " + new string(complementar));
    }
}
