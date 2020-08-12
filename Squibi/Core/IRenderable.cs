using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;

namespace Squibi.Web.Core
{
    public interface IRenderable
    {
        ValueTask Render(GameContext game, Canvas2DContext context);
    }
}