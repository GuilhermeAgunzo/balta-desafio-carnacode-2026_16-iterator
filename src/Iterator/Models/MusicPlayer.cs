namespace Iterator.Models;

// Cliente precisa implementar diferentes formas de iteração
public class MusicPlayer
{
    private Playlist _playlist;
    private int _currentIndex;

    public MusicPlayer(Playlist playlist)
    {
        _playlist = playlist;
        _currentIndex = 0;
    }

    // Problema 1: Acesso direto à estrutura interna
    public void PlaySequential()
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Sequencial) ===");

        for (int i = 0; i < _playlist.Songs.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_playlist.Songs[i]}");
        }
    }

    // Problema 2: Lógica de shuffle implementada aqui
    public void PlayShuffle()
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Aleatório) ===");

        var random = new Random();
        var shuffled = _playlist.Songs.OrderBy(x => random.Next()).ToList();

        for (int i = 0; i < shuffled.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {shuffled[i]}");
        }
    }

    // Problema 3: Filtros implementados no cliente
    public void PlayByGenre(string genre)
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Gênero: {genre}) ===");

        var filtered = _playlist.Songs.Where(s => s.Genre == genre).ToList();

        for (int i = 0; i < filtered.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {filtered[i]}");
        }
    }

    // Problema 4: Navegação customizada requer conhecer estrutura interna
    public void PlayOldies()
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Antigas) ===");

        var oldies = _playlist.Songs.Where(s => s.Year < 2000).OrderBy(s => s.Year).ToList();

        for (int i = 0; i < oldies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {oldies[i]}");
        }
    }

    // Problema 5: Diferentes coleções exigem código diferente
    public void PlayFromArray(Song[] songs)
    {
        Console.WriteLine("\n=== Tocando de Array ===");
        // Código diferente para array
        for (int i = 0; i < songs.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {songs[i]}");
        }
    }

    public void PlayFromQueue(Queue<Song> songs)
    {
        Console.WriteLine("\n=== Tocando de Fila ===");
        // Código diferente para Queue
        int count = 1;
        while (songs.Count > 0)
        {
            var song = songs.Dequeue();
            Console.WriteLine($"{count++}. {song}");
        }
    }
}
