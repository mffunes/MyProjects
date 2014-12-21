using CrimsonHexagon.Model;
using FeedModel;

namespace CrimsonHexagon.Config
{
    public interface ICrimsonHexagonSourceConfig : IFeedConfiguration
    {
        string Method { get; set; }
        CrimsonHexagonSourceType Type { get; }
        CrimsonHexagonBaseRequest GetRequestObject();
    }
}
