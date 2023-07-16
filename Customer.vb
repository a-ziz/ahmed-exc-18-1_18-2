Public Class Customer

    Private m_FirstName As String
    Private m_LastName As String
    Private m_Email As String

    Public Sub New()

    End Sub

    Public Sub New(firstName As String,
            lastName As String,
            email As String)
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Email = email
    End Sub

    Public Property FirstName As String
        Get
            Return m_FirstName
        End Get
        Set(value As String)
            If value.Length > 30 Then
                Throw New ArgumentException(
                    "Maximum length of First name is 30 characters.")
            Else
                m_FirstName = value
            End If
        End Set
    End Property

    Public Property LastName As String
        Get
            Return m_LastName
        End Get
        Set(value As String)
            If value.Length > 30 Then
                Throw New ArgumentException(
                    "Maximum length of Last name is 30 characters.")
            Else
                m_LastName = value
            End If
        End Set
    End Property

    Public Property Email As String
        Get
            Return m_Email
        End Get
        Set(value As String)
            If value.Length > 30 Then
                Throw New ArgumentException(
                    "Maximum length of Email is 30 characters.")
            Else
                m_Email = value
            End If
        End Set
    End Property

    Public Overridable Function GetDisplayText() As String
        Dim text As String = FirstName & " " &
                             LastName & ", " &
                             Email
        Return text
    End Function

End Class
