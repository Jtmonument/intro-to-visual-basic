Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim stream As FileStream = New FileStream("../../../.gitignore", FileMode.Open, FileAccess.Read)
        Dim readText As StreamReader = New StreamReader(stream)
        Console.WriteLine(readText.ReadLine)
        readText.Close()

        stream = New FileStream("Intro to VB.Net.exe", FileMode.Open, FileAccess.Read)
        Dim readBinary As BinaryReader = New BinaryReader(stream)
        Dim bytes() As Byte = readBinary.ReadBytes(50)
        For Each var In bytes
            Console.Write(Convert.ToChar(var))
        Next
        readBinary.Close()
    End Sub
End Module
