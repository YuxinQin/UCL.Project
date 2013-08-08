module Analytics

open Domain
open BondMaths_ZeroCouponBond
open BondMaths_FixedCouponBond
open BondMaths_IndexLinkedBond

type BondTypes =
    | ZeroCouponBond
    | FixedCouponBond
    | IndexLinkedBond

type Queries =
    | Yield
    | Price
    | SettleDate
    | Accrued

type Result = 
    | Numeric of System.Double
    | Date of System.DateTime

     
let date y m d = new System.DateTime(y,m,d)

let evaluate query trade = 

     match (trade:Trade).TermSheet.BondType with
        | Domain.ZeroCouponBond ->
         match query with           
            | Yield -> Numeric(trade |> yield_ZeroCouponBond)
            | Price -> Numeric(trade |> price_ZeroCouponBond)
            | Accrued -> Numeric(trade |> Accrued_ZeroCouponBond)
            | SettleDate -> Date(trade|> SettleDate_ZeroCouponBond)
        | Domain.FixedCouponBond ->
         match query with
            | Yield -> Numeric(trade |> yield_FixedCouponBond)
            | Price -> Numeric(trade |> price_FixedCouponBond)
            | Accrued -> Numeric(trade |> Accrued_FixedCouponBond)
            | SettleDate -> Date(trade|> SettleDate_ZeroCouponBond)
        | Domain.IndexLinkedBond ->
         match query with
            | Yield -> Numeric(trade |> yield_IndexLinkedBond)
            | Price -> Numeric(trade |> price_IndexLinkedBond)
            | Accrued -> Numeric(trade |> Accrued_IndexLinkedBond)
            | SettleDate -> Date(trade|> SettleDate_ZeroCouponBond)
        
 