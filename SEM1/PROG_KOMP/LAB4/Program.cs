using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1_prog_komp_lab4
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

            if (tydzien.ContainsKey(dzien))
                return tydzien[dzien];
            else
                return "nie ma takiego numeru";
        }

        static string DzienTygodnia(string dzien)
        {
            Dictionary<string, string> tydzien = new Dictionary<string, string>();
            tydzien.Add("pon", "Poniedzialek");
            tydzien.Add("wt", "Wtorek");
            tydzien.Add("sr", "Sroda");
            tydzien.Add("czw", "Czwartek");
            tydzien.Add("pt", "Piatek");
            tydzien.Add("sob", "Sobota");
            tydzien.Add("niedz", "Niedziela");

            if (tydzien.ContainsKey(dzien))
                return tydzien[dzien];
            else
                return "nie ma takiego skrotu";
        }

        static ulong Strong(ulong x)
        {
            if (x == 0)
                return 0;
            else if (x == 1)
                return 1;
            else
                return Strong(x - 1) * x;
        }

        public struct Student
        {
            public string Imie;
            public int NrIndeksu;
        }


        static void Main(string[] args)
        {
            ////ZADANIE 1

            //Console.Clear();

            //int dayAsNmbr;

            //Console.WriteLine("Podaj oznaczenie liczbowe lub skrot dnia tygodnia (1 - pon , 2 - wt, itd.):");
            //string userInput = Console.ReadLine();

            //if(int.TryParse(userInput, out dayAsNmbr) == false)
            //    Console.WriteLine($"Dzień tygodnia to: {DzienTygodnia(userInput)}");
            //else
            //    Console.WriteLine($"Dzień tygodnia to: {DzienTygodnia(dayAsNmbr)}");




            ////ZADANIE 2

            //Console.WriteLine(Strong(15));




            ////ZADANIE 3

            //ulong userInputU;

            //float userInputF1;
            //float userInputF2;


            //switch (args.Length)
            //{
            //    case 0:
            //        Console.WriteLine("Musisz podać jeden albo dwa argumenty");
            //        break;
            //    case 1:
            //        if (ulong.TryParse(args[0], out userInputU) == false)
            //            Console.WriteLine("Nieprawidłowy format. Następnym razem podaj liczbę naturalną");
            //        else
            //            Console.WriteLine(Strong(userInputU));
            //        break;
            //    case 2:
            //        bool arg1 = float.TryParse(args[0], out userInputF1);
            //        bool arg2 = float.TryParse(args[1], out userInputF2);

            //        if (arg1 == false && arg2 == false || userInputF2 == 0)
            //            Console.WriteLine("Na następny raz podaj dwie liczby, druga musi być różna od 0");
            //        else
            //            Console.WriteLine(userInputF1/userInputF2);
            //        break;
            //    default:
            //    Console.WriteLine("Musisz podać jeden albo dwa argumenty");
            //    break;
            //}




            ////ZADANIE 4

            //Student P;
            //P.Imie = "Pawel";
            //P.NrIndeksu = 57641;

            //Console.WriteLine($"({P.Imie}, {P.NrIndeksu})");

        }

    }
}
