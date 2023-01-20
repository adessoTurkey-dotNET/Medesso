namespace Medesso.Query;

public interface IMedessoQueryHandler<in TRequest, TResponse>: IMedessoRequestHandler<TRequest,TResponse> where TRequest : IMedessoQuery<TResponse>
{
}