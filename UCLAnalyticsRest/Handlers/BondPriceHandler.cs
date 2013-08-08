using System.Collections.Generic;
using OpenRasta.Web;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Handlers
{
    public class BondPriceHandler
    {
        private readonly IGetRefData _refDataFetcher;
        private readonly IAnalyticsService _analytics;

        public BondPriceHandler(IGetRefData refDataFetcher, IAnalyticsService analytics)
        {
            _refDataFetcher = refDataFetcher;
            _analytics = analytics;
        }

        public OperationResult GetBondPrice (string cusip, double yield)
        {
            try
            {
                var refData = _refDataFetcher.GetByCusip(cusip);

                var analyticsRefData = RefDataMapping.Map(refData);
                //  var analyticsRefData = RefDataMapping.JsonDeserialise<AnalyticsRefData>(refData);
              //  var bond = mockAnalytics.createBond(analyticsRefData);

                return new OperationResult.OK { ResponseResource = _analytics.GetBondPrice(analyticsRefData, yield) };
            }

            catch (KeyNotFoundException ex)
            {
                return new OperationResult.BadRequest { ResponseResource = ex.StackTrace };
            }

        }
    }
}
