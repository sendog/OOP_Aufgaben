namespace Aufgabe_3__Artikel__40_Punkte__neu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikel[] artikelArr = new Artikel[10];

            artikelArr[0] = new Artikel("Banane", 1, 2.50, Lebensmittelgruppe.Obst);
            artikelArr[1] = new Artikel("Steak", 2, 8.00, Lebensmittelgruppe.Fleisch);
            artikelArr[2] = new Artikel("Schokolade", 3, 1.80); // Default enum -> Süßwaren

            int auswahl = -1;

            while (auswahl != 4)
            {
                Console.WriteLine("\nWas wünschen Sie zu tun?");
                Console.WriteLine("0 = Anlegen\n1 = Ändern\n2 = Ausgabe\n3 = Teuerster Artikel\n4 = Ende");
                Console.Write("\nIhre Auswahl: ");

                auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl) 
                {
                    case 0: // Anlegen
                        for (int i = 0; i < artikelArr.Length; i++)
                        {
                            if (artikelArr[i] == null)
                            {
                                artikelArr[i] = new Artikel();
                                break;
                            }
                        }
                        break;

                    case 1: // Ändern/Suchen
                        Console.WriteLine("Bezeichnung des Artikels eingeben? ");
                        string suche = Console.ReadLine();
                        foreach (Artikel artikel in artikelArr)
                        {
                            if (artikel != null && artikel.GetBezeichnung() == suche)
                            {
                                Console.Write("Neue Bezeichnung: ");
                                artikel.SetBezeichnung(Console.ReadLine());
                                Console.Write("Neuer Preis: ");
                                artikel.SetPreis(Convert.ToDouble(Console.ReadLine()));
                                break;
                            }
                        }
                        break;

                    case 2: // Ausgabe
                        foreach (Artikel artikel in artikelArr)
                        {
                            if (artikel != null) Console.WriteLine(artikel);
                        }
                        break;

                    case 3: // Teuerste Artikel
                        double max = -1;
                        string maxName = "";
                        foreach (Artikel artikel in artikelArr)
                        {
                            if (artikel != null && artikel.GetPreis() > max)
                            {
                                max = artikel.GetPreis();
                                maxName = artikel.GetBezeichnung();
                            }
                        }
                        Console.WriteLine($"Teuerster Artikel: {maxName}");
                        break;

                    case 4: // Ende
                        break;

                    default: // Wenn falsch eingegeben wird
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0-4 ein.");
                        break;
                }
            }
        }

        enum Lebensmittelgruppe { Obst = 1, Gemüse  = 2, Fleisch = 3, Süßwaren = 4 }

        class Artikel
        {
            private string artikelbezeichnung;
            private int artikelnummer;
            private double verkaufspreis;
            private Lebensmittelgruppe gruppe;

            public Artikel()
            {
                Console.Write("Bezeichnung: ");
                this.artikelbezeichnung = Console.ReadLine();

                Console.Write("Lebensmittelgruppe (1=Obst, 2=Gemüse, 3=Fleisch, 4=Süßwaren): ");
                this.gruppe = (Lebensmittelgruppe)Convert.ToInt32(Console.ReadLine());

                Console.Write("Artikelnummer: ");
                this.artikelnummer = Convert.ToInt32(Console.ReadLine());

                Console.Write("Preis: ");
                this.verkaufspreis = Convert.ToDouble(Console.ReadLine());
            }

            public Artikel(string artikelbezeichnung, int artikelnummer, double verkaufspreis, Lebensmittelgruppe gruppe = Lebensmittelgruppe.Süßwaren)
            {
                this.artikelbezeichnung = artikelbezeichnung;
                this.artikelnummer = artikelnummer;
                this.verkaufspreis = verkaufspreis;
                this.gruppe = gruppe;
            }

            public override string ToString()
            {
                return $"{artikelbezeichnung}: {artikelnummer}, {verkaufspreis:F2} ({gruppe})";
            }

            public double GetPreis() { return verkaufspreis; }
            public void SetPreis(double preis) { this.verkaufspreis = preis; }
            public string GetBezeichnung() { return artikelbezeichnung; }
            public void SetBezeichnung(string bezeichnung) { this.artikelbezeichnung = bezeichnung; }
        }
    }
}
