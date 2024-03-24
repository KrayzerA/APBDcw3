using Microsoft.VisualBasic;

namespace cw3App;

public class ContainerShip(double maxSpeed, int maxNumberOfContainers, double maxWeight)
{
    private static int _id = 1;
    public double MaxSpeed { get; private set; } = maxSpeed;
    public int MaxNumberOfContainers { get; set; } = maxNumberOfContainers;
    public double MaxWeight { get; private set; } = maxWeight;
    public List<Container> Containers { get; private set; } = [];
    public int Id { get; set; } = _id++;

    public void AddContainer(Container container)
    {
        if (Containers.Count >= MaxNumberOfContainers)
        {
            throw new FullContainerShipException("Container can't be added, container ship is full by the number of containers.");
        }
            
        double currentWeight = 0;
        foreach (var cont in Containers)
        {
            currentWeight += cont.CargoWeight;
        }

        if (currentWeight + container.CargoWeight > MaxWeight)
        {
            throw new FullContainerShipException("Container can't be added, container ship is full by the weight of containers.");
        }
        
        Containers.Add(container);
    }

    public void AddContainers(List<Container> containers)
    {
        foreach (var container in containers)
        {
            AddContainer(container);
        }
    }

    public bool Remove(Container container)
    {
        return Containers.Remove(container);
    }

    public void RemoveAt(int index)
    {
        Containers.RemoveAt(index);
    }

    public Container Replace(int index, Container container)
    {
        if (index >= Containers.Count)
        {
            throw new IndexOutOfRangeException();
        }

        Container resultContainer = Containers[index];
        Containers[index] = container;
        return resultContainer;
    }

    public bool TransportTo(Container container, ContainerShip containerShip)
    {
        try
        {
            containerShip.AddContainer(container);
        }
        catch (FullContainerShipException e)
        {
            return false;
        }

        Containers.Remove(container);
        return true;
    }

    public override string ToString()
    {
        return "ShipId: " + Id +
               "\nMaxSpeed: " + MaxSpeed +
               "\nMaxWeight: " + MaxWeight +
               "\nMaxContainers: " + MaxNumberOfContainers +
               "\nContainers on ship:\n" + String.Join("\n", Containers);
    }
}