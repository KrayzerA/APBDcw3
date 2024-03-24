namespace cw3App;

public class ContainerG(double cargoWeight, double height, double weight, double depth, double maxCargoWeight, double pressure) 
    : Container(cargoWeight, height, weight, depth, maxCargoWeight, ContainerType.G), IHazardNotifier
{
    public double Pressure { get; set; } = pressure;

    public override void Empty()
    {
        CargoWeight *= 0.05;
    }

    public void SendNotification()
    {
        Console.WriteLine(SerialNumber + ": hazardous operation!");
    }

    public override string ToString()
    {
        return base.ToString() +
               "Pressure: " + Pressure + "\n";
    }
}