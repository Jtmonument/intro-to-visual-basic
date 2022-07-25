Imports System

Module Program
    Sub Main(args As String())
        Dim name As String = "John Doe"
        Console.WriteLine(Str(0))
        Dim names As String() = name.Split(" ")
        Console.WriteLine(names(1).ToUpper)

        Dim now As DateTime = DateTime.Now
        Console.WriteLine(String.Format("{0:d}", now))
        Console.WriteLine(String.Format("{0:D}", now))
        Console.WriteLine(String.Format("{0:M}", now))
        Console.WriteLine(String.Format("{0:MM}", now))
        Console.WriteLine(String.Format("{0:M/d/yyyy}", now))
        Console.WriteLine(String.Format("{0:MM/dd/yyyy}", now))
        Console.WriteLine(String.Format("{0:HH:mm:ss}", now))

        Console.WriteLine(String.Format("{0:c}", 9D))
    End Sub
End Module
