Imports System

Module Program
    Sub Main(args As String())
        Dim number As Integer = "56"
        Console.WriteLine(number)
        Dim str As String = CStr(number)
        Console.WriteLine(str)
        number = 82
        Dim bool As Boolean = Integer.TryParse(str, number)
        Console.WriteLine(bool)
    End Sub
End Module
