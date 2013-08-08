using System;
using System.Collections.Generic;
using OpenRasta.Web;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Handlers
{
    public class RefDataHandler
    {
        private readonly IGetRefData _refDataFetcher;
        private readonly IAnalyticsService _analytics;

        public RefDataHandler(IGetRefData refDataFetcher, IAnalyticsService analytics)
        {
            _refDataFetcher = refDataFetcher;
            _analytics = analytics;
           // mockAnalytics = new MockAnalytics();
        }

        public OperationResult GetByCusip (string cusip)
        {
            Console.WriteLine("Reached RefDataHandler with cusip : " + cusip);

            try
            {
              //  string mockURL = "http://localhost/Repositories/MockRefDataRepository?cusip=" + cusip;

                var refData = _refDataFetcher.GetByCusip(cusip);   

                return new OperationResult.OK 
                { 
                    ResponseResource = refData 
                };
            }

            catch (KeyNotFoundException ex)
            {
                return new OperationResult.BadRequest { ResponseResource = ex.StackTrace }; 
            }
        }
    }
}
