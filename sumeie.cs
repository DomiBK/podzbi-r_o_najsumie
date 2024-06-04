using System;

class Program
{
    static void Main(string[] args)
    {
        // Krok 1: Tworzenie tablicy 20-elementowej i wypełnianie jej pseudolosowymi liczbami całkowitymi od -99 do 99
        Random rand = new Random();
        int[] T = new int[20];
        for (int i = 0; i < 20; i++)
        {
            T[i] = rand.Next(-99, 100); // Generowanie liczb od -99 do 99
        }

        // Krok 2: Implementacja algorytmu znajdowania największej sumy podciągu
        int ms = Int32.MinValue; // Najmniejsza liczba w C#
        int ip = 0, ik = 0; // Indeksy startu i końca podciągu o największej sumie

        for (int i = 0; i < T.Length; i++)
        {
            int bs = 0; // Bieżąca suma częściowa
            for (int j = i; j < T.Length; j++)
            {
                bs += T[j]; // Obliczanie sumy częściowej
                if (bs > ms)
                {
                    ms = bs; // Aktualizacja największej sumy
                    ip = i; // Zapamiętywanie indeksu startu podciągu
                    ik = j; // Zapamiętywanie indeksu końca podciągu
                }
            }
        }

        // Krok 3: Wyświetlanie wyników
        Console.WriteLine("Największa suma podciągu: " + ms);
        Console.WriteLine("Pozycja podciągu w tablicy: od " + ip + " do " + ik);

        // Dodatkowo wyświetlamy podciąg o największej sumie
        Console.WriteLine("Podciąg o największej sumie:");
        for (int i = ip; i <= ik; i++)
        {
            Console.Write(T[i] + " ");
        }
        Console.WriteLine();
    }
}
