namespace Actio.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        System.Guid UserId { get; set; }

    }
}