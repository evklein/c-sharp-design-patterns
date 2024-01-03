namespace c_sharp_design_patterns.Patterns.Builder;

internal class CarBuildingDirector
{
    public void MakeSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(7);
        builder.SetEngineSpecs("SUV engine specs");
        builder.SetTripComputer();
    }

    public void MakeSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngineSpecs("Sports car engine specs");
        builder.SetTripComputer();
    }
}
