namespace Medesso.Mediator;

public interface IMedessoMediator
{
    Task<TResponse> Send<TResponse>(IMedessoRequest<TResponse> request, CancellationToken cancellationToken = default);
}