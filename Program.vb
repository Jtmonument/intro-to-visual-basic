Imports System

Module Program
    Sub Main(args As String())
        Dim factorial As Integer = 1
        For i = 1 To 5
            factorial *= i
        Next
        Console.WriteLine(factorial)

        For i = 0 To 10 Step 2
            Console.WriteLine(i)
        Next
    End Sub
End Module
