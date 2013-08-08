using System.Collections.Generic;
using OpenRasta.Web;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Handlers
{
    class BondAccruedHandler
    {
        private readonly IGetRefData _refDataFetcher;
        private readonly IAnalyticsService _analytics;

        public BondAccruedHandler(IGetRefData refDataFetcher, IAnalyticsService analytics)
        {
            _refDataFetcher = refDataFetcher;
            _analytics = analytics;
        }

        public OperationResult GetBondAccrued(string cusip, double price)
        {
            try
            {
                var refData = _refDataFetcher.GetByCusip(cusip);

                var analyticsRefData = RefDataMapping.Map(refData);

                return new OperationResult.OK
                { 
                    ResponseResource = _analytics.GetBondAccrued(analyticsRefData, price) 
                };
            }

            catch (KeyNotFoundException ex)
            {
                return new OperationResult.BadRequest { ResponseResource = ex.StackTrace };
            }

        }
    }
}
