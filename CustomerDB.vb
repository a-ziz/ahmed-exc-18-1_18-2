Imports System.Xml

Public Class CustomerDB
    Private Const Path As String = "..\..\CustomersX18.xml"

    Public Shared Function GetCustomers() As List(Of Customer)
        Dim customers As New List(Of Customer)

        Dim settings As New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        Dim xmlIn As XmlReader = XmlReader.Create(Path, settings)

        If xmlIn.ReadToDescendant("Customer") Then
            Do
                Dim customer As New Customer
                xmlIn.ReadStartElement("Customer")
                Dim type As String = xmlIn.ReadElementContentAsString
                If type = "Wholesale" Then
                    customers.Add(ReadWholesale(xmlIn))
                ElseIf type = "Retail" Then
                    customers.Add(ReadRetail(xmlIn))
                End If
            Loop While xmlIn.ReadToNextSibling("Customer")
        End If

        xmlIn.Close()
        Return customers
    End Function

    Private Shared Function ReadWholesale(xmlin As XmlReader) _
            As WholesaleCustomer
        Dim customer As New WholesaleCustomer
        customer.FirstName = xmlin.ReadElementContentAsString
        customer.LastName = xmlin.ReadElementContentAsString
        customer.Email = xmlin.ReadElementContentAsString
        customer.Company = xmlin.ReadElementContentAsString
        Return customer
    End Function

    Private Shared Function ReadRetail(xmlin As XmlReader) _
            As RetailCustomer
        Dim customer As New RetailCustomer
        customer.FirstName = xmlin.ReadElementContentAsString
        customer.LastName = xmlin.ReadElementContentAsString
        customer.Email = xmlin.ReadElementContentAsString
        customer.HomePhone = xmlin.ReadElementContentAsString
        Return customer
    End Function

    Public Shared Sub SaveCustomers(customers As List(Of Customer))
        Dim settings As New XmlWriterSettings
        settings.Indent = True
        settings.IndentChars = ("    ")

        Dim xmlOut As XmlWriter = XmlWriter.Create(Path, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("Customers")

        Dim customer As Customer
        For i As Integer = 0 To customers.Count - 1
            customer = CType(customers(i), Customer)
            If customer.GetType.Name = "WholesaleCustomer" Then
                WriteWholesale(CType(customer, WholesaleCustomer), xmlOut)
            ElseIf customer.GetType.Name = "RetailCustomer" Then
                WriteRetail(CType(customer, RetailCustomer), xmlOut)
            End If
        Next

        xmlOut.WriteEndElement()

        xmlOut.Close()

    End Sub

    Private Shared Sub WriteWholesale(customer As WholesaleCustomer,
            xmlout As XmlWriter)
        xmlout.WriteStartElement("Customer")
        xmlout.WriteElementString("Type", "Wholesale")
        xmlout.WriteElementString("FirstName", customer.FirstName)
        xmlout.WriteElementString("LastName", customer.LastName)
        xmlout.WriteElementString("Email", customer.Email)
        xmlout.WriteElementString("Company", customer.Company)
        xmlout.WriteEndElement()
    End Sub

    Private Shared Sub WriteRetail(customer As RetailCustomer,
            xmlout As XmlWriter)
        xmlout.WriteStartElement("Customer")
        xmlout.WriteElementString("Type", "Retail")
        xmlout.WriteElementString("FirstName", customer.FirstName)
        xmlout.WriteElementString("LastName", customer.LastName)
        xmlout.WriteElementString("Email", customer.Email)
        xmlout.WriteElementString("HomePhone", customer.HomePhone)
        xmlout.WriteEndElement()
    End Sub

End Class
