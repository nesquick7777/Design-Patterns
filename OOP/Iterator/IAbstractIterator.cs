namespace Iterator
{
    internal interface IAbstractIterator
    {
        Dog First();
        Dog Next();
        bool IsDone { get; }
        Dog CurrentDog { get; }

    }
}