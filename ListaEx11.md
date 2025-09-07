using System;

class Program
{
    static string decodifiicarFrase(string mensagem)
    {
        string resultado = "";
        int i = 0;

        while (i < mensagem.Length)
        {
            if (mensagem[i] == 'p' && i + 1 < mensagem.Length)
            {
                resultado += mensagem[i + 1];
                i += 2;
            }
            else
            {
                resultado += mensagem[i];
                i++;
            }
        }

        return resultado;
    }

    static void Main()
    {
        Console.WriteLine("Digite a mensagem codificada na língua do P:");
        string codificada = Console.ReadLine();

        string decodificada = decodifiicarFrase(codificada);

        Console.WriteLine("\nMensagem codificada: " + codificada);
        Console.WriteLine("Mensagem decodificada: " + decodificada);
    }
}
