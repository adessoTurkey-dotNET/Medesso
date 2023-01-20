using FluentValidation;
using Medesso.Processor;

namespace Medesso.Sample.Core.CqrsProcessors;

public class ValidationPreProcessor<TRequest> : IMedessoRequestPreProcessor<TRequest>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationPreProcessor(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task Process(TRequest request, CancellationToken cancellationToken)
    {
        if (!_validators.Any())
        {
            return;
        }
            
        var context = new ValidationContext<TRequest>(request);
        var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
        var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
        if (failures.Any())
        {
            throw new ValidationException(failures);
        }
    }
}