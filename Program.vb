Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim person As Person = New Person
        Console.WriteLine(person)
        person.MyName = "John"
        Console.WriteLine(person)
        Console.WriteLine(person.GetHash())
        person = New Person("Jane")
        Console.WriteLine(person)
    End Sub
End Module
