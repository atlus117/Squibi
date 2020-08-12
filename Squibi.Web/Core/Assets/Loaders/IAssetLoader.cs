using System.Threading.Tasks;

namespace Squibi.Web.Core.Assets.Loaders
{
    public interface IAssetLoader<TA> where TA : IAsset
    {
        ValueTask<TA> Load(string path);
    }
}