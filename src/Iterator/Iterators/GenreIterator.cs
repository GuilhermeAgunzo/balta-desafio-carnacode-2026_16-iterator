using Iterator.Abstractions;
using Iterator.Models;

namespace Iterator.Iterators;

public class GenreIterator(List<Song> songs, string genre) : IIterator<Song>
{
    private readonly List<Song> _songs = [.. songs.Where(s => s.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))];
    private int _currentIndex = 0;

    public bool HasNext() => _currentIndex < _songs.Count;

    public Song Next()
    {
        if (!HasNext()) throw new InvalidOperationException("No more songs available.");

        return _songs[_currentIndex++];
    }
}
