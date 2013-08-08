using System.Collections.Generic;
using OpenRasta.Web;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Handlers
{
    public class BondEvHandler
    {
        private readonly IGetRefData _refDataFetcher;
        private readonly IAnalyticsService _analytics;

        public BondEvHandler(IGetRefData refDataFetcher, IAnalyticsService analytics)
        {
            _refDataFetcher = refDataFetcher;
            _analytics = analytics;
        }

        public OperationResult GetBondAccrued(string cusip, string quoteType, double quote, string tradeDate,
           string settleDate, int notional)
        {
            try
            {
                var refData = _refDataFetcher.GetByCusip(cusip);

                var analyticsRefData = RefDataMapping.Map(refData);
         //       var analyticsRefData = RefDataMapping.JsonDeserialise<AnalyticsRefData>(refData);
      //          var bond = mockAnalytics.createBond(analyticsRefData);

                return new OperationResult.OK
                {
                    ResponseResource = _analytics.GetBondEvaluation(analyticsRefData, quoteType,
                    quote, tradeDate, settleDate, notional) };
            }

            catch (KeyNotFoundException ex)
            {
                return new OperationResult.BadRequest { ResponseResource = ex.StackTrace };
            }
        }

    }
}
