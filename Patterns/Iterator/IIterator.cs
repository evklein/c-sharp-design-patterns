namespace c_sharp_design_patterns.Patterns.Iterator;

internal interface IIterator<T>
{
    T Root { get; init; }
    T GetNext();
    bool HasMore();
}
