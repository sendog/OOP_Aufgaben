Aufgabe 5 (Rechteck, 20 Punkte)

Das Interface IRectangle soll die abstrakten Methoden
 int GetWidth() & int GetLength()
definieren.

Es soll außerdem die Default-Methode
 bool IsSquare()
 
und die statische Methode
 static int Compare(IRectangle a, IRectangle b)
implementieren.

Letztere soll die Flächeninhalte zweier Rechtecke vergleichen und -1, 0 oder 1
zurückgeben, je nachdem, ob die Flächen von a und b in einer Kleiner-, Gleich- bzw.
Größer-Beziehung zueinanderstehen. 
Erstellen Sie dieses Interface und eine Klasse
Rectangle, die IRectangle implementiert und testen Sie Ihre Implementierung.
