Imports System

Module Program
    Sub Main(args As String())
        Dim nList As New List(Of Integer)
        nList.Add(5)
        Console.WriteLine(nList(0))

        Dim nQueue As New Queue(Of Integer)
        nQueue.Enqueue(1)
        nQueue.Enqueue(2)
        Console.WriteLine(nQueue.Dequeue)
        Console.WriteLine(nQueue.Dequeue)

        Dim nStack As New Stack(Of Integer)
        nStack.Push(1)
        nStack.Push(2)
        Console.WriteLine(nStack.Pop)
        Console.WriteLine(nStack.Pop)
    End Sub
End Module
