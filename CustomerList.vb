Public Class CustomerList
    Inherits List(Of Customer)

    Public Event Changed(customers As CustomerList)

    Default Public Shadows Property Item(index As Integer) As Customer
        Get
            Return MyBase.Item(index)
        End Get
        Set(value As Customer)
            MyBase.Item(index) = value
        End Set
    End Property

    Public Shadows Sub Add(customer As Customer)
        MyBase.Add(customer)
        RaiseEvent Changed(Me)
    End Sub

    Public Shadows Sub Remove(customer As Customer)
        MyBase.Remove(customer)
        RaiseEvent Changed(Me)
    End Sub

    Public Shared Operator +(cl As CustomerList, c As Customer) _
            As CustomerList
        cl.Add(c)
        Return cl
    End Operator

    Public Shared Operator -(cl As CustomerList, c As Customer) _
            As CustomerList
        cl.Remove(c)
        Return cl
    End Operator

    Public Sub Fill()
        Dim tempCustomers As List(Of Customer) = CustomerDB.GetCustomers
        For Each tempCustomer As Customer In tempCustomers
            MyBase.Add(tempCustomer)
        Next
    End Sub

    Public Sub Save()
        CustomerDB.SaveCustomers(Me)
    End Sub

End Class
