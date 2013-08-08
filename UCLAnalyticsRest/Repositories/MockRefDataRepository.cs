using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Repositories
{
    public static class MockRefDataRepository
    {
        private static Dictionary<string, RefData> _refData = new Dictionary<string, RefData>();

        public static void Reset()
        {
            _refData = new Dictionary<string, RefData> 
            {
                { "10000", new RefData { Cusip = "10000", BondType = "Fixed Coupon", Maturity = 1.101F,
                                         Coupon =1.25F, lastInterestDay = "20/03/2005", firstCouponDate = "20/01/2005",
                                         issueDate = "20/12/2004", currencies = "GBP", frequencies = 2, issueCountry = "UK",
                                         nominal = 5, issuePrice = 80.03, issueAmount = 10000, inflationDetail = "none",
                                         creditCurve = "none"} },
                { "20000", new RefData { Cusip = "20000", BondType = "Zero Coupon", Maturity = 1.5F,
                                         Coupon = 0, lastInterestDay = "20/03/2008", firstCouponDate = "20/01/2008",
                                         issueDate = "20/12/2007", currencies = "GBP", frequencies = 1, issueCountry = "UK",
                                         nominal = 3, issuePrice = 58.23, issueAmount = 20000, inflationDetail = "none",
                                         creditCurve = "none" } }
            };
        }

        public static RefData GetByCusip(string cusip)
        {
            Console.WriteLine("Reached MockRefDataRepository GetByCusip");
            return _refData.Values.First(x => x.Cusip == cusip);
        }
    }
}
