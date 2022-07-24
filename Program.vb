Imports System

Module Program
    Sub Main(args As String())
        Dim finalGrade As String = "B"
        Select Case finalGrade
            Case "A"
                Console.WriteLine("4.0 GPA")
            Case "B"
                Console.WriteLine("3.0 GPA")
            Case "C"
                Console.WriteLine("2.0 GPA")
            Case "D"
                Console.WriteLine("1.0 GPA")
            Case Else
                Console.WriteLine("0.0 GPA")
        End Select
    End Sub
End Module
