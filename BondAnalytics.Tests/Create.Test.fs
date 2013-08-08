module Create.Test

open fsunit
open Domain
open Create
open NUnit.Framework
open NUnit.Framework.Constraints


let date y m d = new System.DateTime(y,m,d)
//Indicative
let BondType v (b:Indicative) =
    let refdata = {
        BondType = v
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let Maturity v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = v
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let Coupon v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = v
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let LastInterestDate v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = v
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let FirstCouponDate v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = v
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let IssueDate v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = v
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let Currencies v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = v
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let Frequencies v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = v
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let IssueCountry v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = v
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let Nominal v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = v
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let IssuePrice v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = v
        IssueAmount = b.IssueAmount
        Inflationdetail = b.Inflationdetail
    }
    refdata

let IssueAmount v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = v
        Inflationdetail = b.Inflationdetail
    }
    refdata



let Inflationdetail v (b:Indicative) =
    let refdata = {
        BondType = b.BondType
        Maturity = b.Maturity
        Coupon = b.Coupon
        LastInterestDate = b.LastInterestDate
        FirstCouponDate = b.FirstCouponDate
        IssueDate = b.IssueDate
        Currencies = b.Currencies
        Frequencies = b.Frequencies
        IssueCountry = b.IssueCountry
        Nominal = b.Nominal
        IssuePrice = b.IssuePrice
        IssueAmount = b.IssueAmount
        Inflationdetail = v
    }
    refdata

//trade

let Cusip v (b:Trade) =
    let refdata = {
        Cusip = v;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = b.InflationModelName;
        CreditCurve = b.CreditCurve;
        TermSheet = b.TermSheet;
    }
    refdata

let TradeDate v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = b.InflationModelName;
        CreditCurve = b.CreditCurve;
        TermSheet = b.TermSheet;
    }
    refdata

let PriceTraded v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = v;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = b.InflationModelName;
        CreditCurve = b.CreditCurve;
        TermSheet = b.TermSheet;
    }
    refdata

let NotionalTraded v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = v;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = b.InflationModelName;
        CreditCurve = b.CreditCurve;
        TermSheet = b.TermSheet;
    }
    refdata

let RepoCurveName v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = v;
        InflationModelName = b.InflationModelName;
        CreditCurve = b.CreditCurve;
        TermSheet = b.TermSheet;
    }
    refdata

let InflationModelName v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = v;
        CreditCurve = b.CreditCurve;
        TermSheet = b.TermSheet;
    }
    refdata

let CreditCurve v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = b.InflationModelName;
        CreditCurve = v;
        TermSheet = b.TermSheet;
    }
    refdata

let TermSheet v (b:Trade) =
    let refdata = {
        Cusip = b.Cusip;
        TradeDate = b.TradeDate ;
        PriceTraded = b.PriceTraded;
        NotionalTraded = b.NotionalTraded;
        RepoCurveName = b.RepoCurveName;
        InflationModelName = b.InflationModelName;
        CreditCurve = b.CreditCurve;
        TermSheet = v;
    }
    refdata

//let doit c sd b = b 
//                |> cusip c
//                |> settlementDate sd

[<TestFixture>]
type Create_Bond_Indicative() = class
    let mutable a:Indicative option = None

    [<SetUp>]
       member x.Should_retun_ref_data() = 
        let bond = createBondIndicative 
                 |> Maturity (date 2012 12 31) 
                 |> Coupon  1.0
                 |> LastInterestDate (date 2013 01 01) 
                 |> FirstCouponDate  (date 2013 01 01)
                 |> IssueDate (date 2013 01 01)
                 |> Currencies ""
                 |> Frequencies  1
                 |> IssueCountry UK
                 |> Nominal  100
                 |> IssuePrice 100.0
                 |> IssueAmount  100
                 |> Inflationdetail  ""
        a <- Some bond
    
    [<Test>]               
    member t.BondInicative_Maturity() =
            a.Value.Maturity |> should equal (date 2012 12 31) |> ignore

    [<Test>]               
    member t.BondInicative_Coupon() =
            a.Value.Coupon |> should equal 1.0 |> ignore

    [<Test>]               
    member t.BondInicative_LastInterestDate() =
            a.Value.LastInterestDate |> should equal (date 2013 01 01) |> ignore

    [<Test>]               
    member t.BondInicative_FirstCouponDate() =
            a.Value.FirstCouponDate |> should equal (date 2013 01 01) |> ignore

    [<Test>]               
    member t.BondInicative_IssueDate() =
            a.Value.IssueDate |> should equal (date 2013 01 01) |> ignore

    [<Test>]               
    member t.BondInicative_Currencies() =
            a.Value.Currencies |> should equal "" |> ignore

    [<Test>]               
    member t.BondInicative_Frequencies() =
            a.Value.Frequencies |> should equal 1 |> ignore

    [<Test>]               
    member t.BondInicative_IssueCountry() =
            a.Value.IssueCountry |> should equal UK |> ignore

    [<Test>]               
    member t.BondInicative_Nominal() =
            a.Value.Nominal |> should equal 100 |> ignore

    [<Test>]               
    member t.BondInicative_IssuePrice() =
            a.Value.IssuePrice |> should equal 100.0 |> ignore        

    [<Test>]               
    member t.BondInicative_IssueAmount() =
            a.Value.IssueAmount |> should equal 100 |> ignore

    [<Test>]               
    member t.BondInicative_Inflationdetail() =
            a.Value.Inflationdetail |> should equal "" |> ignore

end

[<TestFixture>]
type Create_Bond_From_Indic() = class

    let mutable b:Trade option = None

    [<SetUp>]
    member x.Should_retun_ref_data() = 
        let bond = createTrade createBondIndicative
                |> Cusip "11111aaaa"
                |> TradeDate (date 2013 01 01)
                |> PriceTraded 0.0
                |> NotionalTraded 100
                |> RepoCurveName ""
                |> InflationModelName ""
                |> CreditCurve ""
                 
 
        b <- Some bond
          
    [<Test>]               
    member t.Trade_Cusip() =
            b.Value.Cusip |> should equal "11111aaaa" |> ignore

    [<Test>]               
    member t.Trade_TradeDate() =
            b.Value.TradeDate |> should equal (date 2013 01 01) |> ignore

    [<Test>]               
    member t.Trade_PriceTraded() =
            b.Value.PriceTraded |> should equal 0.0 |> ignore

    [<Test>]               
    member t.Trade_NotionalTraded() =
            b.Value.NotionalTraded |> should equal 100 |> ignore

    [<Test>]               
    member t.Trade_RepoCurveName() =
            b.Value.RepoCurveName |> should equal "" |> ignore

    [<Test>]               
    member t.Trade_InflationModelName() =
            b.Value.InflationModelName |> should equal "" |> ignore

    [<Test>]               
    member t.Trade_CreaditCurve() =
            b.Value.CreditCurve |> should equal "" |> ignore
            
     
end