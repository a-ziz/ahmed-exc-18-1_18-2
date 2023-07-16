Public Class frmCustomerMaintenance

    Dim WithEvents customers As New CustomerList

    Private Sub frmCustomerMaintenance_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        customers.Fill()
        Me.FillCustomerListBox()
    End Sub

    Private Sub FillCustomerListBox()
        lstCustomers.Items.Clear()
        'Dim c As Customer
        'For i As Integer = 0 To customers.Count - 1
        '    c = customers(i)
        '    lstCustomers.Items.Add(c.GetDisplayText)
        'Next
        For Each thisCustomer As Customer In customers
            lstCustomers.Items.Add(thisCustomer.GetDisplayText)
        Next
    End Sub

    Private Sub btnAddWholesale_Click(sender As Object,
            e As EventArgs) Handles btnAddWholesale.Click
        Dim wholesaleCustomerForm As New frmAddWholesale
        Dim customer As Customer = wholesaleCustomerForm.GetNewCustomer()
        If customer IsNot Nothing Then
            customers.Add(customer)
            customers.Save()
            Me.FillCustomerListBox()
        End If
    End Sub

    Private Sub btnAddRetail_Click(sender As Object,
            e As EventArgs) Handles btnAddRetail.Click
        Dim retailCustomerForm As New frmAddRetail
        Dim customer As Customer = retailCustomerForm.GetNewCustomer()
        If customer IsNot Nothing Then
            customers.Add(customer)
            customers.Save()
            Me.FillCustomerListBox()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object,
            e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstCustomers.SelectedIndex
        If i <> -1 Then
            Dim customer As Customer = customers(i)
            Dim message As String = "Are you sure you want to delete " &
                customer.FirstName & " " & customer.LastName & "?"
            Dim button As DialogResult = MessageBox.Show(message,
                "Confirm Delete", MessageBoxButtons.YesNo)
            If button = DialogResult.Yes Then
                customers -= customer
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub customers_Changed(customers As CustomerList) _
            Handles customers.Changed
        customers.Save()
        Me.FillCustomerListBox()
    End Sub

End Class
