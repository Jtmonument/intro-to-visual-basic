Imports System

Module Program
    Sub Main(args As String())
        Dim number As Integer = 5
        Dim parsed As String = "This watermelon costs " & number.ToString("C")
        Console.WriteLine(parsed)
    End Sub
End Module
