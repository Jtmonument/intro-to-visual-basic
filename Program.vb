Imports System

Module Program
    Sub Main(args As String())
        Dim grade As Decimal = 59.9
        If grade >= 60 Then
            Console.WriteLine("You passed!")
        ElseIf grade >= 59 AndAlso grade < 60 Then
            Console.WriteLine("You were so close!")
        Else
            Console.WriteLine("You failed horribly!")
        End If
    End Sub
End Module
