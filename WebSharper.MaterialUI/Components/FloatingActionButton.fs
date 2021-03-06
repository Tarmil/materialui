﻿namespace WebSharper.MaterialUI

open WebSharper
open WebSharper.JavaScript

open WebSharper.React
open WebSharper.React.Bindings

[<JavaScript>]
type FloatingActionButton(icon, ?disabled) =
    [<Inline "MaterialUI.FloatingActionButton">]
    let class' () = X<ReactClass>

    interface Component with
        member this.Map () =
            React.CreateElement(class' (), 
                New [
                    "iconClassName" => icon
                    "disabled"      => default' disabled false
                ])
