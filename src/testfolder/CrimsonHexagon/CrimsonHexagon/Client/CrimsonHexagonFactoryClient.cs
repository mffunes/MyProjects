using System;
using CrimsonHexagon.Config;
using CrimsonHexagon.Model.Monitor;

namespace CrimsonHexagon.Client
{
    public static class CrimsonHexagonFactoryClient
    {
        public static ICrimsonHexagonClient GetCrimsonHexagonClient(ICrimsonHexagonSourceConfig config)
        {
            switch (config.Type)
            {
                case CrimsonHexagonSourceType.MonitorList:
                    {
                        return new CrimsonHexagonClient<CrimsonHexagonMonitorListSourceConfig, MonitorListResponse>((CrimsonHexagonMonitorListSourceConfig)config);
                    }
                case CrimsonHexagonSourceType.MonitorDetail:
                    {
                        return new CrimsonHexagonClient<CrimsonHexagonMonitorDetailSourceConfig, MonitorDetailResponse>((CrimsonHexagonMonitorDetailSourceConfig)config);
                    }
            }


            throw new NotImplementedException();
        }
    }
}
