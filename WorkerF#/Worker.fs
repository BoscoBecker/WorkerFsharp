namespace WorkerF_

open System
open System.Threading
open System.Threading.Tasks
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open GetData

type Worker(logger: ILogger<Worker>) =
    inherit BackgroundService()

    override _.ExecuteAsync(ct: CancellationToken) =
        task {
            while not ct.IsCancellationRequested do
                logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now)            
                
                let url = "https://gist.githubusercontent.com/BoscoBecker/b343b480631ca61b0b06f4dca6b23139/raw/440f560f86627871789eabdc4c86b4e819ddc9b1/data.json"                
                let client = ApiClient()
                let resultado = client.GetAsync url
                                |> Async.AwaitTask
                                |> Async.RunSynchronously

                printfn "Nome: %s" resultado.pessoa.nome
                printfn "Cidade: %s" resultado.pessoa.cidade
                printfn "Estado: %s" resultado.pessoa.Estado
                printfn "Pais: %s" resultado.pessoa.pais                                
                do! Task.Delay(1000)
        }
