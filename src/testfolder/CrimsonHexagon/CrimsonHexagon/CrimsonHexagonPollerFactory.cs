using System;
using System.Collections.Generic;
using CrimsonHexagon.Config;
using CrimsonHexagon.Model;
using FeedModel;
using Sources.Infrastructure.Dal;
using SourcesFramework;

namespace CrimsonHexagon
{
    public class CrimsonHexagonPollerFactory : PollerFactory
    {
        protected virtual Func<CassandraContext<CrimsonHexagonItem>> CassandraContext
        {
            get
            {
                CassandraConfiguration configuration = new CassandraConfiguration();
                configuration.ClusterAddress = "127.0.0.1";
                configuration.Keyspace = "demo";

                return () => new CassandraContext<CrimsonHexagonItem>(configuration);
            }
        }

        public override IList<IPoller> GetPollers()
        {
            List<IPoller> pollers = new List<IPoller>();

            //TODO: Replace it with call to context
            List<ICrimsonHexagonSourceConfig> configs = new List<ICrimsonHexagonSourceConfig>();

            foreach (ICrimsonHexagonSourceConfig config in configs)
            {
                pollers.Add(new CrimsonHexagonPoller("CrimsonHexagon", config, this.CassandraContext.Invoke()));
            }

            return pollers;
        }

        public override IPoller GetPoller(long configId)
        {
            throw new NotImplementedException();
        }

        public override IFeedConfiguration GetDefaultConfig()
        {
            throw new NotImplementedException();
        }

        public override IFeedConfiguration SaveConfig(IFeedConfiguration config)
        {
            throw new NotImplementedException();
        }

        public override IFeedConfiguration GetConfig(long configId)
        {
            throw new NotImplementedException();
        }

        public override void DeleteConfig(long configId)
        {
            throw new NotImplementedException();
        }

        public override string SourceType
        {
            get { return "CrimsonHexagon"; }
        }
    }
}
