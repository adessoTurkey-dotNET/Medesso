namespace Medesso.Sample.Abstraction.Responses.Product;

public class CreateProductDto
{
    public CreateProductDto(int id)
    {
        Id = id;
    }

    public int Id { get; }
}