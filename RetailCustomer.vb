Public Class RetailCustomer
    Inherits Customer

    Public Property HomePhone As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(firstName As String, lastName As String, email As String, HomePhone As String)
        MyBase.New(firstName, lastName, email)
        Me.HomePhone = HomePhone
    End Sub

    Public Overrides Function GetDisplayText() As String
        Return MyBase.GetDisplayText() & " ph: " & HomePhone
    End Function

End Class
