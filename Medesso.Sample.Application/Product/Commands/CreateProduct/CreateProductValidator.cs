using FluentValidation;

namespace Medesso.Sample.Application.Product.Commands.CreateProduct;

public class CreateProductValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();
            
        RuleFor(x => x.Description)
            .NotEmpty();
    }
}