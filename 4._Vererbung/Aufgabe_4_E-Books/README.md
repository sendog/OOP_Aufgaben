Aufgabe 4 (E-Books, 30 Punkte)

Mit E-Book-Readern können Bücher in digitaler Form dargestellt werden. Diese Bücher
sollen neben Text auch Bilder, Videos und Audio-Dateien beinhalten können.

Folgende Zusammenhänge sind bekannt:
Ein E-Book verfügt über einen Autor, einen Titel sowie über ein Erscheinungsjahr und
kann als geordnete Ansammlung digitaler Medien angesehen werden.

Die Medien, aus denen sich ein E-Book zusammensetzt, werden häufig auch als Media
Assets bezeichnet. Jedes Media Asset verfügt über einen Dateinamen, der den
Speicherort im Dateisystem angibt, der Dateigröße in Byte und eine Angabe zur Sprache.

Spezielle Media Assets für Texte, Bilder, Audios und Videos fassen Besonderheiten der
jeweiligen Kategorie zusammen:
• Text Assets speichern zusätzlich die Anzahl an Zeichen
• Bild und Video Assets die Pixeldimensionen
• Audio und Video Assets die Spieldauer in Sekunden
• Alle Media Assets enthalten eine Operation, die den Beitrag zur Seitenzahl als
double-Wert zurückgibt.

Die Klasse E-Book stellt eine Methode bereit, mit der die Anzahl an Seiten als doubleWert berechnet werden kann. Für die Berechnung der Seitenzahl muss Folgendes
beachtet werden:
• Bei Texten wird für 2000 Zeichen jeweils eine Seite abgeschätzt.
• Bei Bildern und Videos wird die Breite unter Beibehaltung der Seitenverhältnisse auf
960 Pixel skaliert. Liegt die skalierte Höhe über 600 Pixel, wird eine Seite
abgeschätzt, andernfalls eine halbe Seite.
• Audiodaten tragen nicht zur Erhöhung der Seitenzahl bei.
Implementieren Sie die beschriebenen Klassen und benutzen Sie auf sinnvolle Art
abstrakte Klassen und Vererbung.
