namespace Medesso.Processor;

public interface IMedessoRequestPostProcessor<in TRequest, in TResponse> where TRequest : IMedessoRequest<TResponse>
{
    /// <summary>
    /// Process method executes after the Handle method on your handler
    /// </summary>
    /// <param name="request">Request instance</param>
    /// <param name="response">Response instance</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>An awaitable task</returns>
    Task Process(TRequest request, TResponse response, CancellationToken cancellationToken);
}