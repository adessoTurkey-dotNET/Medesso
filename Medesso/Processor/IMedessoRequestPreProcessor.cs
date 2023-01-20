namespace Medesso.Processor;

public interface IMedessoRequestPreProcessor<in TRequest> where TRequest : notnull
{
    /// <summary>
    /// Process method executes before the Handle method on your handler
    /// </summary>
    /// <param name="request">Request instance</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>An awaitable task</returns>
    Task Process(TRequest request, CancellationToken cancellationToken);
}