namespace Medesso.Command;

public interface IMedessoCommand<out TResponse> : IMedessoRequest<TResponse>
{
}