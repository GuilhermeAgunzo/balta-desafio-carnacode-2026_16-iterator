namespace Iterator.Abstractions;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
