using System;

namespace s1_prog_komp_lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Zadanie 1
            /*
            Console.Clear();

            Console.WriteLine("Podaj liczbę naturalną: \n");
            string userInput = Console.ReadLine();

            int liczba;

            while(int.TryParse(userInput, out liczba) == false)
                {
                Console.WriteLine("Nieprawwidłowy format. Podaj liczbę naturalną: \n");
                userInput = Console.ReadLine();
                }

            liczba = int.Parse(userInput);

            string wynik = "_";

            int dzielenie = liczba % 3;

            if (dzielenie == 0)
                {
                wynik += "A";
                liczba /= 3;

                dzielenie = liczba % 5;

                if (dzielenie == 0)
                    {
                    wynik += "B";
                    } 
                }
            else
                {
                dzielenie = liczba % 5;

                if (dzielenie == 0)
                        wynik += "B";
                }

            Console.WriteLine($"wynik: {wynik}");

            */
            // Zadanie 2
            /*

            Console.Clear();

            string tablica = "";

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    tablica += $"{i * j}\t";
                }
                tablica += "\n";
            }

            Console.WriteLine(tablica);

            */
            // Zadanie 3
            /*

            Console.Clear();

            Console.WriteLine("Podaj swoje imię: \n");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("\nPodaj swoje nazwisko: \n");
            string userSecondName = Console.ReadLine();

            Console.WriteLine("\nPodaj swój wiek (w latach): \n");
            int userAge;
            string userInput;

            do
            {
                userInput = Console.ReadLine();
            }
            while (int.TryParse(userInput, out userAge) == false );

            //int.TryParse(userInput, out userAge);

            Console.Write($"\nTwoje dane:\n {userFirstName} {userSecondName}, lat {userAge}");


            */
            // Zadanie 4
            /*

            Console.Clear();

            float wynik = (float)Math.Abs(-(((2 * 2) + 3) / (Math.Sqrt(225) - Math.Pow(3, 2))));

            Console.WriteLine($"Wynik dokładny: {wynik}\nwynik zaokrąglony: {Math.Round(wynik,2)}");

            */
            // Zadanie 5
            /*
            
            Console.Clear();

            for (int i=1; ; i++)
            {
                if (i > 50)
                    break;
                if (i % 6 != 0)
                    continue;
                else
                    Console.WriteLine($"{i}\t");
            }

            */

        }
    }
}
