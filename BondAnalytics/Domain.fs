module Domain

type BondTypes =
    | ZeroCouponBond
    | FixedCouponBond
    | IndexLinkedBond

type IssueCountries = 
    | USA
    | UK

type Indicative = {
    BondType: BondTypes
    Maturity: System.DateTime
    Coupon: float
    LastInterestDate: System.DateTime
    FirstCouponDate: System.DateTime
    IssueDate: System.DateTime
    Currencies: string
    Frequencies: int
    IssueCountry: IssueCountries
    Nominal: int
    IssuePrice: double
    IssueAmount: int
    Inflationdetail: string
    }

type Trade = {
    Cusip: string;
    TradeDate: System.DateTime;
    PriceTraded: double;
    NotionalTraded: int;
    RepoCurveName: string;
    InflationModelName: string;
    CreditCurve: string;
    TermSheet : Indicative
    }



    