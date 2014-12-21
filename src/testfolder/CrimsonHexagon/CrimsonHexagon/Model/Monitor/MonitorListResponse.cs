using System.Collections.Generic;
using System.Linq;

namespace CrimsonHexagon.Model.Monitor
{
    public class MonitorListResponse : ICrimsonHexagonResponse
    {
        public List<Monitor> monitors { get; set; }
        public string status { get; set; }

        public IList<CrimsonHexagonItem> GetCrimsonHexagonItem()
        {
            return this.monitors.Select(monitor => new CrimsonHexagonItem
            {
                Id = monitor.id,
                Description = monitor.name,
                Type = "MonitorList"

            }).ToList();
        }
    }
}
