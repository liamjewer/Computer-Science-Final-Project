Public Class emote
    Public Sub New(num As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If num < Emotes.Images.Count Then 'if the number is in the proper range
            picEmote.Image = Emotes.Images(num) 'set the picture of the emote to the number
        End If
        Me.Show()
    End Sub
End Class