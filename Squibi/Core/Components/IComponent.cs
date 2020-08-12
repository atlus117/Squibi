using System.Threading.Tasks;

namespace Squibi.Web.Core.Components
{
    public interface IComponent
    {
        ValueTask Update(GameContext game);

        GameObject Owner { get; }
    }
}