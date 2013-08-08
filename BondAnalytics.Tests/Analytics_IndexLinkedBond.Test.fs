module Analytics_IndexLinkedBond

open fsunit
open Domain
open Create
open Analytics
open Create.Test
open NUnit.Framework
open NUnit.Framework.Constraints

let date y m d = new System.DateTime(y,m,d)

[<TestFixture>]
type Analytics_IndexLinkedBond() = class

    let bond = {
        BondType = Domain.BondTypes.ZeroCouponBond
        Maturity = date 2012 12 31
        Coupon = 1.3
        LastInterestDate = date 2013 01 01
        FirstCouponDate = date 2013 01 01
        IssueDate = date 2013 01 01
        Currencies = ""
        Frequencies = 1
        IssueCountry = UK
        Nominal = 100
        IssuePrice = 100.0
        IssueAmount = 100
        Inflationdetail = ""
    }
    let trade termSheet= {
        Cusip = "11111aaaa";
        TradeDate = date 2013 01 01 ;
        PriceTraded = 62.4;
        NotionalTraded = 100;
        RepoCurveName = "";
        InflationModelName="";
        CreditCurve = "";
        TermSheet = termSheet
    }
      
                     
    let mutable getSettleDate = 
      let trade = trade bond
      let result = trade |> evaluate SettleDate
      match result with
        | Numeric x -> x
        | Date x -> 0.0


    let mutable getYield = 
      let trade = trade bond
      let result = trade |> evaluate Yield
      match result with
        | Numeric x -> x
        | Date x -> 0.0
                
    let mutable getPrice = 
      let trade = trade bond
      let result = trade |> evaluate Price
      match result with
        | Numeric x -> x
        | Date x -> 0.0

    let mutable getAccrued = 
      let trade = trade bond
      let result = trade |> evaluate Accrued
      match result with
        | Numeric x -> x
        | Date x -> 0.0

    
    [<Test>]
    member t.bond_getYield() =
        getYield |> should equal 0.062080221915004286 |> ignore

    [<Test>]
    member t.bond_getPrice() =
        getPrice |> should equal 62.4 |> ignore

    [<Test>]
    member t.bond_getAccrued() =
        getAccrued |> should equal 0.1 |> ignore

    [<Test>]
    member t.bond_getSettleDate() =
        getSettleDate |> should equal 0.0 |> ignore

end

