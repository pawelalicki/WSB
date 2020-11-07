using System;
using System.Linq;

namespace s1_prog_komp_lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////ZADANIE 1

            //Console.Clear();
            //int[,] tabliczka = new int[10, 10];

            //for (int i = 0; i < tabliczka.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabliczka.GetLength(1); j++)
            //    {
            //        tabliczka[i, j] = (i + 1) * (j + 1);
            //    }

            //}

            //for (int i = 0; i < tabliczka.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabliczka.GetLength(1); j++)
            //    {
            //        Console.Write($"{tabliczka[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}


            //ZADANIE 2

            //Console.Clear();

            //Console.WriteLine("Podaj liczbę elemetów tablicy: \n");
            //string userInput = Console.ReadLine();

            //int ileElementow;

            //while (int.TryParse(userInput, out ileElementow) == false)
            //{
            //    Console.WriteLine("Nieprawidłowy format. Podaj liczbę naturalną: \n");
            //    userInput = Console.ReadLine();
            //}

            //ileElementow = int.Parse(userInput);


            //string[] tablica = new string[ileElementow];

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    Console.WriteLine($"\nPodaj element {i+1} tablicy: \n");
            //    tablica[i] = Console.ReadLine();
            //}


            //Console.WriteLine("\n\nElementy tablicy:");

            //foreach (string element in tablica)
            //    Console.Write($"{element}\t");

            //// ZADANIE 3

            //Console.Clear();

            //int[] tablica = new int[100];

            //Random rnd = new Random();

            //for (int i = 0; i < tablica.Length; i++)
            //    tablica[i] = rnd.Next(-1000, 1001);

            //foreach (int element in tablica)
            //    Console.Write($"{element} ");

            //Console.WriteLine($"\n\nNajmniejsza wartość: {tablica.Min()}, na pozycji {Array.IndexOf(tablica,tablica.Min())}");

            //Console.WriteLine($"\n\nNajwiększa wartość: {tablica.Max()}, na pozycji {Array.IndexOf(tablica, tablica.Max())}");


            //int[] tablica_sort = tablica;


            //Array.Sort(tablica_sort);

            //Console.WriteLine("\n\n");
            //foreach (int element in tablica_sort)
            //    Console.Write($"{element} ");


            //Array.Reverse(tablica_sort);

            //Console.WriteLine("\n\n");
            //foreach (int element in tablica_sort)
            //    Console.Write($"{element} ");


        }
    }
}
