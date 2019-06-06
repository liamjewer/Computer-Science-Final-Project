Public Class popupNew
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Form1.newConvo(txtIP.Text, txtPort.Text, txtName.Text)
        Me.Close()
    End Sub

    Private Sub popupNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In Form1.cmbConvos.Items
            LBContacts.Items.Add(s)
        Next
    End Sub

    Private Sub btnNewGroup_Click(sender As Object, e As EventArgs) Handles btnNewGroup.Click

    End Sub
End Class