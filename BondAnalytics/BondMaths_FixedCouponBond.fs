module BondMaths_FixedCouponBond


open Domain
open Create


//Fixed Coupon Bond Calcs
let yield_FixedCouponBond (trade:Trade) = 0.1

let price_FixedCouponBond (trade:Trade) = 
    let a = (trade.TermSheet.LastInterestDate - trade.TradeDate.AddDays(3.0)).TotalDays/365.0
    let b = trade.PriceTraded*(1.0- 1.0/(1.0 + trade.TermSheet.Coupon)**a)/trade.TermSheet.Coupon + 1000.0/((1.0+trade.TermSheet.Coupon)**a)
    b

let Accrued_FixedCouponBond (trade:Trade) = 
    (trade.TermSheet.LastInterestDate - trade.TradeDate.AddDays(3.0)).TotalDays * trade.TermSheet.Coupon/365.0


