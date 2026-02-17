using Iterator.Abstractions;
using Iterator.Models;

namespace Iterator.Iterators;

public class OldiesIterator(List<Song> songs) : IIterator<Song>
{
    private readonly List<Song> _songs = [.. songs.Where(s => s.Year < 2000).OrderBy(s => s.Year)];
    private int _currentIndex = 0;

    public bool HasNext() => _currentIndex < _songs.Count;


    public Song Next()
    {
        if (!HasNext()) throw new InvalidOperationException("No more songs available.");

        return _songs[_currentIndex++];
    }
}
