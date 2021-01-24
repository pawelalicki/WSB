using System;
using System.Collections.Generic;

namespace LAB5_ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();

            todoList.Add("zjesc sniadanie");
            todoList.Add("zjesc obiad");
            todoList.Add("zjesc kolacje");

            int userCommand;
            string todoItemText;
            int todoItemPosition;

            string userInput;

            Console.WriteLine("\n----------------------\n AKTUALNA LISTA ZADAŃ");
            foreach (string zad in todoList)
            {
                Console.WriteLine(zad);
            }
            Console.WriteLine("----------------------\n");

            do
            {
                Console.WriteLine("Podaj komendę: \n 1 - dodaj zadanie \n 0 - usuń zadanie");
                userInput = Console.ReadLine();

                while (int.TryParse(userInput, out userCommand) == false && (userCommand != 1 || userCommand != 0))
                {
                    Console.WriteLine("Podaj komendę: \n 1 - dodaj zadanie \n 0 - usuń zadanie");           // pytamy, co mamy zrobić
                    userInput = Console.ReadLine();
                }


                if (userCommand == 1)                // opcja 1 - spytaj o zadanie i miejsce gdzie je dodac (zadbaj o sprawdzenie dlugosci listy!)
                {
                    Console.WriteLine("Podaj zadanie do wykonania: ");
                    todoItemText = Console.ReadLine();

                    Console.WriteLine("Podaj miejsce na liscie zadan dla nowego zadania: ");
                    userInput = Console.ReadLine();
                    while (int.TryParse(userInput, out todoItemPosition) == false || todoItemPosition > todoList.Count || todoItemPosition < 0)     //sprawdzenie, czy pozycja na liście ok
                    {
                        Console.WriteLine($"Musisz podać liczbę z przedziału 0 do {todoList.Count}");
                        userInput = Console.ReadLine();
                    }

                    // dodawanie elementu

                    todoList.Insert(todoItemPosition, todoItemText);

                }
                else if(userCommand == 0)             // opcja 0 - spytaj o zadanie - usun to zadanie (nie pytaj jesli nie ma co usuwac!)
                {
                    if (todoList.Count == 0)
                    {
                        Console.WriteLine("nie ma pozycji do usunięcia, dodaj najpierw jakies zadanie");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Podaj miejsce na liscie zadania do usunięcia:");
                    userInput = Console.ReadLine();
                    while (int.TryParse(userInput, out todoItemPosition) == false || todoItemPosition > todoList.Count || todoItemPosition < 0)     //sprawdzenie, czy pozycja na liście ok
                    {
                        Console.WriteLine($"Musisz podać liczbę z przedziału 0 do {todoList.Count - 1}");
                        userInput = Console.ReadLine();
                    }
                        
                    todoList.RemoveAt(todoItemPosition);        //usunięcie elementu
                    }
                    
                }


                // wyświetl zadania
                Console.WriteLine("\n----------------------\n AKTUALNA LISTA ZADAŃ");
                foreach (string zad in todoList)
                {
                    Console.WriteLine(zad);
                }
                Console.WriteLine("----------------------\n");

            } while (true);


        }
    }
}
