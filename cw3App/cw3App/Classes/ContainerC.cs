namespace cw3App;

public class ContainerC(double cargoWeight, double height, double weight, double depth, double maxCargoWeight,
    ProductType productType, double containerTemperature) 
    : Container(cargoWeight, height, weight, depth, maxCargoWeight, ContainerType.C)
{
    public ProductType ProductType { get; set; } = productType;
    public double ContainerTemperature { get; set; } = containerTemperature;

    public void AddProduct(Product product)
    {
        if (ProductType != product.Type)
        {
            Console.WriteLine("Container can be filled only by:" + ProductType);
            return;
        }
        
        if (ContainerTemperature < product.Temperature)
        {
            Console.WriteLine("Low container temperature!");
            return;
        }

        base.Fill(product.Weight);
    }
}