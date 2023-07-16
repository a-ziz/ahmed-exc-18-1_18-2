Public Class frmAddCustomer

    Public Customer As Customer

    Private Sub btnSave_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnSave.Click
        If IsValidData() Then
            Customer = New Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text)
            Me.Close()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Return Validator.IsPresent(txtFirstName) AndAlso _
               Validator.IsPresent(txtLastName) AndAlso _
               Validator.IsPresent(txtEmail) AndAlso _
               Validator.IsValidEmail(txtEmail)
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class