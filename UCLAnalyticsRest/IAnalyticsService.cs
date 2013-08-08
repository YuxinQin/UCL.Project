using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer
{
    public interface IAnalyticsService
    {
       // object createBond(AnalyticsRefData analyticsRefData);
        Evaluation GetBondPrice(AnalyticsRefData analyticsRefData, double yield);

        Evaluation GetBondYield(AnalyticsRefData analyticsRefData, double price);

        Evaluation GetBondEvaluation(AnalyticsRefData analyticsRefData, string quoteType, double quote, string tradeDate,
                         string settleDate, int notional);

        Evaluation GetBondAccrued(AnalyticsRefData analyticsRefData, double price);

    }
}
