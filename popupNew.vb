Public Class popupNew
    Dim tempIPs As New List(Of String)
    Dim lines() As String
    Dim rG As New Random

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Form1.newConvo(txtIP.Text, txtPort.Text, txtName.Text)
        Me.Close()
        appMenu.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lines = Split(System.IO.File.ReadAllText("csv.csv"), vbNewLine)
        txtName.Text = lines(rG.Next(1, lines.Length))
    End Sub
End Class