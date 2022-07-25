Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim list As New List(Of Integer)
        list.Add(1)
        list.Add(2)
        list.Add(3)
        printNumbers(list)

        Dim name As New String("Jonathan Taylor")
        print(name)
    End Sub

    Sub print(dataStructure As IEnumerable)
        For Each someData In dataStructure
            Console.WriteLine(someData)
        Next
    End Sub

    Sub printNumbers(numbers As IEnumerable(Of Integer))
        For Each num In numbers
            Console.WriteLine(num)
        Next
    End Sub
End Module
