Aufgabe 4 (Printer, 20 Punkte)
Gegeben ist folgende Main-Methode und im Folgenden die entsprechende Ausgabe auf
der Konsole:

public static void Main()
{
 // Erzeugen eines #-Druckers:
 Printer printer1 = new Printer('#');
 // Drucken eines #-Zeichens:
 printer1++;
 Console.WriteLine("1. " + (string)printer1);
 // Drucken von 3 weiteren #-Zeichen:
 printer1 += 3;
 Console.WriteLine("2. " + (string)printer1);

 // Wechseln des Druck-Zeichens (von '#' zu 'X'):
 printer1 = printer1 << 'X';
 // Drucken von 2 weiteren X-Zeichen:
 printer1 = printer1 + 2;
 Console.WriteLine("3. " + (string)printer1);

 // Erzeugen eines O-Druckers und Drucken von 5 Zeichen:
 Printer printer2 = new Printer('O') + 5;
 Console.WriteLine("4. " + (string)printer2);

 // Vergleich der gedruckten Zeichen:
 if (printer1 > printer2)
 Console.WriteLine("5. 1. Drucker hat mehr Zeichen gedruckt.");
 else
 Console.WriteLine("5. 2. Drucker hat mehr Zeichen gedruckt.");
}

Konsolenausgabe:
1. #
2. ####
3. ####XX
4. OOOOO
5. 1. Drucker hat mehr Zeichen gedruckt.

Ergänzen Sie die Klasse Printer derart, dass sich obiges Programm kompilieren lässt
und exakt die vorgegebene Ausgabe liefert. Die Datenfelder, der Konstruktor und eine
nützliche Methode sind bereits vorgegeben.

class Printer
{
 private char printChar;
 private string output = "";
 public Printer(char printChar) { this.printChar = printChar; }
 private void PrintOneCharacter() { output += printChar; }
 // Hier Ihre Implementierung:

}
