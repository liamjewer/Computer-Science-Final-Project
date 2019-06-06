Public Class popupNew
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Form1.newConvo(txtIP.Text, txtPort.Text, txtName.Text)
        Me.Close()
    End Sub
End Class