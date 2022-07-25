Public Class Human
    Inherits Person
    Implements IComparable

    Private sex As Sex

    Sub New(name As String)
        fullName = name
    End Sub

    Public Property Gender As Sex
        Get
            Return sex
        End Get
        Set(value As Sex)
            sex = value
        End Set
    End Property

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return sex.CompareTo(CType(obj, Human).sex)
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
