namespace c_sharp_design_patterns.Patterns.Builder;

internal class CarBuilder : IBuilder
{
    public Car Car { get; private set; }

    public CarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Car = new Car();
    }

    public void SetSeats(int numberOfSeats)
    {
        Car.Seats = numberOfSeats;
    }

    public void SetEngineSpecs(string specDocument)
    {
        Car.EngineSpecs = specDocument;
    }

    public void SetTripComputer()
    {
        Car.HasTripComputer = true;
    }
}