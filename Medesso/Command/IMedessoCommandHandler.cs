namespace Medesso.Command;

public interface IMedessoCommandHandler<in TRequest, TResponse> : IMedessoRequestHandler<TRequest, TResponse> where TRequest : IMedessoCommand<TResponse>
{
}