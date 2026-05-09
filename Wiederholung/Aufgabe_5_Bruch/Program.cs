using System.Numerics;

namespace Aufgabe_5__Bruch__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch(1, 2);
            Bruch b2 = new Bruch(1, 2);

            b1.Addiere(b2);
            b1.Kürze();

            Bruch b3 = new Bruch(1, 1);
            int ergebnis = b1.VergleicheMit(b3);

            Console.WriteLine($"-1 = 1. Bruch ist kleiner \n0 = beide Brüche gleich groß \n1 = 1. Bruch ist größer \nErgebnis: {ergebnis}");
        }


        class Bruch
        {
            private long zähler;
            private long nenner;

            public Bruch(long zähler, long nenner)
            {
                this.zähler = zähler;
                this.nenner = nenner;
            }

            public void Addiere(Bruch that)
            {
                long neuZähler = (this.zähler * that.nenner) + (that.zähler * this.nenner);
                long neuNenner = this.nenner * that.nenner;

                this.zähler = neuZähler;
                this.nenner = neuNenner;
            }

            public void Kürze()
            {
                BigInteger ggt = BigInteger.GreatestCommonDivisor(this.zähler, this.nenner);
                this.zähler /= (long)ggt;
                this.nenner /= (long)ggt;
            }

            public int VergleicheMit(Bruch that)
            {
                long wert1 = this.zähler * that.nenner;
                long wert2 = that.zähler * this.nenner;

                if (wert1 < wert2)
                {
                    return -1;
                }
                else if (wert1 > wert2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
