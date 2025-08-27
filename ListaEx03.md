using System;

class Program
{
    static double EncontrarMenor(double[] vetor)
    {
        double menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }

    static void Main()
    {
        double[] numeros = { 7.9, -5.9, 0.0, -8.3, 9.9 };

        Console.WriteLine("Vetor:");
        foreach (double num in numeros)
        {
            Console.Write(num + " ");
        }

        double menorElemento = EncontrarMenor(numeros);
        Console.WriteLine($"\n\nMenor elemento do vetor: {menorElemento}");
    }
}
