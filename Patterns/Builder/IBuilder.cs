namespace c_sharp_design_patterns.Patterns.Builder;

internal interface IBuilder
{
    void Reset();
    void SetSeats(int numberOfSeats);
    void SetEngineSpecs(string specDocument);
    void SetTripComputer();
}
