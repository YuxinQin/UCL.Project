module Create

open Domain

let date y m d = new System.DateTime(y,m,d)

let createBondIndicative = 
    let refdata = {
        BondType = ZeroCouponBond
        Maturity = date 2012 12 31
        Coupon = 1.3
        LastInterestDate = date 2013 01 01
        FirstCouponDate = date 2013 01 01
        IssueDate = date 2013 01 01
        Currencies = ""
        Frequencies = 1
        IssueCountry = UK
        Nominal = 100
        IssuePrice = 1000.0
        IssueAmount = 100
        Inflationdetail = ""
    }
    refdata

let createTrade termSheet = 
    let refdata = {
        Cusip = "11111aaaa";
        TradeDate = date 2013 01 01 ;
        PriceTraded = 62.4;
        NotionalTraded = 100;
        RepoCurveName = "";
        InflationModelName="";
        CreditCurve = "";
        TermSheet = termSheet

    }
    refdata

