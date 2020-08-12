using System.Threading.Tasks;

namespace Squibi.Core.Components
{
    public interface IComponent
    {
        ValueTask Update(GameContext game);

        GameObject Owner { get; }
    }
}