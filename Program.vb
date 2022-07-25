Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Try
            Dim num As String = "some text"
            Convert.ToInt32(num)
        Catch ex As Exception
            Throw New Exception("Not able to parse! " & ex.Message)
        Finally
            Console.WriteLine("Program terminating...")
        End Try
    End Sub
End Module
