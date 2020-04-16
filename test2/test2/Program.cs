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
            Titel("Dies ist ein Test");
            Console.ReadKey();
        }

        static void Titel(string titel)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
    }
}
