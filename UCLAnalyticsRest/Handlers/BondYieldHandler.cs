using System.Collections.Generic;
using OpenRasta.Web;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Handlers
{
    public class BondYieldHandler
    {
        private readonly IGetRefData _refDataFetcher;
        private readonly IAnalyticsService _analytics;

        public BondYieldHandler(IGetRefData refDataFetcher, IAnalyticsService analytics)
        {
            _refDataFetcher = refDataFetcher;
            _analytics = analytics;
        }

        public OperationResult GetBondYield (string cusip, double price)
        {
            try
            {
                var refData = _refDataFetcher.GetByCusip(cusip);

                var analyticsRefData = RefDataMapping.Map(refData);
      //          var bond = mockAnalytics.createBond(analyticsRefData);

                return new OperationResult.OK { ResponseResource = _analytics.GetBondYield(analyticsRefData, price) };
            }

            catch (KeyNotFoundException ex)
            {
                return new OperationResult.BadRequest { ResponseResource = ex.StackTrace };
            }

        }

    }
}
