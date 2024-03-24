namespace cw3App;

public abstract class Container(double cargoWeight, double height, double weight,
    double depth, double maxCargoWeight, ContainerType containerType) : IContainer
{
    private static int _id = 1;
    public double CargoWeight { get; protected set; } = cargoWeight;
    public double Height { get; protected set; } = height;
    public double Weight { get; protected set; } = weight;
    public double Depth { get; protected set; } = depth;
    public double MaxCargoWeight { get; protected set; } = maxCargoWeight;
    public string SerialNumber { get; } = "KON-" + containerType + "-" + _id++;

    public virtual void Empty()
    {
        CargoWeight = 0;
    }

    public virtual void Fill(double cargoWeight)
    {
        if (CargoWeight + cargoWeight > MaxCargoWeight)
            throw new OverfillException();
        
        CargoWeight += cargoWeight;
    }

    public override string ToString()
    {
        return "SerialNumber: " + SerialNumber +
               "\nHeight: " + Height +
               "\nWeight: " + Weight +
               "\nDepth: " + Depth +
               "\nCargoWeight: " + CargoWeight +
               "\nMaxCargoWeight: " + MaxCargoWeight + "\n";
    }
}