namespace cw3App;

public class Product(ProductType type, double temperature, double weight)
{
    public ProductType Type { get; set; } = type;
    public double Temperature { get; set; } = temperature;
    public double Weight { get; set; } = weight;
    
    public override string ToString()
    {
        return Type + "(" + Weight +" kg): " + Temperature;
    }
}