using Iterator.Abstractions;
using Iterator.Models;

namespace Iterator.Iterators;

public class SequentialIterator(List<Song> songs) : IIterator<Song>
{
    private readonly List<Song> _songs = songs;
    private int _currentIndex;

    public bool HasNext() => _currentIndex < _songs.Count;

    public Song Next()
    {
        if (!HasNext()) throw new InvalidOperationException("No more songs to play.");
        return _songs[_currentIndex++];
    }
}
