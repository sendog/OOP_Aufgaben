public class Song
{
  //TODO: Instanzvariablen bzw. Properties hinzufuegen XXX
    public int Id { get; }
    public string Title { get; }
    public string Artist { get; }
    public int Duration { get; }

  //TODO: Konstruktor implementieren XXX
    public Song(int id, string title, string artist, int duration)
    {
        this.Id = id;
        this.Title = title;
        this.Artist = artist;
        this.Duration = duration;
    }

}

