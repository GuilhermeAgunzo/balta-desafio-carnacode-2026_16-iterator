namespace Iterator.Abstractions;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
    IIterator<T> CreateShuffleIterator();
    IIterator<T> CreateGenreIterator(string genre);
    IIterator<T> CreateOldiesIterator();
}
