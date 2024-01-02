namespace c_sharp_design_patterns.Patterns.Singleton;

/// <summary>
/// https://refactoring.guru/design-patterns/singleton
/// </summary>
internal class Singleton
{
    private static Singleton _instance;

    private Singleton() { /* Implement instantiation logic here. */ }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}