using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[15];

        // Leitura dos 15 números
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros nas posições pares do vetor:");

        // Exibe apenas posições pares (índices 0, 2, 4, ...)
        for (int i = 0; i < vetor.Length; i += 2)
        {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }
    }
}
