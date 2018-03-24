namespace fsharpformsnetstandard

open Xamarin.Forms
open Xamarin.Forms.Xaml

type fsharpformsnetstandardPage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<fsharpformsnetstandardPage>)
