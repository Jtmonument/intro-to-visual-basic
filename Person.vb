Public Class Person
    Protected fullName As String

    Public Property Name As String
        Get
            Return fullName
        End Get
        Set(value As String)
            fullName = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return fullName
    End Function
End Class
