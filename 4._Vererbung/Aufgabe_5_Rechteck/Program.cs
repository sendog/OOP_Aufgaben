namespace Aufgabe_5__Rechteck__20_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRectangle r1 = new Rectangle(5, 5);   // fläche: 25, quadrat
            IRectangle r2 = new Rectangle(4, 10);  // fläche: 40, kein quadrat

            Console.WriteLine("Test (variable):");
            Console.WriteLine($"=> Rechteck 1: Breite = {r1.GetWidth()}, Länge = {r1.GetLength()}");
            Console.WriteLine($"=> Rechteck 2: Breite = {r2.GetWidth()}, Länge = {r2.GetLength()}");

            Console.WriteLine("\nTest (IsSquare):");
            Console.WriteLine($"=> Ist Rechteck 1 ein Quadrat? {r1.IsSquare()}"); // true
            Console.WriteLine($"=> Ist Rechteck 2 ein Quadrat? {r2.IsSquare()}"); // false

            int vergleichsErgebnis = IRectangle.Compare(r1, r2);

            Console.WriteLine($"\nTest Vergleich r1 mit r2: {vergleichsErgebnis}"); // r1< r2 = -1

            if (vergleichsErgebnis == -1)
            {
                Console.WriteLine("=> Rechteck 1 ist kleiner als Rechteck 2.");
            }
            else if (vergleichsErgebnis == 1)
            {
                Console.WriteLine("=> Rechteck 1 ist größer als Rechteck 2.");
            }
            else
            {
                Console.WriteLine("=> Beide Rechtecke sind gleich groß.");
            }
        }
    }

    interface IRectangle // interface kann keine daten speichern (abstract?)
    {
        int GetWidth();
        int GetLength();

        public bool IsSquare()
        {
            return GetWidth() == GetLength();
        }

        public static int Compare(IRectangle a, IRectangle b)
        {
            int flaecheA = a.GetWidth() * a.GetLength();
            int flaecheB = b.GetWidth() * b.GetLength();

            if (flaecheA > flaecheB) { return 1; }
            else if (flaecheA < flaecheB) { return -1; }
            else { return 0; }
        }
    }

    class Rectangle : IRectangle // die klasse speichert daten
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public Rectangle (int width, int length)
        {
            Width = width;
            Length = length;
        }

        public int GetWidth() { return Width; }
        public int GetLength() { return Length; }
    }
}
