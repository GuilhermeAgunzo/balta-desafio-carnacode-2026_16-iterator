namespace Iterator.Models;

// Problema: Biblioteca de músicas com estrutura personalizada
public class MusicLibrary
{
    // Estrutura interna complexa (árvore, grafo, etc)
    private Dictionary<string, List<Song>> _songsByGenre;
    private Dictionary<string, List<Song>> _songsByArtist;

    public MusicLibrary()
    {
        _songsByGenre = new Dictionary<string, List<Song>>();
        _songsByArtist = new Dictionary<string, List<Song>>();
    }

    public void AddSong(Song song)
    {
        if (!_songsByGenre.ContainsKey(song.Genre))
            _songsByGenre[song.Genre] = new List<Song>();
        _songsByGenre[song.Genre].Add(song);

        if (!_songsByArtist.ContainsKey(song.Artist))
            _songsByArtist[song.Artist] = new List<Song>();
        _songsByArtist[song.Artist].Add(song);
    }

    // Problema: Como iterar sobre toda biblioteca sem expor estrutura?
    public Dictionary<string, List<Song>> GetSongsByGenre()
    {
        return _songsByGenre; // Expõe estrutura interna!
    }

    // Cliente precisa saber como navegar esta estrutura complexa
}
