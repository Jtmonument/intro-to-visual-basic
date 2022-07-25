Imports System

Module Program
    Sub Main(args As String())
        Dim person As Person = New Person
        person.Name = "John Doe"
        Console.WriteLine(person.Name)
        Console.WriteLine(person.GetFirstName)
        Console.WriteLine(person.GetLastName)
        Dim copy As String = ""
        person.SendNameByRef(copy)
        Console.WriteLine(copy)
        person.RemoveName()
        Console.WriteLine(New String("-", 9))
        Console.WriteLine(person.Name)
    End Sub
End Module
