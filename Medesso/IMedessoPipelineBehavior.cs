namespace Medesso;

public interface IMedessoPipelineBehavior<in TRequest, TResponse> where TRequest : IMedessoRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken);
}