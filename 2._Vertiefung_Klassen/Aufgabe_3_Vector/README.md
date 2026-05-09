Aufgabe 3 (Vector, 30 Punkte)
Schreiben Sie eine Klasse Vector, die einen zweidimensionalen Vektor darstellt.

Diese Klasse muss in der Lage sein, folgende Anforderungen zu erfüllen:

• Vektor + Vektor = Vektor // entspricht Vektoraddition
• Skalar * Vektor = Vektor // entspricht Skalar-Multiplikation
• Vektor * Skalar = Vektor // entspricht Skalar-Multiplikation
• Vektor++ // der Vektor wird einmal auf sich selbst addiert
• -Vektor // beide Werte des Vektors werden mit -1 multipliziert
• Vektor == Vektor // ist wahr, wenn beide Werte der Vektoren gleich sind

Die Klasse Vector muss außerdem einen Konstruktor zum Initialisieren besitzen. Die
Werte dürfen nach dem Initialisieren nicht mehr änderbar sein. Es muss außerdem eine
ToString-Methode vorhanden sein, die „(x/y)“ zurückliefert, wobei x und y durch die
jeweils konkreten Werte des Vektors ersetzt werden.

Die folgende Main-Methode muss ausführbar sein. Dazu müssen Sie auch Operatoren
überladen, die weiter oben nicht explizit genannt werden.

Vector v1 = new Vector(1, 1);
Vector v2 = new Vector(1, 1);

Console.WriteLine(1.0f * (float)v1);
Console.WriteLine(-(v1 + v1 * 5.0f + ++v1));
Console.WriteLine(new Vector(1, 1) + ++v2 * 10 + v2++);
Console.WriteLine(v2);
Console.WriteLine(v1);
Console.WriteLine(v1 == v2 ? "ja" : "nein");

Console.WriteLine
 (new Vector(1, 1) != new Vector(1, 1) ? "ja" : "nein");
