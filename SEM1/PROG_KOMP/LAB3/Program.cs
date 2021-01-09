using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1_prog_komp_lab3
{
    class Program
    {
        static string DzienTygodnia(int dzien)
        {
            Dictionary<int, string> tydzien = new Dictionary<int, string>();
            tydzien.Add(1, "Poniedzialek");
            tydzien.Add(2, "Wtorek");
            tydzien.Add(3, "Sroda");
            tydzien.Add(4, "Czwartek");
            tydzien.Add(5, "Piatek");
            tydzien.Add(6, "Sobota");
            tydzien.Add(7, "Niedziela");

            return tydzien[dzien];
        }

        static void Dzielenie(ref float x, ref float y)
        {
            x = x / y;
        }

        static int Mnozenie(int x, int y = 1, int z = 1)
        {
            return x * y * z;
        }

        static void Main(string[] args)
        {

            ////ZADANIE 1

            //Console.WriteLine("Podaj oznaczenie liczbowe dnia tygodnia (1 - pon , 2 - wt, itd.):");
            //string userInput = Console.ReadLine();

            //int podanyDzien;

            //while (int.TryParse(userInput, out podanyDzien) == false || podanyDzien < 1 || podanyDzien > 7)
            //{
            //    Console.WriteLine("Nieprawidłowy format. Podaj liczbę od 1 do 7:");
            //    userInput = Console.ReadLine();
            //}

            //Console.WriteLine($"Dzień tygodnia to: {DzienTygodnia(podanyDzien)}");



            ////ZADANIE 2

            //Console.WriteLine("Podaj pierwszy element:");
            //string userInput = Console.ReadLine();

            //float pierwszyElement;

            //while (float.TryParse(userInput, out pierwszyElement) == false)
            //{
            //    Console.WriteLine("Nieprawidłowy format. Podaj liczbę:");
            //    userInput = Console.ReadLine();
            //}

            //pierwszyElement = float.Parse(userInput);

            //Console.WriteLine("Podaj drugi element:");
            //userInput = Console.ReadLine();

            //float drugiElement;

            //while (float.TryParse(userInput, out drugiElement) == false || drugiElement == 0)
            //{
            //    Console.WriteLine("Nieprawidłowy format. Podaj liczbę (różną od zera):");
            //    userInput = Console.ReadLine();
            //}

            //drugiElement = float.Parse(userInput);

            //Dzielenie(ref pierwszyElement, ref drugiElement);

            //Console.WriteLine($"\nkońcowy wynik: \n" +
            //    $"pierwszy element: {pierwszyElement}\n" +
            //    $"drugi element: {drugiElement}");


            ////ZADANIE 3

            //Console.WriteLine(Mnozenie(45));
            //Console.WriteLine(Mnozenie(12, 5));
            //Console.WriteLine(Mnozenie(4, 7, 8));


        }
    }
}
