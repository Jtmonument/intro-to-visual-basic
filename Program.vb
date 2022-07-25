Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim abram As Human = New Human("Abram")
        abram.Gender = Sex.MALE
        Dim sarai As Human = New Human("Sarai")
        sarai.Gender = Sex.FEMALE
        Dim hagar As Human = New Human("Hagar")
        sarai.Gender = Sex.FEMALE
        Dim humans As List(Of Human) = New List(Of Human)
        humans.Add(abram)
        humans.Add(sarai)
        humans.Add(hagar)
        humans.Sort()

        For i = 0 To humans.Count - 1
            Console.WriteLine(humans(i))
        Next
    End Sub
End Module
