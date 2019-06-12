Public Class emote
    Public Sub New(num As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If num < Emotes.Images.Count Then
            picEmote.Image = Emotes.Images(num)
        End If
        Me.Show()
    End Sub
End Class