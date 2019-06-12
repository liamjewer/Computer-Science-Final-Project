Public Class emote
    Public Sub play(num As Integer)
        If num < Emotes.Images.Count Then
            picEmote.Image = Emotes.Images(num)
        End If
        Me.Show()
    End Sub
End Class