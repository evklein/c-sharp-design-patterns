namespace c_sharp_design_patterns.Patterns.Prototype;

internal class ConcretePrototype : IPrototype
{
    private int _integerField = 0;

    public ConcretePrototype(int integerField)
    {
        _integerField = integerField;
    }

    public ConcretePrototype(ConcretePrototype prototype)
    {
        _integerField = prototype._integerField;
    }

    public virtual IPrototype Clone()
    {
        return new ConcretePrototype(this);
    }
}
