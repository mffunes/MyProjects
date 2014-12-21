using System.Collections.Generic;
using System.Linq;
using CrimsonHexagon.Client;
using CrimsonHexagon.Config;
using CrimsonHexagon.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrimsonHexagon.IntegrationTest
{
    [TestClass]
    public class CrimsonHexagonClientTest
    {
        [TestMethod]
        public void TestGetMonitorList()
        {
            CrimsonHexagonMonitorListSourceConfig config = new CrimsonHexagonMonitorListSourceConfig
            {
                Id = 1,
                Method = "monitor/list"
            };

            ICrimsonHexagonClient client = CrimsonHexagonFactoryClient.GetCrimsonHexagonClient(config);
            IList<CrimsonHexagonItem> items = client.GetCrimsonHexagonItems();
            Assert.IsTrue(items.Any());
        }
    }
}
