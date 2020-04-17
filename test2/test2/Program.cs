using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*** Konvertierung in Zahlensysteme

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Dies ist ein Test", ConsoleColor.Blue);
            Console.WriteLine("ttttt");
            Menu();
            Console.ReadKey();
        }

        static void Titel(string titel, ConsoleColor textfarbe)
        {
            int breite = Console.WindowWidth;
            int textlen = titel.Length;
            ConsoleColor aktTextFarbe = Console.ForegroundColor; //Aktuelle DFarbe speichern
            Console.Clear();
            Console.ForegroundColor = textfarbe;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*"); 
            }
            for (int i = 0; i < (breite-textlen)/2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = aktTextFarbe;
        }
        /// <summary>
        /// Ausgabe eines Auswahlmenüs
        /// </summary>
        static void Menu()
        {
            Console.WriteLine("1) 10 -> 2");
            Console.WriteLine("2) 10 -> HEX");
            Console.WriteLine("1) 2 -> 10");
            Console.WriteLine("\n Bitte einen Menüpunkt auswählen");
        }
    }
}
