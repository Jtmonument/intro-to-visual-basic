Imports System

Module Program
    Sub Main(args As String())
        Do
            Console.Write("Do you want to exit (Y/n): ")
        Loop While Not Console.ReadLine().ToLower().Equals("y")

        Console.WriteLine(New String("-", 5))

        Do
            Console.Write("Do you want to exit (Y/n): ")
        Loop Until Console.ReadLine().ToLower().Equals("y")

        Console.WriteLine(New String("*", 5))

        While True
            Console.Write("Do you want to exit (Y/n): ")
            If Console.ReadLine().ToLower().Equals("y") Then
                Exit While
            End If
        End While

        Console.WriteLine(New String("+", 5))

        Do While True
            Console.Write("Do you want to exit (Y/n): ")
            If Console.ReadLine().ToLower().Equals("y") Then
                Exit Do
            End If
        Loop

        Console.WriteLine(New String("=", 5))

        For i = 0 To 10
            If i Mod 2 <> 0 Then
                Continue For
            End If
            Console.WriteLine(i)
        Next
    End Sub
End Module
