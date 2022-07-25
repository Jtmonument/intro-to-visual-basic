Imports System

Module Program
    Sub Main(args As String())
        Dim nArray(3, 3) As Integer ' Multi-dimensional Array
        For i = 0 To 2
            For j = 0 To 2
                nArray(i, j) = j + 1
                Console.WriteLine(nArray(i, j))
            Next
        Next

        Dim nArray1(5)() As Integer ' Jagged Array
    End Sub
End Module
