using System;

class ExDNA
{

    static bool existeStopCodon(string dna)
    {
        dna = dna.ToUpper();
        for (int i = 0; i < dna.Length - 2; i++)
        {
            if (dna[i] == 'T' && dna[i + 1] == 'A' && dna[i + 2] == 'A')
            return true;
        }
        return false;
    }
    
    static void Main()
    {
        Console.WriteLine("Análise de DNA");
        Console.WriteLine("Entre com a sequencia de DNA:");
        string dna = Console.ReadLine();
            if (existeStopCodon(dna) == true)
                Console.WriteLine("A sequencia contém o stop codon 'TAA'");
            else
                Console.WriteLine("A sequencia não contém stop codon 'TAA'");
        Console.ReadKey();
    }
}
