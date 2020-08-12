using System.Threading.Tasks;

namespace Squibi.Core.Assets
{
    public interface IAssetsResolver
    {
        ValueTask<TA> Load<TA>(string path) where TA : IAsset;
        TA Get<TA>(string name) where TA : class, IAsset;
    }
}