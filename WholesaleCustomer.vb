Public Class WholesaleCustomer

    Inherits Customer

    Public Property Company As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(firstName As String, lastName As String, email As String, company As String)
        MyBase.New(firstName, lastName, email)
        Me.Company = company
    End Sub

    Public Overrides Function GetDisplayText() As String
        Return MyBase.GetDisplayText() & " (" & Company & ")"
    End Function

End Class
