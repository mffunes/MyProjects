using CrimsonHexagon.Model;
using CrimsonHexagon.Model.Monitor;
using FeedModel.FeedSources;

namespace CrimsonHexagon.Config
{
    public class CrimsonHexagonMonitorDetailSourceConfig : ICrimsonHexagonSourceConfig
    {
        public int Id { get; set; }
        public FeedConfigurationProperty[] Properties { get; set; }
        public string Method { get; set; }

        public CrimsonHexagonSourceType Type
        {
            get
            {
                return CrimsonHexagonSourceType.MonitorDetail;
            }
        }

        public CrimsonHexagonBaseRequest GetRequestObject()
        {
            MonitorDetailRequest request = new MonitorDetailRequest();

            foreach (FeedConfigurationProperty property in Properties)
            {
                if (property.Name == "MonitorId")
                {
                    request.MonitorId = property.Value;
                }
            }

            return request;
        }
    }
}
