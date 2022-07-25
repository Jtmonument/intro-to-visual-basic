Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        work(New BackEndDeveloper())
        work(New FrontEndDeveloper())
    End Sub

    Sub work(employee As Workable)
        employee.work()
    End Sub
End Module
