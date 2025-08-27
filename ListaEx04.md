using System;

class Program
{
    static double EncontrarMaior(double[] vetor)
    {
        double maior = vetor[0];

        for (int i = 1; i > vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }

        return maior;
    }

    static void Main()
    {
        double[] numeros = { 7.9, -5.9, 0.0, -8.3, 9.9 };

        Console.WriteLine("Vetor:");
        foreach (double num in numeros)
        {
            Console.Write(num + " ");
        }

        double maiorElemento = EncontrarMaior(numeros);
        Console.WriteLine($"\n\nMaior elemento do vetor: {maiorElemento}");
    }
}
