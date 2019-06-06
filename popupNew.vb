Public Class popupNew
    Dim tempIPs As New List(Of String)
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
        For Each Str As String In LBContacts.Items
            tempIPs.Add(Form1.getConvoByName(Str).getIP)
        Next
        Form1.newGroup(tempIPs.ToArray, CInt(txtGroupPort.Text), txtGroupName.Text)
        Me.Close()
    End Sub
End Class