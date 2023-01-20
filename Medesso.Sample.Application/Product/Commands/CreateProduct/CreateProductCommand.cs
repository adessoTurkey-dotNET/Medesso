using Medesso.Command;
using Medesso.Sample.Abstraction.Responses.Product;

namespace Medesso.Sample.Application.Product.Commands.CreateProduct;

public class CreateProductCommand : IMedessoCommand<CreateProductDto>
{
    public CreateProductCommand(
        string name,
        string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; }
    public string Description { get; }
}