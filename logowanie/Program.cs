using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, haslo;

            Dictionary<string, string> daneLogowania = new Dictionary<string, string>()
            {
                ["Karol"] = "qwerty",
                ["Aga"] = "123456",
            };

            Console.Write("login: ");
            login = Console.ReadLine();
            Console.Write("haslo: ");
            haslo = Console.ReadLine();

            string hasloLog = daneLogowania[login];

            if (daneLogowania[login] == haslo)
            {
                Console.WriteLine("LOGOWANIE POPRAWNE \n");
                Console.WriteLine("1. Łączenie pięciu słów");
                Console.WriteLine("2. Średnia arytmetyczna");
                Console.Write("Wybierz co chcesz robić: ");

                int liczba = Convert.ToInt32(Console.ReadLine());

                switch (liczba)
                {
                    case 1:
                        Console.WriteLine("ŁĄCZENIE SŁÓW");
                        List<string> listaStringow = new List<string>();
                        Console.Write("Podaj pierwsze słowo: ");
                        listaStringow.Add(Console.ReadLine());
                        Console.Write("Podaj drugie słowo: ");
                        listaStringow.Add(Console.ReadLine());
                        Console.Write("Podaj trzecie słowo: ");
                        listaStringow.Add(Console.ReadLine());
                        Console.Write("Podaj czwarte słowo: ");
                        listaStringow.Add(Console.ReadLine());
                        Console.Write("Podaj piąte słowo: ");
                        listaStringow.Add(Console.ReadLine());

                        string koncowy = "";
                        for(int i=0; i<listaStringow.Count; i++)
                        {
                            koncowy += listaStringow[i];
                        }
                        Console.WriteLine($"Połączone słowo to: { koncowy}");
                        break;

                    case 2:
                        Console.WriteLine("ŚREDNIA ARYTMETYCZNA");
                        int[] tablica = new int[5];
                        Console.Write("Podaj pierwszą liczbę: ");
                        tablica[0] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj drugą liczbę: ");
                        tablica[1] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj trzecią liczbę: ");
                        tablica[2] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj czwartą liczbę: ");
                        tablica[3] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Podaj piątą liczbę: ");
                        tablica[4] = Convert.ToInt32(Console.ReadLine());

                        int suma = 0;
                        for (int i=0; i<5; i++)
                        {
                            suma += tablica[i];
                        }
                        Console.WriteLine($"Średnia to: {(double)suma/tablica.Length}");

                        break;
                }

            }
            else
                Console.WriteLine("LOGOWANIE NIEPOPRAWNE");

            Console.ReadKey();
        }
    }
}
