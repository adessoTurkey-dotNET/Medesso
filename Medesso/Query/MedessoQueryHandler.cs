namespace Medesso.Query;

public abstract class MedessoQueryHandler<TRequest, TResponse> : IMedessoQueryHandler<TRequest, TResponse> where TRequest : IMedessoQuery<TResponse>
{
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}