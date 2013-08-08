using System;
using OpenRasta.Configuration;

namespace UCLAnalytics.Rest.TestServer
{
    public class RestServer : IDisposable
    {
        private HttpListenerHostWithConfiguration _listener;

        public void Start(string host, int port, IConfigurationSource openRastaConfiguration)
        {
            _listener = new HttpListenerHostWithConfiguration { Configuration = openRastaConfiguration };

            _listener.Initialize(new[] { string.Format("http://{0}:{1}/", host, port) }, "/", null);
            _listener.StartListening();
        }

        public void Dispose()
        {
            Stop();
        }

        public void Stop()
        {
            if (_listener == null)
            {
                return;
            }

            _listener.StopListening();
            _listener.Close();
            _listener = null;
        }
    }
}
