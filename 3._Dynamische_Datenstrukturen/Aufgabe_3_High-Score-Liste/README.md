Aufgabe 3 (High-Score-Liste, 30 Punkte)

Für ein Computer-Spiel soll eine High-Score-Liste implementiert werden. In dieser Liste 
sollen die 10 besten Spieler gespeichert werden, wobei für jeden Spieler der Name und 
die erreichten Punkte hinterlegt sind. Folgende Aufgaben sind dafür zu erledigen:

• Erstellen Sie eine Klasse HighScore mit Attributen für den Namen des Spielers und
der erzielten Punkte, um High-Score-Einträge zu speichern.

• Erstellen Sie eine Klasse HighScoreList, die die High-Score-Einträge in einem Array 
verwaltet. Diese Klasse soll dabei folgende Methoden zur Verfügung stellen:

• int InsertEntry(string name, int points): Wenn die erzielten Punkte für 
einen Eintrag in die High-Score-Liste ausreichen, soll ein neuer Eintrag erzeugt 
und an die richtige Stelle in der High-Score-Liste eingefügt werden. Bei gleicher 
Punktzahl ist der ältere Eintrag vor dem neuen einzuordnen. Der Rückgabewert 
gibt an, an welcher Stelle der Spieler in die High-Score-Liste eingefügt wurde. 
Reicht es nicht für einen Platz in der Liste, ist der Rückgabewert -1.

• bool PlayerInList(string name): Diese Methode prüft, ob ein Spieler mit 
dem übergebenen Namen in der High-Score-Liste vertreten ist.

• int RemovePlayerFromList(string name): Diese Methode entfernt alle 
Einträge eines Spielers mit dem übergebenen Namen aus der Liste. Der 
Rückgabewert zeigt die Anzahl der gelöschten Einträge an.

• void ClearHighScoreList(): Diese Methode leert die komplette High-Score￾Liste.

• void PrintHighScoreList(): Hier werden alle Spieler mit ihren erzielten 
Punkten auf der Konsole ausgegeben, wobei der beste Spieler an erster Position 
steht.
