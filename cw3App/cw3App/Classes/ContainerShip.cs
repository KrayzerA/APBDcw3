namespace cw3App;

public class ContainerShip(double maxSpeed, int maxNumberOfContainers, double maxWeight)
{
    public double MaxSpeed { get; private set; } = maxSpeed;
    public int MaxNumberOfContainers { get; set; } = maxNumberOfContainers;
    public double MaxWeight { get; private set; } = maxWeight;
    public List<Container> Containers { get; private set; } = [];

    public void addContainer(Container container)
    {
        if (Containers.Count >= MaxNumberOfContainers)
        {
            Console.WriteLine("Container can't be added, container ship is full by the number of containers.");
            return;
        }
            
        double currentWeight = 0;
        foreach (var cont in Containers)
        {
            currentWeight += cont.CargoWeight;
        }

        if (currentWeight + container.CargoWeight > MaxWeight)
        {
            Console.WriteLine("Container can't be added, container ship is full by the weight of containers.");
            return;
        }
        
        Containers.Add(container);
    }
}