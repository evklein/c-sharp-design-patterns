namespace c_sharp_design_patterns.Patterns.Prototype;

internal class SubclassPrototype : ConcretePrototype
{
    public int ChildField { get; set; } = 0;

    public SubclassPrototype(SubclassPrototype prototype) : base(prototype)
    {
        ChildField = prototype.ChildField;
    }

    public override IPrototype Clone()
    {
        return new SubclassPrototype(this);
    }
}
