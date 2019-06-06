Public Class Group
    Dim members() As Conversation
    Dim name As String
    Public Sub New(name As String, members() As Conversation)
        Me.members = members
        Me.name = name
    End Sub
End Class
