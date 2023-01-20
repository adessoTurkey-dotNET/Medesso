using Medesso.Query;
using Medesso.Sample.Abstraction.Responses.Product;

namespace Medesso.Sample.Application.Product.Queries.GetProduct;

public class GetProductQuery : IMedessoQuery<GetProductDto>
{
    public GetProductQuery(int id)
    {
        Id = id;
    }

    public int Id { get; }
}