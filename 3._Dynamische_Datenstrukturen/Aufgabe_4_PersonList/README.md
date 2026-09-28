Aufgabe 4 (PersonList, 40 Punkte)

Definieren Sie eine Klasse PersonList mit einer inneren Klasse PersonNode, die eine 
Referenz auf ein Person-Objekt sowie Verweise auf den vorherigen und nächsten
PersonNode in der Liste speichert (also eine doppelt verkettete Liste). In Objekten vom 
Typ Person wird nur ein Name als Zeichenkette gespeichert. Erstellen Sie in der 
PersonList zudem zwei Variablen vom Typ PersonNode, die auf das erste und das letzte 
Element der Liste zeigen. 

Fügen Sie der PersonList-Klasse folgende öffentliche Methoden hinzu: 

• AddEnd(string name), um eine neue Person am Ende der Liste hinzuzufügen

• AddFront(string name), um eine neue Person am Anfang der Liste hinzuzufügen

• AddSorted(string name), um eine neue Person an der richtigen Position in der Liste
basierend auf ihrem Namen hinzuzufügen
Beachten Sie folgende Fälle:
• 1. Fall: Leere Liste oder Anfügen am Listenende
• 2. Fall: Anfügen am Listenanfang
• 3. Fall: Anfügen in die Mitte der Liste

• DeleteFirst(), um die erste Person aus der Liste zu löschen
Beachten Sie folgende Fälle:
• 1. Fall: Leere Liste
• 2. Fall: Liste mit nur einem Element
• 3. Fall: Liste mit mehr als einem Element

• DeleteLast(), um die letzte Person aus der Liste zu löschen
Beachten Sie folgende Fälle:
• 1. Fall: Leere Liste
• 2. Fall: Liste mit nur einem Element
• 3. Fall: Liste mit mehr als einem Element

• DeleteByName(string name), um die Person mit dem übergebenen Namen aus der 
Liste zu löschen
Beachten Sie folgende Fälle:
• 1. Fall: Leere Liste
• 2. Fall: Die gesuchte Person ist die erste Person.
• 3. Fall: Die gesuchte Person ist die letzte Person.
• 4. Fall: Die gesuchte Person ist in der Mitte der Liste.

• Print(), um die Liste vorwärts zu durchlaufen und alle Personennamen auszugeben

• PrintReverse(), um die Liste rückwärts zu durchlaufen und alle Personennamen 
auszugeben

Überschreiben Sie für die beiden Print-Methoden die ToString-Methode der Klasse 
Person.
Übernehmen Sie folgende Main-Methode, die eine Instanz von PersonList erzeugt und 
verschiedene Methoden aufruft, um Personen hinzuzufügen, zu löschen und die Liste 
auszugeben:

public static void Main()
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

//Konsolenausgabe: 
Hans 
Anton 
Barbara
Berta 
Claudia 
Franz 
Anton 
Barbara
Claudia 
Claudia 
Barbara
Anton 
