Aufgabe 2 (Bücherverwaltung, 30 Punkte)

Sie sollen für eine Büchersammlung eine Bestandsliste implementieren. Die Anzahl der 
Bücher in der Büchersammlung wächst mit der Zeit und zu Beginn ist nicht bekannt, wie 
viele Bücher darin enthalten sein werden. Dazu ist Folgendes umzusetzen:

1) Sie benötigen eine Klasse für Bücher. Jedes Buch soll über einen Titel, einen Autor und 
eine Seitenzahl verfügen. Nachdem ein Buch erzeugt wurde, sollen diese Werte nicht 
mehr änderbar sein.

2) Die Bücherobjekte sollen in der Bücherverwaltung gespeichert werden. Die 
Bücherverwaltung muss beliebig viele Bücher aufnehmen können. Verwenden Sie bei 
der Implementierung der Bücherverwaltung ein Array, um die Bücher zu speichern. Es 
muss sichergestellt werden, dass die Bücherverwaltung eine beliebig große Anzahl an 
Büchern speichern kann.

3) Die Bücherverwaltung soll über öffentliche Methoden verfügen, um
• ein Buch hinzuzufügen,
• alle Bücher mit Titel, Autor und Seitenzahl auf der Konsole auszugeben,
• alle Bücher eines Autors auf der Konsole auszugeben und
• alle Bücher eines Autors zu entfernen.

4) Die Bücherverwaltung soll über einen Indexer verfügen, der bei Übergabe eines Autors 
ein Array mit allen von diesem Autor verfassten Büchern zurückliefert.
