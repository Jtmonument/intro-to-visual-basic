Public Class Person
    Private name As String

    Sub New()

    End Sub

    Sub New(name As String)
        Me.name = name
    End Sub

    Public Property MyName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Function GetHash() As Integer
        Return MyClass.GetHashCode()
    End Function

    Public Overrides Function ToString() As String
        If name <> vbNullString Then
            Return name
        End If
        Return MyBase.ToString()
    End Function
End Class
