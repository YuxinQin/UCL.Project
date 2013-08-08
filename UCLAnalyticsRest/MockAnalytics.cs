using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCLAnalytics.Rest.TestServer.Resources;


namespace UCLAnalytics.Rest.TestServer
{
    class MockAnalytics : IAnalyticsService
    {
        private readonly Evaluation ev;
        
        public MockAnalytics()
        {
            ev = new Evaluation(); 
        }
        public Evaluation GetBondPrice(AnalyticsRefData analyticsRefData, double yield)
        {
            Console.WriteLine("Reached MockAnalytics");
            Console.WriteLine(analyticsRefData.Maturity);

            ev.Result=(100 / ((1 + yield) * analyticsRefData.Maturity - analyticsRefData.Coupon));
            return ev;
        }

        public Evaluation GetBondYield(AnalyticsRefData analyticsRefData, double price)
        {
            ev.Result = 2.54;
            return ev;
        }

        public Evaluation GetBondEvaluation(AnalyticsRefData analyticsRefData, string quoteType, double quote, string tradeDate,
                         string settleDate, int notional)
        {
            ev.Result = quote - analyticsRefData.Coupon;
            return ev;
        }

        public Evaluation GetBondAccrued(AnalyticsRefData analyticsRefData, double price)
        {
            ev.Result = price - analyticsRefData.issuePrice;
            return ev;
        }
    }
}
