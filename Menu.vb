Imports System.Net

Public Class appMenu
    Dim convo As Conversation
    Dim game As Xs_and_Os
    Dim BG As Color
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
        CBDT.Checked = Form1.darkMode
    End Sub

    Private Sub changeBackColour()
        BG = Color.FromArgb(numR.Value, numG.Value, numB.Value)
        Form1.BackColor = BG
        Form1.txtOut.BackColor = BG
        Me.BackColor = BG
        popupNew.BackColor = BG
    End Sub

    Private Sub CBDT_CheckedChanged_1(sender As Object, e As EventArgs) Handles CBDT.CheckedChanged
        Form1.darkMode = sender.checked
        If sender.checked Then
            numR.Value = 0
            numG.Value = 0
            numB.Value = 0
            For Each hold As Control In Form1.Controls
                If TypeOf hold Is Windows.Forms.Button Or TypeOf hold Is Windows.Forms.ComboBox Or TypeOf hold Is Windows.Forms.TextBox Then hold.BackColor = Color.FromArgb(89, 89, 89)
            Next
            For Each hold As Control In Me.Controls
                If TypeOf hold Is Windows.Forms.Button Or TypeOf hold Is Windows.Forms.ComboBox Or TypeOf hold Is Windows.Forms.TextBox Then hold.BackColor = Color.FromArgb(89, 89, 89)
            Next
            For Each hold As Control In popupNew.Controls
                If TypeOf hold Is Windows.Forms.Button Or TypeOf hold Is Windows.Forms.ComboBox Or TypeOf hold Is Windows.Forms.TextBox Then hold.BackColor = Color.FromArgb(89, 89, 89)
            Next
            Form1.ForeColor = Color.White
            Form1.txtOut.BackColor = Color.Black
            Form1.txtOut.ForeColor = Color.White
            Me.ForeColor = Color.White
            popupNew.ForeColor = Color.White
        Else
            numR.Value = 255
            numG.Value = 255
            numB.Value = 255
            For Each hold As Control In Form1.Controls
                If TypeOf hold Is Windows.Forms.Button Or TypeOf hold Is Windows.Forms.ComboBox Or TypeOf hold Is Windows.Forms.TextBox Then hold.BackColor = Color.FromArgb(255, 255, 255)
            Next
            For Each hold As Control In Me.Controls
                If TypeOf hold Is Windows.Forms.Button Or TypeOf hold Is Windows.Forms.ComboBox Or TypeOf hold Is Windows.Forms.TextBox Then hold.BackColor = Color.FromArgb(255, 255, 255)
            Next
            For Each hold As Control In popupNew.Controls
                If TypeOf hold Is Windows.Forms.Button Or TypeOf hold Is Windows.Forms.ComboBox Or TypeOf hold Is Windows.Forms.TextBox Then hold.BackColor = Color.FromArgb(255, 255, 255)
            Next
            Form1.ForeColor = Color.Black
            Form1.txtOut.BackColor = Color.White
            Form1.txtOut.ForeColor = Color.Black
            Me.ForeColor = Color.Black
            popupNew.ForeColor = Color.Black
        End If
    End Sub

    Private Sub numR_ValueChanged_1(sender As Object, e As EventArgs) Handles numR.ValueChanged
        changeBackColour()
    End Sub

    Private Sub numG_ValueChanged_1(sender As Object, e As EventArgs) Handles numG.ValueChanged
        changeBackColour()
    End Sub

    Private Sub numB_ValueChanged_1(sender As Object, e As EventArgs) Handles numB.ValueChanged
        changeBackColour()
    End Sub

    Private Sub btnNewGame_Click_1(sender As Object, e As EventArgs) Handles btnNewGame.Click
        convo = Form1.getConvoByName(cmbOpps.Items(cmbOpps.SelectedIndex))
        game = New Xs_and_Os(convo, True)
        Form1.Games.Add(game)
    End Sub
End Class