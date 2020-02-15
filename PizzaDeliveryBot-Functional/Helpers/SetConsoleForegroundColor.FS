module SetConsoleForegroundColor

open System

let consoleColor (foregroundColor : ConsoleColor) = 
    let currentForegroundColor = Console.ForegroundColor
    Console.ForegroundColor <- foregroundColor
    { new IDisposable with
          member _console.Dispose() = Console.ForegroundColor <- currentForegroundColor }