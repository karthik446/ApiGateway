using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    public interface ICommanHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}