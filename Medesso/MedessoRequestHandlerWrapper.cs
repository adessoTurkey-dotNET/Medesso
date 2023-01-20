using Microsoft.Extensions.DependencyInjection;

namespace Medesso;

public delegate Task<TResponse> RequestHandlerDelegate<TResponse>();

internal class MedessoRequestHandlerWrapper<TRequest, TResponse> where TRequest : IMedessoRequest<TResponse>
{
    public MedessoRequestHandlerWrapper()
    {
    }

    public Task<TResponse> Handle(IMedessoRequest<TResponse> request, IServiceProvider serviceProvider, CancellationToken cancellationToken)
    {
        Task<TResponse> Handler() => serviceProvider.GetRequiredService<IMedessoRequestHandler<TRequest, TResponse>>().Handle((TRequest)request, cancellationToken);

        return serviceProvider
            .GetServices<IMedessoPipelineBehavior<TRequest, TResponse>>()
            .Reverse()
            .Aggregate((RequestHandlerDelegate<TResponse>)Handler, (next, pipeline) => () => pipeline.Handle((TRequest)request, next, cancellationToken))();
    }
}