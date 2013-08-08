using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer
{
    public class MockRefDataFetcher : IGetRefData
    {
        private readonly HttpRefDataService _httpRefDataService;
        private readonly string _url;

        public MockRefDataFetcher(string url)
        {
            _httpRefDataService = new HttpRefDataService();
            _url = url;
        }

        public RefData GetByCusip(string cusip)
        {
            Console.WriteLine("Reached MockRefDataFetcher");
            return _httpRefDataService.GetByCusip(_url, cusip);
        }
    }
}
