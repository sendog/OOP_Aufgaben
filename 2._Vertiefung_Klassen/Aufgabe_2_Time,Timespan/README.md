Aufgabe 2 (Time/TimeSpan, 30 Punkte)
Implementieren Sie zwei Klassen Time und TimeSpan, sodass nachfolgendes Programm
ausführbar ist.

// Klasse Time
1) Erstellen Sie ein privates Datenelement minuten.
2) Erstellen Sie einen Konstruktor Time(int hours, int minutes), der Stunden und
Minuten als Parameter übergeben bekommt, daraus die Gesamtminuten berechnet
und diese in das Datenelement minuten ablegt.
3) Erstellen Sie einen Konstruktor Time(int minutes), der nur die Minuten übergeben
bekommt und diese im Datenfeld minuten ablegt. Dieser Konstruktor darf nur
innerhalb der Klasse Time aufrufbar sein.
Objektorientierte Programmierung
Sommersemester 2026
Prof. Dr. Matthias Meitner
Prof. Dr. Michael Dorner
4) Erstellen Sie zwei Konvertierungsoperatoren:
a) implicit operator Time(string s), sodass der Aufruf Time t3 = "11:30";
in der Main-Methode den String splittet und den Konstruktor Time(int hours,
int minutes) aufruft.
b) implicit operator Time(int k), sodass der Aufruf Time t2 = 15; in der
Main-Methode den Konstruktor Time(int minutes) aufruft.
5) Überladen Sie die bool-Operatoren (true, false), sodass der Aufruf if (t2) in der
Main-Methode den Text „Guten Morgen“ ausgibt.
6) Überladen Sie die Operatoren (+, -, ==, !=), sodass die Aufrufe
Time t2 = t1 + "1:30" + 15; und
TimeSpan tDiff = t2 - t1; und
if (t2 == t3) in der Main-Methode funktionieren.
7) Überschreiben Sie die ToString-Methode, sodass
Console.WriteLine($"t1: {t1}");
Console.WriteLine($"t2: {t2}");
zu der unten angegebenen Konsolenausgabe führen.

// Klasse TimeSpan
1) Erstellen Sie ein privates Datenelement minuten.
2) Erstellen Sie einen Konstruktor TimeSpan(int minutes), der die Minuten übergeben
bekommt.
3) Erstellen Sie eine readonly-Property TotalMins, die die Minuten zurückgibt.
4) Überschreiben Sie die ToString-Methode, sodass
Console.WriteLine($"tDiff: {tDiff}");
zu der unten angegebenen Konsolenausgabe führt.

public static void Main()
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

Konsolenausgabe:
t1: 9:45 Uhr
t2: 11:30 Uhr
tDiff: 1h45min
tDiff in Min: 105
Guten Morgen
Die Uhrzeiten sind gleich!
