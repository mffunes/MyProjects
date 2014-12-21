using System;
using System.Collections.Generic;
using CrimsonHexagon.Client;
using CrimsonHexagon.Config;
using CrimsonHexagon.Model;
using FeedModel;
using Sources.Infrastructure;
using Sources.Infrastructure.Dal;

namespace CrimsonHexagon
{
    public class CrimsonHexagonPoller : BasePoller<CrimsonHexagonItem, ICrimsonHexagonClient>
    {
        private DateTime LastTimePolled { get; set; }

        public CrimsonHexagonPoller(string name, IFeedConfiguration configuration, CassandraContext<CrimsonHexagonItem> databaseContext)
            : base(name, configuration, databaseContext)
        {
            this.Client = CrimsonHexagonFactoryClient.GetCrimsonHexagonClient((ICrimsonHexagonSourceConfig)configuration);
            this.LastTimePolled = DateTime.MinValue;
        }

        protected override IList<CrimsonHexagonItem> GetItems()
        {
            IList<CrimsonHexagonItem> items = this.Client.GetCrimsonHexagonItems();

            return items;
        }

        protected override bool IsTimeToPoll()
        {
            //TODO: Define time
            if (LastTimePolled.AddSeconds(30) > DateTime.Now)
            {
                return false;
            }

            return base.IsTimeToPoll();
        }

        protected override void FinishPolling()
        {
            this.LastTimePolled = DateTime.Now;
        }
    }
}
