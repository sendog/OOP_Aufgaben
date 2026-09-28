using System.Globalization;

public class User
{

  //TODO: Instanzvariablen bzw. Properties hinzufuegen XXX
    public string Username { get; }
    private string password;
    public List<Playlist> Playlists { get; }

  //TODO: Zusaetzliche Methoden hinzufügen und implementieren ///
 

  private User(string username, string password)
  {
      this.Username = username; //TODO: Konstruktur implementieren XXX
      this.password = password;
      this.Playlists = new List<Playlist>();
  }


  /**
   * Die Methode ueberprueft, ob username nur Buchstaben (A-Z und a-z) enthaelt.
   * Wenn das der Fall, wird mit Hilfe des privaten Konstruktors ein User-Objekt erzeugt,
   * ansonsten wird null zurückgeliefert.
   */
  public static User CreateUser(string username, string password)
  {
      foreach (char c in username) //TODO: Methode implementieren XXX
      {
        if (!char.IsLetter(c)) return null;
      }
        return new User(username, password);
  }

  /**
   * Erzeugt eine neue Playlist mit dem uebergebenen Namen und fuegt diese dem User hinzu.
   */
  public Playlist AddPlaylistToUser(string name)
  {
      Playlist newPlaylist = new Playlist(name); //TODO: Methode implementieren XXX
      Playlists.Add(newPlaylist);
      return newPlaylist;
  }

  /**
   * Methode zum Aendern des Passworts
   * Ueberprueft zunächst, ob oldPassword dem bisherigen Passwort entspricht.
   * Ist das der Fall, wird das Passwort in newPassword geaendert und true zurückgeliefert.
   * Andernfalls bleibt das Passwort erhalten und es wird false zurueckgegeben.
   *
   */
  public bool ChangePassword(string oldPassword, string newPassword)
  {
      if (oldPassword == this.password) //TODO: Methode implementieren XXX
      {
        this.password = newPassword;
        return true;
      }
        return false;
  }

  /**
   * Ueberprueft, ob das uebergebene Passwort dem Passwort des Users entspricht
   */
  public bool CheckPassword(string password)
  {
      return this.password == password; //TODO: Methode implementieren XXX
  }
}
