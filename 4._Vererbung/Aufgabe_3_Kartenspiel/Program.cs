namespace Aufg_3__Kartenspiel__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardStack stack = new CardStack();

            // Eine neue Instanz von Event anlegen und danach auf den Stapel legen
            stack.AddCard(new Event("Regen", "Es regnet sehr stark."));

            // Noch eine Karte anlegen und auf den Stapel usw.
            stack.AddCard(new Item("Regenschirm", 100));
            stack.AddCard(new Action("Aktionskarte"));

            // Ok, lets play and take two cards!
            Card firstCard = stack.TakeCard();  // Aktionskarte
            Card secondCard = stack.TakeCard(); // Regenschirm


            // Wir haben jetzt zwei Karten und entscheiden was zu tun ist, z. B.
            if (firstCard is Action)
            {
                Card thirdCard = stack.TakeCard(); // Noch eine Karte nehmen
                                                   // Aktion ausführen
                if (firstCard is Action && thirdCard is Event)
                {
                    ((Action)firstCard).PerformAction((Event)thirdCard);
                }
            }



            // Test Sell-Methode (falls secondCard ein Item ist):
            if (firstCard is Action && secondCard is Item)
            {
                ((Action)firstCard).Sell((Item)secondCard);
            }
        }

        class Card
        {
            public string Name { get; set; }

            public Card(string name)
            {
                this.Name = name;
            }
        }

        class Item : Card
        {
            public int Geldwert { get; set; }

            public Item(string name, int geldwert) : base(name)
            {
                this.Geldwert = geldwert;
            }

        }

        class Event : Card
        {
            public string Infotext { get; set; }

            public Event(string name, string infotext) : base(name)
            {
                this.Infotext = infotext;
            }

        }

        class Action : Card
        {
            public Action(string name) : base(name) { }

            public void Sell(Item item)
            {
                Console.WriteLine($"Ich verkaufe {item.Name} für {item.Geldwert} Goldstücke");
            }

            public void PerformAction(Event e)
            {
                Console.WriteLine($"Aktion: {e.Infotext}");
            }
        }

        class CardStack
        {
            private List<Card> karten = new List<Card>();

            public void AddCard(Card card)
            {
                karten.Add(card); // fügt oben im stapel (letzten index) ein
            }

            public Card TakeCard()
            {
                if (karten.Count == 0) { return null; } // falls leer

                int indexLetzteKarte = karten.Count - 1; // oberste karte (letzter index)
                Card gezogeneKarte = karten[indexLetzteKarte];

                // karte aus der Liste löschen, da sie gezogen wurde
                karten.RemoveAt(indexLetzteKarte);

                return gezogeneKarte;
            }
        }

    }
}
