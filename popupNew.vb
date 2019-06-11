Public Class popupNew
    Dim tempIPs As New List(Of String)
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Form1.newConvo(txtIP.Text, txtPort.Text, txtName.Text)
        Me.Close()
        appMenu.Close()
    End Sub
End Class