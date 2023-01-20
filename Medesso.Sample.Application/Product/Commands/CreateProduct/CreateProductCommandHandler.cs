using Medesso.Command;
using Medesso.Sample.Abstraction.Responses.Product;
using Medesso.Sample.Repository.Contracts;

namespace Medesso.Sample.Application.Product.Commands.CreateProduct;

public class CreateProductCommandHandler : IMedessoCommandHandler<CreateProductCommand, CreateProductDto>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
        
    public async Task<CreateProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Entities.Product.Product(request.Name, request.Description);

        await _unitOfWork.ProductRepository.AddAsync(product, cancellationToken);
        await _unitOfWork.SaveChangesAsync();

        return new CreateProductDto(product.Id);
    }
}