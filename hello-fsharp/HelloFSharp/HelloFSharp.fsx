#r "../packages/Suave/lib/net40/Suave.dll"

open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Suave.Web             // for config

let config = { defaultConfig with bindings = [ HttpBinding.mkSimple HTTP "0.0.0.0" 8080 ] }
startWebServer config (OK "Hello World!")
