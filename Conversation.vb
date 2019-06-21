Public Class Conversation
    Dim IP As String
    Dim port As Integer
    Dim name As String
    Public messages As String

    Public Sub New(IP As String, port As Integer, name As String) 'new conversation object created
        Me.port = port
        Me.IP = IP
        Me.name = name
    End Sub

    Public Function getIP() As String
        Return IP
    End Function

    Public Function getPort() As Integer
        Return port
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
