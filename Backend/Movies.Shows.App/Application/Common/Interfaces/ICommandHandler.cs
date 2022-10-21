namespace Application.Common.Interfaces
{
    public interface ICommandHandler<TIn>
    {
        Task ExecuteCommand(TIn request, CancellationToken cancellationToken);
    }
}
