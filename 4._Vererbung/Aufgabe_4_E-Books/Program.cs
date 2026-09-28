using System.Collections.Generic;

namespace Aufgabe_4__E_Books__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // autor, titel, erscheinungsjahr
            EBook buch = new EBook("Test", "Testbuch", 2010);

            // dateiname, größeinbyte, sprache, anzahl zeichen
            TextAsset text1 = new TextAsset("text1.txt", 4500, "de", 5000); // 2.5 Seiten
            TextAsset text2 = new TextAsset("text2.txt", 2800, "de", 3000); // 1.5 Seiten

            //dateiname, größeinbyte, sprache, breite, höhe
            BildAsset grafik = new BildAsset("grafik.png", 51200, "de", 1920, 1080); // 0.5 Seiten

            //dateiname, größeinbyte, sprache, spieldauer
            AudioAsset audio = new AudioAsset("audio.mp3", 5000000, "de", 300); // 0.0 Seiten (audio)

            //dateiname, größeinbyte, sprache, breite, höhe, spieldauer
            VideoAsset video = new VideoAsset("video.mp4", 25000000, "de", 960, 800, 60); // 1.0 Seite

            buch.AddAsset(text1);
            buch.AddAsset(text2);
            buch.AddAsset(grafik);
            buch.AddAsset(audio);
            buch.AddAsset(video);

            Console.WriteLine($"E-Book: {buch.Titel}");
            Console.WriteLine($"Autor: {buch.Autor} ({buch.Erscheinungsjahr})");

            double gesamtSeiten = buch.BerechneSeitenzahl();

            Console.WriteLine($"\nGesamt: {gesamtSeiten} Seiten"); // gesamt: 5.5 Seiten
        }
    }

    class EBook
    {
        public string Autor { get; set; }
        public string Titel { get; set; }
        public int Erscheinungsjahr { get; set; }
        public List<MediaAsset> Assets { get; }

        public EBook(string autor, string titel, int erscheinungsjahr)
        {
            Autor = autor;
            Titel = titel;
            Erscheinungsjahr = erscheinungsjahr;
            Assets = new List<MediaAsset>();
        }

        public void AddAsset(MediaAsset asset)
        {
            Assets.Add(asset);
        }

        public double BerechneSeitenzahl()
        {
            double gesamtSeiten = 0.0;

            foreach (MediaAsset a in Assets)
            {
                gesamtSeiten += a.GetSeitenBeitrag(); // erkennt direkt unterschiedliche assets und summiert/addiert seiten
            }

            return gesamtSeiten;
        }
    }

    abstract class MediaAsset // mainklasse/vorlage (davon wird geerbt)
    {
        public string Dateiname { get; set; }
        public int GroesseInByte { get; set; }
        public string Sprache { get; set; }

        public MediaAsset(string dateiname, int groesseInByte, string sprache)
        {
            Dateiname = dateiname;
            GroesseInByte = groesseInByte;
            Sprache = sprache;
        }

        public abstract double GetSeitenBeitrag(); // jede unterklasse muss selbst seiten berechnen
    }

    class TextAsset : MediaAsset
    {
        public int AnzahlZeichen { get; set; }

        public TextAsset(string dateiname, int groesseInByte, string sprache, int anzahlZeichen) : base(dateiname, groesseInByte, sprache)
        {
            AnzahlZeichen = anzahlZeichen;
        }

        public override double GetSeitenBeitrag()
        {
            return AnzahlZeichen / 2000.0;
        }
    }

    class BildAsset : MediaAsset
    {
        public int Breite { get; set; }
        public int Hoehe { get; set; }

        public BildAsset(string dateiname, int groesseInByte, string sprache, int breite, int hoehe) : base(dateiname, groesseInByte, sprache)
        {
            Breite = breite;
            Hoehe = hoehe;
        }

        public override double GetSeitenBeitrag()
        {
            double skalierteHoehe = Hoehe * (960.0 / Breite); // 960/breite=skalierung zb.: 960/1920=0,5

            if (skalierteHoehe > 600.0)
            {
                return 1.0; // ganze seite
            }
            else
            {
                return 0.5; // halbe seite
            }
        }
    }

    class AudioAsset : MediaAsset
    {
        public int SpieldauerInSekunden { get; set; }

        public AudioAsset(string dateiname, int groesseInByte, string sprache, int spieldauerInSekunden) : base(dateiname, groesseInByte, sprache)
        {
            SpieldauerInSekunden = spieldauerInSekunden;
        }

        public override double GetSeitenBeitrag()
        {
            return 0.0; // audio(keine seite)
        }
    }

    class VideoAsset : MediaAsset
    {
        public int Breite { get; set; }
        public int Hoehe { get; set; }
        public int SpieldauerInSekunden { get; set; }

        public VideoAsset(string dateiname, int groesseInByte, string sprache, int breite, int hoehe, int spieldauerInSekunden) : base(dateiname, groesseInByte, sprache)
        {
            Breite = breite;
            Hoehe = hoehe;
            SpieldauerInSekunden = spieldauerInSekunden;
        }

        public override double GetSeitenBeitrag()
        {
            double skalierteHoehe = Hoehe * (960.0 / Breite);

            if (skalierteHoehe > 600.0)
            {
                return 1.0; // ganze seite
            }
            else
            {
                return 0.5; // halbe seite
            }
        }
    }

}
