

namespace UCLAnalytics.Rest.TestServer.Resources
{
    public class RefData
    {
        public string Cusip { get; set; }
        public string BondType { get; set; }
        public float Maturity { get; set; }
        public float Coupon { get; set; }
        public string lastInterestDay { get; set; }
        public string firstCouponDate { get; set; }
        public string issueDate { get; set; }
        public string currencies { get; set; }
        public int frequencies { get; set; }
        public string issueCountry { get; set; }
        public int nominal { get; set; }
        public double issuePrice { get; set; }
        public int issueAmount { get; set; }
        public string inflationDetail { get; set; }
        public string creditCurve { get; set; }
    }
}
