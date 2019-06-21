Imports System.Net

Public Class appMenu
    Dim convo As Conversation
    Dim game As Xs_and_Os
    Dim BG As Color
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        popupNew.Show() 'show new message popup
    End Sub

    Private Sub AppMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get local ip and set label text to it
        Dim strHostName As String = Dns.GetHostName()
        Dim strIPAddress As String = Dns.GetHostByName(strHostName).AddressList(0).ToString()
        lblIP.Text = strIPAddress
        'add all the convos into combobox for new game
        For Each c As Conversation In Form1.conversations
            cmbOpps.Items.Add(c.getName)
        Next
        'if we are in dark mode checkbox is checked
        CBDT.Checked = Form1.darkMode
    End Sub

    Private Sub changeBackColour()
        'change the background color to rgb of numeric up/downs
        BG = Color.FromArgb(numR.Value, numG.Value, numB.Value)
        Form1.BackColor = BG
        Form1.txtOut.BackColor = BG
        Me.BackColor = BG
        popupNew.BackColor = BG
    End Sub

    Private Sub CBDT_CheckedChanged_1(sender As Object, e As EventArgs) Handles CBDT.CheckedChanged
        Form1.darkMode = sender.checked 'set darkmode variable to checked of cb
        If sender.checked Then
            'change to dark mode colours
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
            'change to light mode colours
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

    'when numeric up downs are changed run sub to change background colour
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
        'Create a New game And ass it to games list in form1
        convo = Form1.getConvoByName(cmbOpps.Items(cmbOpps.SelectedIndex))
        game = New Xs_and_Os(convo, True)
        Form1.Games.Add(game)
    End Sub

    Private Sub appMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'set rgb variable in form1 to numeric up down values
        Form1.rgb(0) = numR.Value
        Form1.rgb(1) = numG.Value
        Form1.rgb(2) = numB.Value
    End Sub
End Class