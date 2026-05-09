namespace Aufgabe_5__Library__20_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buch[] buecher = new Buch[]
            {
                new Buch("George R. R. Martin", "Das Lied von Eis und Feuer", 9783442267743),
                new Buch("Pierce Brown", "Red Rising", 9781444758993),
                new Buch("J.K. Rowling", "Harry Potter", 9783551551672)
            };
            Library Bibliothek = new Library(buecher);

            // suche autor
            Console.WriteLine("--- Suche nach Autor: Pierce Brown ---");
            Buch b1 = Bibliothek["Pierce Brown"];
            if (Bibliothek["Pierce Brown"] != null)
            {
                Console.WriteLine($"Gefunden: {b1.Titel} (ISBN: {b1.ISBN})");
            }
            else Console.WriteLine("Buch wurde nicht gefunden.");


            // suche isbn
            Console.WriteLine("\n--- Suche nach ISBN: 9783442267743 ---");
            long gesuchteIsbn = 9783442267743;
            Buch b2 = Bibliothek[gesuchteIsbn];
            if (b2 != null)
            {
                Console.WriteLine($"Gefunden: {b2.Titel} von {b2.Autor}");
            }
            else Console.WriteLine("Buch wurde nicht gefunden.");

            // buch nicht vorhanden test
            Console.WriteLine("\n--- Suche nach nicht existierendem Buch ---");
            Buch b3 = Bibliothek["Unbekannt"];
            if (b3 != null)
            {
                Console.WriteLine($"Gefunden: {b3.Titel} (ISBN: {b3.ISBN})");
            }
            else Console.WriteLine("Buch wurde nicht gefunden.");
        }

        public class Buch
        {
            public string Autor;
            public string Titel;
            public long ISBN;

            public Buch(string autor, string titel, long isbn)
            {
                this.Autor = autor;
                this.Titel = titel;
                this.ISBN = isbn;
            }
        }

        public class Library
        {
            private Buch[] buecher;

            public Library(Buch[] buecher)
            {
                this.buecher = buecher;
            }

            public Buch this[string autor] // indexer autor
            {
                get 
                {
                    foreach(var b in buecher)
                    {
                        if (b != null && b.Autor == autor) { return b; }
                    }
                    return null;
                }
            }

            public Buch this[long isbn] // indexer isbn
            {
                get
                {
                    foreach(var b in buecher)
                    {
                        if (b != null && b.ISBN == isbn) { return b; }
                    }
                    return null;
                }
            }
        }

    }
}
