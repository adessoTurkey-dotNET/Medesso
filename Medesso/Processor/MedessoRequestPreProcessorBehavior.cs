namespace Medesso.Processor;

internal class MedessoRequestPreProcessorBehavior<TRequest, TResponse> : IMedessoPipelineBehavior<TRequest, TResponse> where TRequest : IMedessoRequest<TResponse>
{
    private readonly IEnumerable<IMedessoRequestPreProcessor<TRequest>> _preProcessors;

    public MedessoRequestPreProcessorBehavior(IEnumerable<IMedessoRequestPreProcessor<TRequest>> preProcessors) => _preProcessors = preProcessors;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        foreach (var processor in _preProcessors)
        {
            await processor.Process(request, cancellationToken).ConfigureAwait(false);
        }

        return await next().ConfigureAwait(false);
    }
}