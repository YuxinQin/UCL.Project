module BondMaths_ZeroCouponBond

open Domain
open Create


let date y m d = new System.DateTime(y,m,d)

//Zero Coupon Bond Calcs
let  yield_ZeroCouponBond (trade:Trade) = 
    let a = 100.0/trade.PriceTraded
    let b = date 2005 03 05
    let c = trade.TermSheet.Maturity
    let d = 365.0/(c-b).TotalDays
    a**d-1.0


let  price_ZeroCouponBond (trade:Trade) = 
    let a = 1.0 + yield_ZeroCouponBond(trade: Trade)
    let b = trade.TermSheet.Maturity
    let c = date 2005 03 05
    let d = (b-c).TotalDays/365.0
    100.0/(a**d)

let  SettleDate_ZeroCouponBond (trade:Trade) =
    match (trade:Trade).TermSheet.IssueCountry with
    | USA -> trade.TradeDate.AddDays(1.0)
    | UK -> trade.TradeDate.AddDays(3.0)


let  Accrued_ZeroCouponBond (trade:Trade) = 
    let a = SettleDate_ZeroCouponBond (trade: Trade)
    let b = (a-trade.TermSheet.LastInterestDate).TotalDays/365.0
    let c = trade.TermSheet.Coupon
    c*b