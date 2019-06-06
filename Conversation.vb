Public Class Conversation
    Dim IP As String
    Dim port As Integer
    Dim IPs() As String
    Dim name As String
    Dim messages As String

    Public Sub New(IP As String, port As Integer, name As String)
        Me.port = port
        Me.IP = IP
        Me.name = name
    End Sub

    Public Sub New(IPs() As String, port As Integer, name As String)
        Me.port = port
        Me.IPs = IPs
        Me.name = "(group) " + name
    End Sub

    Public Function getIP() As String
        Return IP
    End Function

    Public Function getPort() As Integer
        Return port
    End Function

    Public Function getIPs() As String()
        Return IPs
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Function getMessages() As String
        Return messages
    End Function

    Public Sub setmessages(text As String)
        messages = text
    End Sub
End Class
