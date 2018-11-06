namespace VendingMachineFx.Web
    module Main =
        open System.IO
        open Microsoft.AspNetCore.Hosting
        open VendingMachineFx.Web.Config


        [<EntryPoint>]
        let main _ =
            let host = 
                WebHostBuilder()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .Build()

            host.Run()
            0