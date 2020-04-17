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
            Titel("TITEL DER ANWENDUNG", ConsoleColor.Blue);
            Console.WriteLine("ttttt");
            string Binzahl = BinaerzahlEinlesen();
            
            Console.ReadKey();
        }
        /// <summary>
        /// Gibt einen Text formatiert als Titel aus
        /// </summary>
        /// <param name="titel">Text der ausgegeben werden soll</param>
        /// <param name="textfarbe">ConsoleColor Textfarbe des Titels</param>
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
        /// Einlesen einer Binärzahl
        /// </summary>
        /// <returns>String mit nur Nullen und Einsen</returns>
        static string BinaerzahlEinlesen()
        {
            Console.WriteLine("Bitte Binärzahl eingeben (0/1): ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
