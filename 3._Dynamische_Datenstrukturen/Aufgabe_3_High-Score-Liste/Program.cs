namespace Aufgabe_3__High_Score_Liste__30_Punkte_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighScoreList topTen = new HighScoreList();

            // Test Spieler hinzufügen (Ranking testen)
            Console.WriteLine($"Platzierung für Marc: {topTen.InsertEntry("Marc", 500)}"); // Platz 1
            Console.WriteLine($"Platzierung für Julia: {topTen.InsertEntry("Julia", 750)}"); // Platz 1 (Julia schiebt Marc auf 2)
            Console.WriteLine($"Platzierung für Kevin: {topTen.InsertEntry("Kevin", 500)}"); // Platz 3 (gleiche Punkte wie Marc, aber neuer)
            Console.WriteLine($"Platzierung für Sarah: {topTen.InsertEntry("Sarah", 1000)}"); // Platz 1
            // Plätze vollmachen (10)
            topTen.InsertEntry("Lukas", 400);
            topTen.InsertEntry("Emma", 300);
            topTen.InsertEntry("Tom", 200);
            topTen.InsertEntry("Hanna", 150);
            topTen.InsertEntry("Finn", 100);
            topTen.InsertEntry("Mia", 50);

            // Versuchen, jemanden einzufügen, der zu wenig Punkte hat
            Console.WriteLine($"Platzierung für Verlierer: {topTen.InsertEntry("Leon", 10)}"); // Sollte -1 sein

            // Liste ausgeben
            Console.WriteLine("\n--- Aktuelle High-Score-Liste ---");
            topTen.PrintHighScoreList();

            // PlayerInList testen
            Console.WriteLine($"\nIst 'Julia' in der Liste? {topTen.PlayerInList("Julia")}");
            Console.WriteLine($"Ist 'Rainer' in der Liste? {topTen.PlayerInList("Rainer")}");

            // Spieler entfernen
            Console.WriteLine("\n--- Entferne 'Marc' ---");
            int delete = topTen.RemovePlayerFromList("Marc");
            Console.WriteLine($"{delete} Eintrag/Einträge von Marc entfernt.");

            // Finale Kontrolle
            Console.WriteLine("\n--- Liste nach dem Entfernen ---");
            topTen.PrintHighScoreList();
        }

        public class HighScore
        {
            private string name;
            private int points;

            public HighScore(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            public string Name { get { return name; } }
            public int Points { get { return points; } }
        }

        public class HighScoreList
        {
            private HighScore[] rekord = new HighScore[10]; // 10 besten Spieler


            public int InsertEntry(string name, int points)
            {
                int pos = -1;

                for (int i = 0; i < this.rekord.Length; i++) // Position finden (Beste Punktzahl zuerst)
                {
                    if (this.rekord[i] == null || points > this.rekord[i].Points) // Bei gleicher Punktzahl bleibt der ältere vorne, daher nur > 
                    {
                        pos = i; // merkt nur die position das ersetzt werden muss
                        break;
                    }
                }

                if (pos != -1)
                {
                    for (int i = this.rekord.Length - 1; i > pos; i--) // Elemente nach hinten verschieben (Platz schaffen)
                    {
                        this.rekord[i] = this.rekord[i - 1];
                    }
                    this.rekord[pos] = new HighScore(name, points); // Neuen Eintrag einfügen

                    return pos + 1; // Rückgabe der Platzierung
                }
                return -1; // Nicht in der Top 10
            }


            public bool PlayerInList(string name)
            {
                foreach (var entry in this.rekord)
                {
                    if (entry != null && entry.Name == name) return true;
                }
                return false;
            }

            public int RemovePlayerFromList(string name)
            {
                int deletedCount = 0;
                for (int i = 0; i < rekord.Length; i++)
                {
                    if (rekord[i] != null && rekord[i].Name == name)
                    {
                        deletedCount++;
                        for (int j = i; j < rekord.Length - 1; j++) // length -1 weil man ab Platz 10 nicht kopieren kann (lücke schließen durch Nachrücken)
                        {
                            rekord[j] = rekord[j + 1];
                        }
                        rekord[rekord.Length - 1] = null; // letzten Platz immer leeren (mind. 1 wird immer gelöscht)
                        i--; // stelle nochmal prüfen
                    }
                }
                return deletedCount;
            }

            public void ClearHighScoreList()
            {
                this.rekord = new HighScore[10];
            }

            public void PrintHighScoreList()
            {
                for (int i = 0; i < this.rekord.Length; i++)
                {
                    if (this.rekord[i] != null)
                    {
                        Console.WriteLine($"{i + 1}. {this.rekord[i].Name}: {this.rekord[i].Points} Punkte");
                    }
                }
            }
        }

    }
}
