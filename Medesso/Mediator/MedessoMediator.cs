using System.Collections.Concurrent;

namespace Medesso.Mediator;

internal class MedessoMediator : IMedessoMediator
{
    private readonly IServiceProvider _serviceProvider;
    private static readonly ConcurrentDictionary<Type, dynamic> _requestHandlers = new();

    public MedessoMediator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task<TResponse> Send<TResponse>(IMedessoRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        var requestType = request.GetType();

        var handler = _requestHandlers.GetOrAdd(requestType, Activator.CreateInstance(typeof(MedessoRequestHandlerWrapper<,>).MakeGenericType(requestType, typeof(TResponse)))
                                                             ?? throw new InvalidOperationException($"Could not create wrapper type for {requestType}"));
        
        return handler.Handle(request, _serviceProvider, cancellationToken);
    }
}