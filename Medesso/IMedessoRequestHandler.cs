namespace Medesso;

public interface IMedessoRequestHandler<in TRequest, TResponse> where TRequest : IMedessoRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}