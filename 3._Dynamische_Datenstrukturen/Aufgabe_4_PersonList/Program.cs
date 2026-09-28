using System.Text;
using static Aufgabe_4__PersonList__40_Punkte_.Program;

namespace Aufgabe_4__PersonList__40_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonList freunde = new PersonList();
            freunde.AddSorted("Berta");
            freunde.AddSorted("Claudia");
            freunde.AddSorted("Anton");
            freunde.AddSorted("Barbara");

            freunde.AddFront("Hans");
            freunde.AddEnd("Franz");
            freunde.Print();

            freunde.DeleteFirst();
            freunde.DeleteLast();
            freunde.DeleteByName("Berta");
            freunde.Print();

            freunde.PrintReverse();
        }


        public class Person
        {
            private string name;
            public string Name { get { return name; } }

            public Person(string name) { this.name = name; }

            public override string ToString() { return name; }
        }


        public class PersonList
        {
            private class PersonNode
            {
                public Person Person { get; set; }
                public PersonNode Next { get; set; }
                public PersonNode Prev { get; set; }

                public PersonNode(Person person) { Person = person; }
            }

            private PersonNode first; // zeiger erstes element
            private PersonNode last; // zeiger letztes element

            public void AddFront(string name)
            {
                PersonNode newNode = new PersonNode(new Person(name));
                if (this.first == null)
                {
                    this.first = this.last = newNode;
                }
                else
                {
                    newNode.Next = this.first;
                    this.first.Prev = newNode;
                    this.first = newNode;
                }
            }

            public void AddEnd(string name)
            {
                PersonNode newNode = new PersonNode(new Person(name));
                if (this.last == null)
                {
                    this.first = this.last = newNode;
                }
                else
                {
                    newNode.Prev = this.last;
                    this.last.Next = newNode;
                    this.last = newNode;
                }
            }

            public void AddSorted(string name)
            {
                // Fall 1: leere liste oder alphabetisch vor dem ersten element
                if (first == null || string.Compare(name, first.Person.Name) <= 0)
                {
                    this.AddFront(name);
                }
                // Fall 1 (ende): alphabetisch hinter dem letzten element
                else if (string.Compare(name, last.Person.Name) >= 0)
                {
                    this.AddEnd(name);
                }
                // Fall 3: einfügen in die mitte der liste
                else
                {
                    PersonNode current = this.first;
                    while (current != null && string.Compare(name, current.Person.Name) > 0)
                    {
                        current = current.Next;
                    }

                    PersonNode newNode = new PersonNode(new Person(name));
                    newNode.Next = current;
                    newNode.Prev = current.Prev;
                    current.Prev.Next = newNode;
                    current.Prev = newNode;
                }
            }


            public void DeleteFirst()
            {
                if (first == null) return; // Fall 1: leere liste
                if (first == last) { first = last = null; } // Fall 2: liste mit nur einem element
                else // Fall 3: liste mit mehr als einem element
                {
                    first = first.Next;
                    first.Prev = null;
                }
            }

            public void DeleteLast()
            {
                if (last == null) return; // Fall 1: leere liste
                if (first == last) { first = last = null; } // Fall 2: liste mit nur einem element
                else // Fall 3: liste mit mehr als einem element
                {
                    last = last.Prev;
                    last.Next = null;
                }
            }

            public void DeleteByName(string name)
            {
                if (first == null) return; // Fall 1: leere liste

                PersonNode current = first;

                while (current != null && current.Person.Name != name)
                {
                    current = current.Next;
                }

                if (current == null) return;

                if (current == first) DeleteFirst(); // Fall 2: gesuchte person ist die erste
                else if (current == last) DeleteLast(); // Fall 3: gesuchte person ist die letzte
                else // Fall 4: person ist in der mitte der liste
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
            }


            public void Print()
            {
                StringBuilder sb = new StringBuilder();
                PersonNode current = this.first;
                while (current != null)
                {
                    sb.AppendLine(current.Person.ToString());
                    current = current.Next;
                }
                sb.AppendLine(); // leerzeile nach liste
                Console.Write(sb.ToString());
            }

            public void PrintReverse()
            {
                StringBuilder sb = new StringBuilder();
                PersonNode current = this.last;
                while (current != null)
                {
                    sb.AppendLine(current.Person.ToString());
                    current = current.Prev;
                }
                sb.AppendLine();
                Console.Write(sb.ToString());
            }
        }
    }
}
