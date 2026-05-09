using System.Reflection;

namespace Aufgabe_4__Printer__20_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erzeugen eines #-Druckers:
            Printer printer1 = new Printer('#');
            // Drucken eines #-Zeichens:
            printer1++;
            Console.WriteLine("1. " + (string)printer1);
            // Drucken von 3 weiteren #-Zeichen:
            printer1 += 3;
            Console.WriteLine("2. " + (string)printer1);

            // Wechseln des Druck-Zeichens (von '#' zu 'X'):
            printer1 = printer1 << 'X';
            // Drucken von 2 weiteren X-Zeichen:
            printer1 = printer1 + 2;
            Console.WriteLine("3. " + (string)printer1);

            // Erzeugen eines O-Druckers und Drucken von 5 Zeichen:
            Printer printer2 = new Printer('O') + 5;
            Console.WriteLine("4. " + (string)printer2);

            // Vergleich der gedruckten Zeichen:
            if (printer1 > printer2)
                Console.WriteLine("5. 1. Drucker hat mehr Zeichen gedruckt.");
            else
                Console.WriteLine("5. 2. Drucker hat mehr Zeichen gedruckt.");
        }

        public class Printer
        {
            private char printChar; // char wird zum drucken verwendet
            private string output = ""; // für ausgabe vom string

            public Printer(char printChar) { this.printChar = printChar; } // konstruktor

            private void PrintOneCharacter() { output += printChar; }

            public static Printer operator ++(Printer p) 
            { 
                p.PrintOneCharacter(); 
                return p; 
            }
            public static explicit operator string (Printer p) { return p.output; } // objekt wird zu string
            public static Printer operator +(Printer p, int anzahl)
            {
                for (int i = 0; i < anzahl; i++)
                {
                    p.PrintOneCharacter();
                }
                return p;
            }
            public static Printer operator <<(Printer p, char zeichen) // printChar wechseln (# -> X als bsp in Main)
            {
                p.printChar = zeichen;
                return p;
            }
            public static bool operator >(Printer p1, Printer p2) { return p1.output.Length > p2.output.Length; }
            public static bool operator <(Printer p1, Printer p2) { return p1.output.Length < p2.output.Length; }
        }
    }
}
