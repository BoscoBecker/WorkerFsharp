namespace GetData

open System.Net.Http
open System.Text.Json
open Pessoa

    type ApiClient() =
        let httpClient = new HttpClient()
        member _.GetAsync (url: string) =
            task {
                let! response = httpClient.GetAsync(url)
                response.EnsureSuccessStatusCode() |> ignore
                
                printf  "Fetching...\n"
                
                let! content = response.Content.ReadAsStringAsync()
                let options = JsonSerializerOptions(PropertyNameCaseInsensitive = true)
                let data = JsonSerializer.Deserialize<Response>(content, options)
               
               return data
            }