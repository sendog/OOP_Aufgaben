using System.Drawing;

namespace Aufgabe_2__Time__TimeSpan__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(9, 45);
            Time t2 = t1 + "1:30" + 15; // "11:30"
            Time t3 = "11:30";
            TimeSpan tDiff = t2 - t1;
            Console.WriteLine($"t1: {t1}"); // out: t1: 9:45 Uhr
            Console.WriteLine($"t2: {t2}"); // out: t2: 11:30 Uhr
            Console.WriteLine($"tDiff: {tDiff}"); // out: tDiff: 1h45min
            Console.WriteLine($"tDiff in Min: {tDiff.TotalMins}");
            // out: tDiff in Min: 105
            if (t2) // out: Guten Morgen
                Console.WriteLine("Guten Morgen");
            else
                Console.WriteLine("Guten Tag");
            if (t2 == t3) // out: Die Uhrzeiten sind gleich!
                Console.WriteLine("Die Uhrzeiten sind gleich!");
            else
                Console.WriteLine("Die Uhrzeiten stimmen nicht überein!");
        }

        public class Time
        {
            private int minuten;

            public Time(int hours, int minutes)
            {
                this.minuten = (hours * 60) + minutes;

            }

            private Time(int minutes)
            {
                this.minuten = minutes;
            }

            public static implicit operator Time(string s) // teilt den string durch die mitte -> : links(0) = stunden, rechts(1) = minuten
            {
                string[] teile = s.Split(':');
                return new Time(int.Parse(teile[0]), int.Parse(teile[1])); // siehe zeile 30
            }

            public static implicit operator Time(int k) // übernimmt int und wandelt in die klasse Time um (minuten)
            {
                return new Time(k); // siehe zeile 36
            }

            public static bool operator true(Time t) { return t.minuten < 720; } // vor 12 uhr
            public static bool operator false(Time t) { return t.minuten >= 720; } // 12 uhr und nach 12 uhr
            public static Time operator +(Time t1, Time t2) { return new Time(t1.minuten + t2.minuten); }
            public static TimeSpan operator -(Time t1, Time t2) {  return new TimeSpan(t1.minuten - t2.minuten); }
            public static bool operator ==(Time t1, Time t2) {  return t1.minuten == t2.minuten; }
            public static bool operator !=(Time t1, Time t2) { return !(t1 == t2); }

            public override string ToString()
            {
                int h = minuten / 60;
                int m = minuten % 60;
                return $"{h}:{m} Uhr";
            }
        }

        public class TimeSpan
        {
            private int minuten;

            public TimeSpan(int minutes)
            {
                this.minuten = minutes;
            }

            public int TotalMins { get { return minuten; } }

            public override string ToString()
            {
                int h = minuten / 60;
                int m = minuten % 60;
                return $"{h}h{m}min";
            }
        }
    }
}
