using System.Threading.Tasks;

namespace Squibi.Web.Core
{
    public class SceneGraph
    {
        public SceneGraph()
        {
            Root = new GameObject();
        }

        public async ValueTask Update(GameContext game)
        {
            if (null == Root)
                return;
            await Root.Update(game);
        }
        
        public GameObject Root { get; }
    }
}