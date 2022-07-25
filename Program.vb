Imports System

Module Program
    Sub Main(args As String())
        Dim nArray() As Integer
        Dim nArray1(5) As Integer
        Dim nArray2() As Integer = {1, 2, 3}
        Dim nArray3() As Integer = New Integer(5) {}
        nArray = New Integer(5) {}
        Console.WriteLine(nArray(0))
        Console.WriteLine(nArray2(1))

        For i = 0 To nArray2.Length - 1
            Console.WriteLine(nArray2(i))
        Next
        Dim str As String = "Hello"
        Console.WriteLine(str(0))
    End Sub
End Module
