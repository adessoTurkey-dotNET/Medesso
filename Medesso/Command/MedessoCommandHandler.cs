namespace Medesso.Command;

public abstract class MedessoCommandHandler<TRequest, TResponse> : IMedessoCommandHandler<TRequest, TResponse> where TRequest : IMedessoCommand<TResponse>
{
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}