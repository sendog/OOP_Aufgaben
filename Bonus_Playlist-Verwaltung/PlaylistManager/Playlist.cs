public class Playlist
{

  //TODO: Instanzvariablen bzw. Properties hinzufuegen XXX
    public string Name { get; set; }
    public List<Song> Songs { get; }

  //TODO: Weitere Methoden hinzufuegen und implementieren XXX
    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public Playlist(string name)
    {
        this.Name = name; //TODO: Konstruktor implementieren
        this.Songs = new List<Song>();
    }

  public int TotalDuration
  {
        get// Berechnet die Gesamtspielzeit der Playlist aus den Einzelspielzeiten der enthaltenen Lieder 
           // TODO: Implementieren XXX
        {
            int total = 0;
            foreach (Song s in Songs)
            {
                total += s.Duration;
            }
            return total;
        }
    }


  /**
   * Teil 2
   * Sortieren Sie die Playlist alphabetisch nach Titeln.
   */
  public void SortPlaylistByTitle()
  {
        Songs.Sort((s1, s2) => s1.Title.CompareTo(s2.Title)); //TODO: Methode implementieren XXX
  }

  /**
   * Teil 2
   * Methode gibt eine NEUE Liste zurueck, die nur Lieder von dem uebergebenen Kuenstler enthaelt.
   * Die urspruengliche Liste soll dabei also nicht veraendert werden.
   */
  public List<Song> FilterPlaylistByArtist(string artist)
  {
        List<Song> filtered = new List<Song>(); //TODO: Methode implementieren XXX
        foreach (Song s in Songs)
        {
            if (s.Artist == artist)
            {
                filtered.Add(s);
            }
        }
        return filtered;
  }

  /**
   * Teil 2
   * Methode speichert die Playlist in eine CSV-Datei.
   * Der Pfad zum Speicherort wird in dem Parameter path uebergeben.
   */
  public void SavePlaylistToCSVFile(string path)
  {
        using (StreamWriter writer = new StreamWriter(path)) //TODO: Methode implementieren XXX
        {
            foreach (Song s in Songs)
            {
                writer.WriteLine($"{s.Id},{s.Title},{s.Artist}, {s.Duration}");
            }
        }
  }
}
