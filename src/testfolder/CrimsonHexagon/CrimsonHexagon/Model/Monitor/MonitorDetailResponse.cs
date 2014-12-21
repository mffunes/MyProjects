using System.Collections.Generic;

namespace CrimsonHexagon.Model.Monitor
{
    public class MonitorDetailResponse : Monitor, ICrimsonHexagonResponse
    {
        public IList<CrimsonHexagonItem> GetCrimsonHexagonItem()
        {
            IList<CrimsonHexagonItem> result = new List<CrimsonHexagonItem>(1);
            result.Add(new CrimsonHexagonItem
            {
                Id = this.id,
                Description = string.Format("{0} - {1}", this.name, this.type),
                Type = "MonitorDetail"

            });

            return result;
        }
    }
}
