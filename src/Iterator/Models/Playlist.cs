namespace Iterator.Models;

// Problema: Playlist expõe estrutura interna (List)
public class Playlist
{
    public string Name { get; set; }
    public List<Song> Songs { get; set; } // Expor List diretamente é problemático

    public Playlist(string name)
    {
        Name = name;
        Songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }
}
