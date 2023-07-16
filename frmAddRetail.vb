Public Class frmAddRetail

    Private customer As Customer

    Public Function GetNewCustomer() As Customer
        Me.ShowDialog()
        Return customer
    End Function

    Private Sub btnSave_Click(sender As Object,
            e As EventArgs) Handles btnSave.Click
        If IsValidData() Then
            ' TODO: Add code that creates a retail customer.
            customer = New RetailCustomer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text)
            Me.Close()
        End If

    End Sub

    Private Function IsValidData() As Boolean
        Return Validator.IsPresent(txtFirstName) AndAlso
               Validator.IsPresent(txtLastName) AndAlso
               Validator.IsPresent(txtEmail) AndAlso
               Validator.IsValidEmail(txtEmail) AndAlso
               Validator.IsPresent(txtPhone)
    End Function

    Private Sub btnCancel_Click(sender As Object,
            e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class