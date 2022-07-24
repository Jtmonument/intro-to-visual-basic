Imports System

Module Program
    Sub Main(args As String())
        Dim number As String = "5.342"
        Console.WriteLine(FormatNumber(number, 2))
        Console.WriteLine(FormatPercent(number))
        Dim parsed As String = "The gas price is " & FormatCurrency(number, 3)
        Console.WriteLine(parsed)
    End Sub
End Module
