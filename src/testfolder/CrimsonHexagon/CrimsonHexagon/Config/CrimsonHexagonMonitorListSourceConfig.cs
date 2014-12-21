using CrimsonHexagon.Model;
using CrimsonHexagon.Model.Monitor;
using FeedModel.FeedSources;

namespace CrimsonHexagon.Config
{
    public class CrimsonHexagonMonitorListSourceConfig : ICrimsonHexagonSourceConfig
    {
        public int Id { get; set; }
        public string Method { get; set; }

        public FeedConfigurationProperty[] Properties { get; set; }

        public CrimsonHexagonMonitorListSourceConfig()
        {
            this.Properties = new FeedConfigurationProperty[] { };
        }

        public CrimsonHexagonSourceType Type
        {
            get { return CrimsonHexagonSourceType.MonitorList; }
        }

        public CrimsonHexagonBaseRequest GetRequestObject()
        {
            MonitorListRequest request = new MonitorListRequest();

            foreach (FeedConfigurationProperty property in Properties)
            {
                if (property.Name == "username")
                {
                    request.UserName = property.Value;
                }
            }

            return request;
        }
    }
}
