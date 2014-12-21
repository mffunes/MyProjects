using Sources.Infrastructure;

namespace CrimsonHexagon.Client
{
    public class CrimsonHexagonConfiguration : BaseConfiguration
    {
        public CrimsonHexagonConfiguration(string method)
        {
            base.BaseUrl = "https://forsight.crimsonhexagon.com/api/";
            base.Method = method;
            base.UseAuthorizationToken = true;
        }
    }
}
