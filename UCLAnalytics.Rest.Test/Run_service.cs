using System;
using System.Threading;
using NUnit.Framework;
using OpenRasta.Configuration;
using OpenRastaConfiguration = UCLAnalytics.Rest.TestServer.Config.WebConfiguration;


namespace UCLAnalytics.Rest.Test
{
    public class Run_service : Given_a_rest_service
    {
        protected override IConfigurationSource Config
        {
            get { return new OpenRastaConfiguration(); }
        }

        [Explicit]
        [Test]
        public void Run_for()
        {
            Thread.Sleep(TimeSpan.FromHours(1));
        }
    }
}
