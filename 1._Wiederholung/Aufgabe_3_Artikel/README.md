Aufgabe 3 (Artikel, 40 Punkte) Erstellen Sie ein Programm zur Verwaltung von Artikeln. Definieren Sie zu diesem Zweck eine Klasse Artikel mit folgenden Datenelementen und Methoden:

Private Elemente: • Artikelbezeichnung (string) • Artikelnummer (int) • Verkaufspreis (double) • Gruppe (Enumeration Lebensmittelgruppe)

Enumeration: • Lebensmittelgruppe {Obst, Gemüse, Fleisch, Süßwaren}

Öffentliche Elemente: • Parameterloser Konstruktor: liest Artikelbezeichnung, Artikelnummer, Verkaufspreis und Lebensmittelgruppe von der Konsole ein. • Konstruktor mit vier Parametern: setzt Artikelbezeichnung, Artikelnummer, Verkaufspreis und Lebensmittelgruppe (wenn die Lebensmittelgruppe weggelassen wird, handelt es sich um einen „Süßwaren“-Artikel) • Methode zur Ausgabe eines Artikels in folgendem Format: „Artikelbezeichnung: Artikelnummer, Verkaufspreis (Lebensmittelgruppe)“ • Methode GetPreis zur Abfrage des Verkaufspreises • Methode SetPreis zum Ändern des Verkaufspreises • Methode GetBezeichnung zur Abfrage der Artikelbezeichnung • Methode SetBezeichnung zum Ändern der Artikelbezeichnung

Ergänzen Sie außerdem eine Klasse Program mit einer Main-Methode und bearbeiten Sie folgende Aufgaben: • Legen Sie ein Array mit Platz für 10 Artikel an. • Erzeugen Sie drei Artikel mit beliebigen Werten und speichern Sie diese in dem Array. Verwenden Sie dabei den Konstruktor mit vier Parametern. • Schreiben Sie ein Auswahlmenü mit folgenden Auswahlmöglichkeiten: 0 = Anlegen // legt einen neuen Artikel an; die Werte werden von der Konsole gelesen 1 = Ändern // fordert auf, die Artikelbezeichnung einzugeben. Falls Artikel existiert, werden Artikelbezeichnung und Preis überschrieben. 2 = Ausgabe // gibt alle Artikel aus 3 = Teuerster Artikel // gibt die Artikelbezeichnung des teuersten Artikels aus 4 = Ende // Programm wird beendet

Der gesamte Programmablauf könnte sich auf der Konsole wie folgt abspielen: Was wünschen Sie zu tun? 0 = Anlegen 1 = Ändern 2 = Ausgabe 3 = Teuerster Artikel 4 = Ende

Ihre Auswahl: 0 Bezeichnung: Mars Lebensmittelgruppe (1=Obst, 2=Gemüse, 3=Fleisch, 4=Süßwaren): 4 Artikelnummer: 12 Preis: 1,20

Was wünschen Sie zu tun? 0 = Anlegen 1 = Ändern 2 = Ausgabe 3 = Teuerster Artikel 4 = Ende

Ihre Auswahl: 0 Bezeichnung: Birne Lebensmittelgruppe (1=Obst, 2=Gemüse, 3=Fleisch, 4=Süßwaren): 1 Artikelnummer: 13 Preis: 0,80

Was wünschen Sie zu tun? 0 = Anlegen 1 = Ändern 2 = Ausgabe 3 = Teuerster Artikel 4 = Ende

Ihre Auswahl: 1 Bezeichnung des Artikels eingeben? Birne Neue Bezeichnung: Apfel Neuer Preis: 1,50

Was wünschen Sie zu tun? 0 = Anlegen 1 = Ändern 2 = Ausgabe 3 = Teuerster Artikel 4 = Ende

Ihre Auswahl: 3 Teuerster Artikel: Apfel

Was wünschen Sie zu tun? 0 = Anlegen 1 = Ändern 2 = Ausgabe 3 = Teuerster Artikel 4 = Ende Ihre Auswahl: 4
