Public Class Person
    Private firstName As String
    Private lastName As String
    Public Property Name As String
        Get
            Return firstName & " " & lastName
        End Get
        Set(value As String)
            Dim sep As Integer = value.IndexOf(" ")
            firstName = value.Substring(0, sep)
            lastName = value.Substring(sep + 1)
        End Set
    End Property

    Public Function GetFirstName() As String
        Return firstName
    End Function

    Public Function GetLastName() As String
        Return lastName
    End Function

    Sub RemoveName()
        firstName = ""
        lastName = ""
    End Sub

    Sub SendNameByRef(ByRef name As String)
        name = Me.Name
    End Sub
End Class
