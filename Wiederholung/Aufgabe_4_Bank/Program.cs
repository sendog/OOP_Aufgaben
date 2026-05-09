namespace Aufgabe_4__Bank__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde[] kunden = new Kunde[10];
            Konto[] konten = new Konto[10];
            int kundeAnzahl = 0;
            int kontoAnzahl = 0;

            // Kunde/Konto anlegen
            kunden[kundeAnzahl++] = new Kunde("LeBron James", "30.12.1984", 1);
            kunden[kundeAnzahl++] = new Kunde("Michael Jordan", "17.02.1963", 2);

            konten[kontoAnzahl++] = new Konto(1001, 1000, kunden[0]);
            konten[kontoAnzahl++] = new Konto(1002, 250, kunden[1]);

            // Limit
            Konto.SetLimit(-200);

            // Kunde/Konto ausgeben
            Console.WriteLine("--- Alle Kunden ---");
            for (int i = 0; i < kundeAnzahl; i++) { Console.WriteLine(kunden[i]); }

            Console.WriteLine("\n--- Alle Konten ---");
            for (int i = 0; i < kontoAnzahl; i++) { Console.WriteLine(konten[i]); }

            // Suche nach Kunde & Konto
            int suchKunde = 1;
            Console.WriteLine($"\n--- Suche KundenNr. {suchKunde} ---");
            foreach (var kunde in kunden)
            {
                if (kunde != null && kunde.GetKundenNummer() == suchKunde)
                {
                    Console.WriteLine(kunde);
                }
            }
            int suchKonto = 1002;
            Console.WriteLine($"\n--- Suche nach KontoNr. {suchKonto} ---");
            foreach (var konto in konten)
            {
                if (konto != null && konto.GetKontoNummer() == suchKonto)
                {
                    Console.WriteLine(konto);
                }
            }

            // Summe
            decimal summe = 0;
            foreach (var konto in konten)
            {
                if (konto != null) summe += konto.GetGuthaben();
            }
            Console.WriteLine($"\nGesamtsumme: \nSumme aller Konten: {summe:F2} Euro");

            // Abheben 
            Console.WriteLine("\n--- Abheben ---");
            konten[0].Abheben(500);
            konten[1].Abheben(500);
        }

        class Kunde
        {
            private string name;
            private string geburtstag;
            private int kundenNummer;

            public Kunde(string name, string geburtstag, int kundenNummer)
            {
                this.name = name;
                this.geburtstag = geburtstag;
                this.kundenNummer = kundenNummer;
            }

            public string GetName() { return name; }
            public int GetKundenNummer() { return kundenNummer; }

            public override string ToString()
            {
                return $"Kunde Nr. {kundenNummer}: {name} ({geburtstag})";
            }
        }

        class Konto
        {
            private int kontoNummer;
            private decimal guthaben;
            private Kunde kunde;

            private static decimal überziehungsLimit = 0;

            public Konto(int kontoNummer, decimal guthaben, Kunde kunde)
            {
                this.kontoNummer = kontoNummer;
                this.guthaben = guthaben;
                this.kunde = kunde;
            }

            public static void SetLimit(decimal limit) { überziehungsLimit = limit; }

            public int GetKontoNummer() { return kontoNummer; }
            public decimal GetGuthaben() { return guthaben; }

            public void Einzahlen(decimal betrag) { guthaben += betrag; }
            public void Abheben(decimal betrag)
            {
                if (guthaben - betrag < überziehungsLimit)
                {
                    decimal differenz = Math.Abs((guthaben - betrag) - überziehungsLimit);
                    Console.WriteLine($"Es fehlen {differenz:F2} Euro für das Limit von {überziehungsLimit:F2} Euro");
                }
                else
                {
                    guthaben -= betrag;
                    Console.WriteLine($"Es wurden {betrag:F2} Euro abgehoben. Neues Guthaben: {guthaben:F2} Euro");
                }
            }

            public override string ToString()
            {
                return $"Konto Nr. {kontoNummer}: (Inhaber {kunde.GetName()}): {guthaben:F2} Euro";
            }
        }
    }
}
