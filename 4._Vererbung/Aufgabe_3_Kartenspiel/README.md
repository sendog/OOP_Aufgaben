Aufgabe 3 (Kartenspiel, 30 Punkte)
Für ein Spiel werden Spielkarten benötigt, die der Spieler von einem Stapel ziehen soll.
Die Karten sollen von geeigneten Klassen repräsentiert werden. Es gibt drei Typen von
Karten (Card):
• Ereignis (Event)
• Aktion (Action)
• Gegenstand (Item)

a) Alle drei Kartentypen sollen eine Eigenschaft Name besitzen. Die Karten für ein Item
sollen zusätzlich eine Eigenschaft für einen Geldwert (in Goldstücken) besitzen. Die
Karten für ein Event sollen zusätzlich eine Eigenschaft für einen Infotext enthalten.
Die Karten für eine Action sollen zusätzlich zwei Methoden besitzen:
Eine Methode Sell, die als Parameter eine Karte vom Typ Item erwartet und ausgibt
„Ich verkaufe NAME_DER_KARTE für XXX Goldstücke“ und eine zweite
Methode PerformAction, die eine Karte vom Typ Event erwartet und ausgibt „Aktion:
TEXT_DES_EREIGNISSES“.

b) Um die Karten zu verwalten, gibt es einen Kartenstapel CardStack, der beliebig hoch
sein darf. Dieser Kartenstapel soll über zwei Methoden verfügen
(AddCard und TakeCard), die mit jeder Art von Karten funktionieren sollen.

Ergänzen Sie dann die folgende Main-Methode:

CardStack stack = new CardStack();
// Eine neue Instanz von Event anlegen und danach auf den Stapel legen
Card newCard = new Event("Regen", "Es regnet sehr stark.");
stack.AddCard(newCard);

// Noch eine Karte anlegen und auf den Stapel usw.
newCard = new Item("Regenschirm", 100);
stack.AddCard(newCard);

newCard = new Action("Aktionskarte");
stack.AddCard(newCard);

// Ok, lets play and take two cards!
Card firstCard = stack.TakeCard();
Card secondCard = stack.TakeCard();

// Wir haben jetzt zwei Karten und entscheiden was zu tun ist, z. B.
if (firstCard is Action)
{
 Card thirdCard = stack.TakeCard(); // Noch eine Karte nehmen
 // Aktion ausführen
((Action)firstCard).PerformAction((Event)thirdCard);
}
