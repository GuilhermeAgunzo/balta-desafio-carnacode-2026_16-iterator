using Iterator.Abstractions;
using Iterator.Iterators;

namespace Iterator.Models;

public class Playlist(string name) : IAggregate<Song>
{
    public string Name { get; set; } = name;
    private List<Song> Songs { get; set; } = [];

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public IIterator<Song> CreateIterator() => new SequentialIterator(Songs);
    public IIterator<Song> CreateShuffleIterator() => new ShuffleIterator(Songs);
    public IIterator<Song> CreateGenreIterator(string genre) => new GenreIterator(Songs, genre);
    public IIterator<Song> CreateOldiesIterator() => new OldiesIterator(Songs);

}
