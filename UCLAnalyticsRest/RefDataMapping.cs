using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer
{
    public class RefDataMapping
    {
        public static AnalyticsRefData Map(RefData data)
        {
            AnalyticsRefData analyticsRefData = new AnalyticsRefData();

            analyticsRefData.Cusip = data.Cusip;
            analyticsRefData.BondType = data.BondType;
            analyticsRefData.Maturity = data.Maturity;
            analyticsRefData.Coupon = data.Coupon;
            analyticsRefData.lastInterestDay = data.lastInterestDay;
            analyticsRefData.firstCouponDate = data.firstCouponDate;
            analyticsRefData.issueDate = data.issueDate;
            analyticsRefData.currencies = data.currencies;
            analyticsRefData.frequencies = data.frequencies;
            analyticsRefData.issueCountry = data.issueCountry;
            analyticsRefData.nominal = data.nominal;
            analyticsRefData.issuePrice = data.issuePrice;
            analyticsRefData.issueAmount = data.issueAmount;
            analyticsRefData.inflationDetail = data.inflationDetail;
            analyticsRefData.creditCurve = data.creditCurve;

            return analyticsRefData;
        }
    }


    //    /// <summary>
    //    /// JSON Deserialization
    //    /// </summary>
    //    /// 
    //    public static AnalyticsRefData JsonDeserialise<AnalyticsRefData>(string jsonString)
    //    {
    //        string p = @"\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}";
    //        MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertDateStringToJsonDate);
    //        Regex reg = new Regex(p);
    //        jsonString = reg.Replace(jsonString, matchEvaluator);
    //        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(AnalyticsRefData));
    //        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
    //        AnalyticsRefData obj = (AnalyticsRefData)ser.ReadObject(ms);
    //        return obj;
    //    }

    //    /// <summary>
    //    /// JSON Serialization
    //    /// </summary>
    //    /// 
    //    public static string JsonSerialize<T>(T t)
    //    {
    //        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
    //        MemoryStream ms = new MemoryStream();
    //        ser.WriteObject(ms, t);
    //        string jsonString = Encoding.UTF8.GetString(ms.ToArray());
    //        ms.Close();
    //        //Replace Json Date String                                         
    //        string p = @"\\/Date\((\d+)\+\d+\)\\/";
    //        MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertJsonDateToDateString);
    //        Regex reg = new Regex(p);
    //        jsonString = reg.Replace(jsonString, matchEvaluator);
    //        return jsonString;
    //    }


    //    /// <summary>
    //    /// Convert Date String as Json Time
    //    /// </summary>
    //    /// 
    //    private static string ConvertDateStringToJsonDate(Match m)
    //    {
    //        string result = string.Empty;
    //        DateTime dt = DateTime.Parse(m.Groups[0].Value);
    //        dt = dt.ToUniversalTime();
    //        TimeSpan ts = dt - DateTime.Parse("1970-01-01");
    //        result = string.Format("\\/Date({0}+0800)\\/", ts.TotalMilliseconds);
    //        return result;
    //    }


    //    /// <summary>
    //    /// Convert Serialization Time /Date(1319266795390+0800) as String
    //    /// </summary>
    //    /// 
    //    private static string ConvertJsonDateToDateString(Match m)
    //    {
    //        string result = string.Empty;
    //        DateTime dt = new DateTime(1970, 1, 1);
    //        dt = dt.AddMilliseconds(long.Parse(m.Groups[1].Value));
    //        dt = dt.ToLocalTime();
    //        result = dt.ToString("yyyy-MM-dd HH:mm:ss");
    //        return result;
    //    }
    //}
}
