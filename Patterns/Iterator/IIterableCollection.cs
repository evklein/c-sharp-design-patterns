namespace c_sharp_design_patterns.Patterns.Iterator;

internal interface IIterableCollection<T>
{
    IIterator<T> CreateIterator();
    IIterator<T> CreateItertor(string condition);
}