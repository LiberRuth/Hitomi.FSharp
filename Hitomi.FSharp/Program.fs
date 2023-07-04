open System
open System.Threading.Tasks
open Hitomi.NET

HitomiWebp.threads <- 4

let downloadImageAsync id =
    async {
        let! result = Task.Run(fun () -> HitomiWebp.HitomiDownload(id)) |> Async.AwaitTask
        printfn "다운로드 완료"
    }

let result = downloadImageAsync 1767019
result |> Async.RunSynchronously

