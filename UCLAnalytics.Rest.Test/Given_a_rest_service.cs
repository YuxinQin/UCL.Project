using NUnit.Framework;
using OpenRasta.Configuration;
using UCLAnalytics.Rest.TestServer;
using UCLAnalytics.Rest.TestServer.Repositories;

namespace UCLAnalytics.Rest.Test
{
    public abstract class Given_a_rest_service
    {
        internal RestServer RestServer;

        protected abstract IConfigurationSource Config { get; }

        protected virtual string ServerName
        {
            get { return "localhost"; }
        }

        protected virtual int Port
        {
            get { return 8090; }
        }

        [TestFixtureSetUp]
        public void StartServer()
        {
            MockRefDataRepository.Reset();

            RestServer = new RestServer();
            RestServer.Start(ServerName, Port, Config);

            OnServerStarted();
        }

        [TestFixtureTearDown]
        public void StopServer()
        {
            RestServer.Stop();

            OnServerStopped();
        }

        protected virtual void OnServerStarted() { }

        protected virtual void OnServerStopped() { }
    }
}
