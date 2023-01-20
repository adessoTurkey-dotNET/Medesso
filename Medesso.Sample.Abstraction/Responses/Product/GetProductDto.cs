namespace Medesso.Sample.Abstraction.Responses.Product;

public class GetProductDto
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}