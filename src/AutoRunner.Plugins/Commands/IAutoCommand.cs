using System.Threading.Tasks;

namespace AutoRunner.Plugins.Commands
{
    public interface IAutoCommand
    {
        Task Execute();
    }
}
