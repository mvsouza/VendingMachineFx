namespace VendingMachineFx.Web.Modules
open Nancy

type HomeModule() as this =
    inherit NancyModule()
    do
        this.Get("/", fun _ -> "Hello World! ✺◟( ͡° ͜ʖ ͡°)◞✺" :> obj)
