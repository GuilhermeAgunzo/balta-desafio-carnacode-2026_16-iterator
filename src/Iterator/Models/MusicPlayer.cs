namespace Iterator.Models;

// Cliente precisa implementar diferentes formas de iteração
public class MusicPlayer(Playlist playlist)
{
    private readonly Playlist _playlist = playlist;

    public void PlaySequential()
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Sequencial) ===");

        var iterator = _playlist.CreateIterator();
        while (iterator.HasNext())
        {
            var song = iterator.Next();
            Console.WriteLine(song);
        }
    }

    public void PlayShuffle()
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Aleatório) ===");

        var iterator = _playlist.CreateShuffleIterator();
        while (iterator.HasNext())
        {
            var song = iterator.Next();
            Console.WriteLine(song);
        }
    }

    public void PlayByGenre(string genre)
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Gênero: {genre}) ===");

        var iterator = _playlist.CreateGenreIterator(genre);

        while (iterator.HasNext())
        {
            var song = iterator.Next();
            Console.WriteLine(song);
        }
    }

    public void PlayOldies()
    {
        Console.WriteLine($"\n=== Tocando {_playlist.Name} (Antigas) ===");

        var iterator = _playlist.CreateOldiesIterator();

        while (iterator.HasNext())
        {
            var song = iterator.Next();
            Console.WriteLine(song);
        }
    }

}
