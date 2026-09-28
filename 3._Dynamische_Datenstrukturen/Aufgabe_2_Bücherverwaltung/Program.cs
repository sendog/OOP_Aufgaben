using System;
using System.Text;

namespace Aufgabe_2__Bücherverwaltung__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buecherverwaltung buecher = new Buecherverwaltung();

            buecher.Add(new Buch("A Game of Thrones", "George R. R. Martin", 694));
            buecher.Add(new Buch("A Clash of Kings", "George R. R. Martin", 928));
            buecher.Add(new Buch("A Storm of Swords", "George R. R. Martin", 973));
            buecher.Add(new Buch("Harry Potter und der Stein der Weisen", "J.K. Rowling", 336));
            buecher.Add(new Buch("Harry Potter und die Kammer des Schreckens", "J.K. Rowling", 352));
            buecher.Add(new Buch("Red Rising", "Pierce Brown", 576));
            buecher.Add(new Buch("Golden Son", "Pierce Brown", 464));

            Console.WriteLine("--- Alle Bücher ---");
            buecher.PrintAll();

            Console.WriteLine("\n--- Suche nach Büchern von George R. R. Martin ---");
            buecher.PrintByAutor("George R. R. Martin");

            Console.WriteLine("\n--- Test des Indexers für Pierce Brown ---");
            Buch[] autorBuecher = buecher["Pierce Brown"];
            foreach (var b in autorBuecher)
            {
                Console.WriteLine($"{b.Titel}");
            }

            Console.WriteLine("\n--- Entferne alle Bücher von J.K. Rowling ---");
            buecher.RemoveByAutor("J.K. Rowling");
            Console.WriteLine("Erfolgreich entfernt");

            Console.WriteLine("\n--- Alle Bücher ---");
            buecher.PrintAll();
        }

        public class Buch
        {
            private readonly string titel;
            private readonly string autor;
            private readonly int seitenzahl;

            public Buch(string titel, string autor, int seitenzahl)
            {
                this.titel = titel;
                this.autor = autor;
                this.seitenzahl = seitenzahl;
            }

            public string Titel { get { return titel; } }
            public string Autor { get { return autor; } }
            public int Seitenzahl { get { return seitenzahl; } }

            public override string ToString()
            {
                return $"Titel: {titel}, Autor: {autor}, Seiten: {seitenzahl}";
            }
        }

        public class Buecherverwaltung
        {
            private Buch[] buecher;
            private int buchAnzahl = 0;

            public Buecherverwaltung()
            {
                buecher = new Buch[2];
            }

            public void Add(Buch neuesBuch)
            {
                if (buchAnzahl >= buecher.Length)
                {
                    Array.Resize(ref buecher, buecher.Length * 2);
                }
                buecher[buchAnzahl++] = neuesBuch;
            }

            public void PrintAll()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < buchAnzahl; i++)
                {
                    sb.Append(buecher[i].ToString()).Append("\n");
                }
                Console.WriteLine(sb.ToString());
            }

            public void PrintByAutor(string autor)
            {
                for (int i = 0; i < buchAnzahl; i++)
                {
                    if (buecher[i].Autor == autor)
                    {
                        Console.WriteLine(buecher[i]);
                    }
                }
            }

            public void RemoveByAutor(string autor)
            {
                for (int i = 0; i < buchAnzahl; i++)
                {
                    if (buecher[i].Autor == autor)
                    {
                        for (int j = i; j < buchAnzahl - 1; j++)
                        {
                            buecher[j] = buecher[j + 1];
                        }
                        buecher[--buchAnzahl] = null;
                        i--;
                    }
                }
            }

            public Buch[] this[string autor]
            {
                get
                {
                    int count = 0; // zählen wie viele bücher ein autor hat
                    for (int i = 0; i < buchAnzahl; i++)
                    {
                        if (buecher[i].Autor == autor) count++;
                    }

                    Buch[] result = new Buch[count]; // neues array nur mit anzahl der bücher vom autor
                    int current = 0;
                    for (int i = 0; i < buchAnzahl; i++)
                    {
                        if (buecher[i].Autor == autor)
                        {
                            result[current++] = buecher[i];
                        }
                    }
                    return result;
                }
            }
        }

    }
}
