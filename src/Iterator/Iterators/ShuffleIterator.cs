using Iterator.Abstractions;
using Iterator.Models;

namespace Iterator.Iterators;

public class ShuffleIterator(List<Song> songs) : IIterator<Song>
{
    private readonly List<Song> _songs = songs;
    private readonly List<int> _shuffledIndexes = [.. Enumerable.Range(0, songs.Count).OrderBy(x => Guid.NewGuid())];
    private int _position = 0;

    public bool HasNext() => _position < _shuffledIndexes.Count;

    public Song Next()
    {
        if (!HasNext()) throw new InvalidOperationException("No more songs to play.");

        int index = _shuffledIndexes[_position++];
        return _songs[index];
    }
}
