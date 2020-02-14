module InputDataReader

open System.IO

let fileName = "ORDERS.TXT"
let directory = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar.ToString() + "DATA"
let dataSource = directory + Path.DirectorySeparatorChar.ToString() + fileName

let inputData = File.ReadAllLines(dataSource).ToString()