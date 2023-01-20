namespace Medesso.Processor;

internal class MedessoRequestPostProcessorBehavior<TRequest, TResponse> : IMedessoPipelineBehavior<TRequest, TResponse> where TRequest : IMedessoRequest<TResponse>
{
    private readonly IEnumerable<IMedessoRequestPostProcessor<TRequest, TResponse>> _postProcessors;

    public MedessoRequestPostProcessorBehavior(IEnumerable<IMedessoRequestPostProcessor<TRequest, TResponse>> postProcessors) => _postProcessors = postProcessors;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var response = await next().ConfigureAwait(false);

        foreach (var processor in _postProcessors)
        {
            await processor.Process(request, response, cancellationToken).ConfigureAwait(false);
        }

        return response;
    }
}