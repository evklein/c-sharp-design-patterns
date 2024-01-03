namespace c_sharp_design_patterns.Patterns.Builder;

internal class Director
{
    public void constructSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngineSpecs("V8");
        builder.SetTripComputer();
    }

    public void constructSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(7);
        builder.SetEngineSpecs("V6");
        builder.SetTripComputer();
    }
}
