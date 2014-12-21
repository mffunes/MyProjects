using System.Collections.Generic;
using System.Linq;
using CrimsonHexagon.Config;
using CrimsonHexagon.Model;
using FeedModel;
using FeedModel.FeedSources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sources.Infrastructure.Dal;

namespace CrimsonHexagon.IntegrationTest
{
    [TestClass]
    public class CrimsonHexagonPollerTest
    {
        [TestMethod]
        public void TestCrimsonHexagonMonitorListPoller()
        {
            CrimsonHexagonMonitorListSourceConfig config = new CrimsonHexagonMonitorListSourceConfig
            {
                Id = 1,
                Method = "monitor/list"
            };

            CassandraConfiguration cassandraConfiguration = new CassandraConfiguration
            {
                ClusterAddress = "127.0.0.1",
                Keyspace = "demo"
            };

            CassandraContext<CrimsonHexagonItem> cassandraContext = new CassandraContext<CrimsonHexagonItem>(cassandraConfiguration);

            IPoller poller = new CrimsonHexagonPoller("CrimsonHexagon", config, cassandraContext);
            poller.Poll();

            IList<CrimsonHexagonItem> items = cassandraContext.GetAllItems();

            Assert.IsTrue(items.Any());
        }

        [TestMethod]
        public void TestCrimsonHexagonMonitorDetailPoller()
        {
            CrimsonHexagonMonitorDetailSourceConfig config = new CrimsonHexagonMonitorDetailSourceConfig
            {
                Id = 1,
                Method = "monitor/detail",
                Properties = new[] { new FeedConfigurationProperty("MonitorId", "1302325110") }
            };

            CassandraConfiguration cassandraConfiguration = new CassandraConfiguration
            {
                ClusterAddress = "127.0.0.1",
                Keyspace = "demo"
            };

            CassandraContext<CrimsonHexagonItem> cassandraContext = new CassandraContext<CrimsonHexagonItem>(cassandraConfiguration);

            IPoller poller = new CrimsonHexagonPoller("CrimsonHexagon", config, cassandraContext);
            poller.Poll();

            IList<CrimsonHexagonItem> items = cassandraContext.GetAllItems();

            Assert.IsTrue(items.Any());
        }
    }
}
