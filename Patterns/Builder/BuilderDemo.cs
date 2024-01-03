namespace c_sharp_design_patterns.Patterns.Builder;

internal class BuilderDemo : IDemo
{
    public void Run()
    {
        CarBuilder carBuilder = new CarBuilder();
        CarManualBuilder manualBuilder = new CarManualBuilder();
        
        Director director = new();
        director.constructSportsCar(carBuilder);
        Car sportsCar = carBuilder.Car;
        director.constructSportsCar(manualBuilder);
        CarManual sportsCarManual = manualBuilder.Manual;
    }
}