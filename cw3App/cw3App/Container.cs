namespace cw3App;

public abstract class Container(double cargoWeight, double height, double weight,
    double depth, ContainerType containerType, double maxCargoWeight)
{
    private static int _id = 1;
    public double CargoWeight { get; set; } = cargoWeight;
    public double Height { get; set; } = height;
    public double Weight { get; set; } = weight;
    public double Depth { get; set; } = depth;
    public string SerialNumber { get; set; } = "KON-" + containerType + "-" + _id++;
    public double MaxCargoWeight { get; set; } = maxCargoWeight;

    public abstract void Empty();
    public abstract void Fill();

}