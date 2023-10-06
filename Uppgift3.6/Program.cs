using System;
using System.Net.Http.Headers;

namespace Uppgift3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt förnamn och sedan ditt efternamn med ett mellanslag emellan");
            string svar = Console.ReadLine();

            byte mellanIndex = (byte)svar.IndexOf(' ');
            string förnamn = svar[..mellanIndex];
            string efternamn = svar[(mellanIndex+1)..];

            if (förnamn.CompareTo(efternamn) < 0)
            {
                Console.WriteLine($"Ditt förnamn {förnamn} kommer före ditt efternamn {efternamn} i alfabetisk ordning.");
            }
            else if (förnamn.CompareTo(efternamn) > 0)
            {
                Console.WriteLine($"Ditt efternamn {efternamn} kommer före ditt förnamn {förnamn} i alfabetisk ordning.");
            }
            else
            {
                Console.WriteLine("Du har samma förnamn och efternamn.");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}