namespace Medesso.Sample.Domain.Entities.Product;

public partial class Product
{
    public Product(
        string name, 
        string description)
    {
        Name = name;
        Description = description;
    }
}