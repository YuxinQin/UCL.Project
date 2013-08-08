module fsunit

open NUnit.Framework
open NUnit.Framework.Constraints

let should (f : 'a -> #Constraint) x (y : obj) =
   let c = f x
   let y =
       match y with
       | :? (unit -> unit) -> box (TestDelegate(y :?> unit -> unit))
       | _ -> y
   Assert.That(y, c)
   
let equal x = EqualConstraint(x)

let equal_within tolerance x = equal(x).Within tolerance

let not x = NotConstraint(x)

let contain x = ContainsConstraint(x)

let have_length n = Has.Length.EqualTo(n)

let have_count n = Has.Count.EqualTo(n)

let be = id

let Null = NullConstraint()

let empty = EmptyConstraint()

let empty_string = EmptyStringConstraint()

let null_or_empty_string = NullOrEmptyStringConstraint()

let True = TrueConstraint()

let False = FalseConstraint()

let same_as x = SameAsConstraint(x)

let throw = Throws.TypeOf

let greater_than x = GreaterThanConstraint(x)

let greater_than_Or_equal_to x = GreaterThanOrEqualConstraint(x)

let less_than x = LessThanConstraint(x)

let less_than_or_equal_to x = LessThanOrEqualConstraint(x)

let should_fail (f : unit -> unit) = TestDelegate(f) |> should throw typeof<AssertionException>

let end_with (s:string) = EndsWithConstraint s

let start_with (s:string) = StartsWithConstraint s

let of_exact_type<'a> = ExactTypeConstraint(typeof<'a>)

