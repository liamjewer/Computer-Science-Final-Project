Imports System.Net

Public Class appMenu
    Dim convo As Conversation
    Dim game As Xs_and_Os
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        popupNew.Show()
    End Sub

    Private Sub AppMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strHostName As String = Dns.GetHostName()
        Dim strIPAddress As String = Dns.GetHostByName(strHostName).AddressList(0).ToString()
        lblIP.Text = strIPAddress
        For Each c As Conversation In Form1.conversations
            cmbOpps.Items.Add(c.getName)
        Next
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        convo = Form1.getConvoByName(cmbOpps.Items(cmbOpps.SelectedIndex))
        game = New Xs_and_Os(convo, True)
        Form1.Games.Add(game)
    End Sub
End Class