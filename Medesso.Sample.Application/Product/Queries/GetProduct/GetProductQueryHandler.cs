using Medesso.Query;
using Medesso.Sample.Abstraction.Responses.Product;
using Medesso.Sample.Core.Extensions;
using Medesso.Sample.Repository.Contracts;

namespace Medesso.Sample.Application.Product.Queries.GetProduct;

public class GetProductQueryHandler : IMedessoQueryHandler<GetProductQuery, GetProductDto>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetProductQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var predicate = ExpressionBuilder.New<Domain.Entities.Product.Product>(x => x.Id == request.Id);

        var product = await _unitOfWork.ProductRepository.FindAsync(
            predicate: predicate,
            cancellationToken: cancellationToken);

        return new GetProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            CreatedOn = product.CreatedOn
        };
    }
}