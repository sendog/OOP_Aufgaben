using System.Collections;

namespace Aufgabe_6__Personengruppe__20_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personengruppe gruppe = new Personengruppe();

            Console.WriteLine("Test:");
            foreach (Person p in gruppe)
            {
                Console.WriteLine($"{p.Name}, {p.Alter} Jahre");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

    }

    class Personengruppe : IEnumerable // enumareble = interface (braucht enumerator?)
    {
        private Person[] personen; // kapselung? array darf nicht geändert werden

        public Personengruppe() // braucht IEnumerable für foreach schleife
        {
            personen = new Person[]
            {
                new Person("LeBron James", 41),
                new Person("Anthony Edwards", 24),
                new Person("Jayson Tatum", 28),
                new Person("Giannis Antetokounmpo", 31),
                new Person("Victor Wembanyama", 22)

            };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Person p in personen)
            {
                yield return p; // baut automatisch enumerator(klasse) im hintergrund
            }
        }
    }
}
