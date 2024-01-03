namespace c_sharp_design_patterns.Patterns.Builder;

internal class CarManualBuilder : IBuilder
{
    public CarManual Manual { get; private set; }

    public CarManualBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Manual = new CarManual();
    }

    public void SetSeats(int numberOfSeats)
    {
        Manual.SeatSpecs = $"The vehicle is equipped with {numberOfSeats} seat{(numberOfSeats > 1 ? "s" : string.Empty)}";
    }

    public void SetEngineSpecs(string specDocument)
    {
        Manual.EngineSpecs = specDocument;
    }

    public void SetTripComputer()
    {
        Manual.HasTripComputer = true;
    }
}