namespace cw3App;

public class ContainerL(double cargoWeight, double height, double weight, double depth, double maxCargoWeight, bool hazardousCargo) 
    : Container(cargoWeight, height, weight, depth, maxCargoWeight, ContainerType.L), IHazardNotifier
{
    private bool HazardousCargo { get; set; } = hazardousCargo;
    
    public override void Fill(double weight)
    {
        if (CargoWeight + weight > 0.9 * MaxCargoWeight)
        {
            SendNotification();
            return;
        }
        
        if (HazardousCargo && CargoWeight + weight > 0.5 * MaxCargoWeight)
        {
            SendNotification();
            return;
        }

        CargoWeight += weight;
    }

    public void SendNotification()
    {
        Console.WriteLine(SerialNumber + ": hazardous operation!");
    }

    public override string ToString()
    {
        return base.ToString() +
               "HazardousCargo: " + HazardousCargo + "\n";
    }
}