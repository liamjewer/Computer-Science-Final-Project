Public Class Xs_and_Os
    Dim box As Button
    Public turn As Boolean = True 'if its this pcs turn
    Dim IAmX As Boolean
    Dim opp As Conversation

    Public Sub New(opp As Conversation, StartedBy As Boolean) 'true is started by me, false is started by opp
        ' This call is required by the designer.
        InitializeComponent()

        IAmX = StartedBy
        Me.opp = opp
        Me.Show()
    End Sub

    Private Function spotfree(box As Button)
        If (box.Text = "x" Or box.Text = "o") Then
            Return False
        ElseIf (box.Text = vbNullString) Then
            Return True
        Else
            Return vbNull
        End If
    End Function

    Sub send(spot As String) 'on close delete the game from form1.games
        If spot = "TL" Then
            box = btnTopLeft
        ElseIf spot = "TM" Then
            box = btnTopMid
        ElseIf spot = "TR" Then
            box = btntopRight
        ElseIf spot = "ML" Then
            box = btnMidLeft
        ElseIf spot = "MM" Then
            box = btnMidMid
        ElseIf spot = "MR" Then
            box = btnMidRight
        ElseIf spot = "BL" Then
            box = btnBottomLeft
        ElseIf spot = "BM" Then
            box = btnBottomMid
        ElseIf spot = "BR" Then
            box = btnBottomRight
        End If

        If (turn And spotfree(box) And IAmX = True) Then
            turn = False
            box.Text = "x"
            Form1.WriteData(">XsOs:" + spot, opp.getName) 'send turn to opp
        ElseIf (turn And spotfree(box) And IAmX = False) Then
            turn = False
            box.Text = "o"
            Form1.WriteData(">XsOs:" + spot, opp.getName) 'send turn to opp
        End If
    End Sub

    Public Sub winCheck(spot As String)
        If spot = "TL" Then
            box = btnTopLeft
        ElseIf spot = "TM" Then
            box = btnTopMid
        ElseIf spot = "TR" Then
            box = btntopRight
        ElseIf spot = "ML" Then
            box = btnMidLeft
        ElseIf spot = "MM" Then
            box = btnMidMid
        ElseIf spot = "MR" Then
            box = btnMidRight
        ElseIf spot = "BL" Then
            box = btnBottomLeft
        ElseIf spot = "BM" Then
            box = btnBottomMid
        ElseIf spot = "BR" Then
            box = btnBottomRight
        End If

        If (IAmX = False) Then
            turn = True
            box.Text = "x"
        ElseIf (IAmX = True) Then
            turn = True
            box.Text = "o"
        End If

        If (btnTopLeft.Text = "x" And btnMidLeft.Text = "x" And btnBottomLeft.Text = "x") Then
            msgx()
        ElseIf (btnTopLeft.Text = "x" And btnTopMid.Text = "x" And btntopRight.Text = "x") Then
            msgx()
        ElseIf (btnTopLeft.Text = "x" And btnMidMid.Text = "x" And btnBottomRight.Text = "x") Then
            msgx()
        ElseIf (btnTopMid.Text = "x" And btnMidMid.Text = "x" And btnBottomMid.Text = "x") Then
            msgx()
        ElseIf (btntopRight.Text = "x" And btnMidRight.Text = "x" And btnBottomRight.Text = "x") Then
            msgx()
        ElseIf (btntopRight.Text = "x" And btnMidMid.Text = "x" And btnBottomLeft.Text = "x") Then
            msgx()
        ElseIf (btnMidLeft.Text = "x" And btnMidMid.Text = "x" And btnMidRight.Text = "x") Then
            msgx()
        ElseIf (btnBottomLeft.Text = "x" And btnBottomMid.Text = "x" And btnBottomRight.Text = "x") Then
            msgx()
        ElseIf (btnTopLeft.Text <> vbNullString And btnTopMid.Text <> vbNullString And btntopRight.Text <> vbNullString And btnMidLeft.Text <> vbNullString And btnMidMid.Text <> vbNullString And btnMidRight.Text <> vbNullString And btnBottomLeft.Text <> vbNullString And btnBottomMid.Text <> vbNullString And btnBottomRight.Text <> vbNullString) Then
            msgcats()
        ElseIf (btnTopLeft.Text = "o" And btnMidLeft.Text = "o" And btnBottomLeft.Text = "o") Then
            msgo()
        ElseIf (btnTopLeft.Text = "o" And btnTopMid.Text = "o" And btntopRight.Text = "o") Then
            msgo()
        ElseIf (btnTopLeft.Text = "o" And btnMidMid.Text = "o" And btnBottomRight.Text = "o") Then
            msgo()
        ElseIf (btnTopMid.Text = "o" And btnMidMid.Text = "o" And btnBottomMid.Text = "o") Then
            msgo()
        ElseIf (btntopRight.Text = "o" And btnMidRight.Text = "o" And btnBottomRight.Text = "o") Then
            msgo()
        ElseIf (btntopRight.Text = "o" And btnMidMid.Text = "o" And btnBottomLeft.Text = "o") Then
            msgo()
        ElseIf (btnMidLeft.Text = "o" And btnMidMid.Text = "o" And btnMidRight.Text = "o") Then
            msgo()
        ElseIf (btnBottomLeft.Text = "o" And btnBottomMid.Text = "o" And btnBottomRight.Text = "o") Then
            msgo()
        ElseIf (btnTopLeft.Text <> vbNullString And btnTopMid.Text <> vbNullString And btntopRight.Text <> vbNullString And btnMidLeft.Text <> vbNullString And btnMidMid.Text <> vbNullString And btnMidRight.Text <> vbNullString And btnBottomLeft.Text <> vbNullString And btnBottomMid.Text <> vbNullString And btnBottomRight.Text <> vbNullString) Then
            msgcats()
        End If
    End Sub

    Private Sub msgx()
        MsgBox("x win")
        clearBoard()
        turn = True
    End Sub

    Private Sub msgo()
        MsgBox("o win")
        clearBoard()
        turn = True
    End Sub

    Private Sub msgcats()
        MsgBox("cats game!")
        clearBoard()
        turn = True
    End Sub

    Private Sub clearBoard()
        btnTopLeft.Text = ""
        btnTopMid.Text = ""
        btntopRight.Text = ""
        btnMidLeft.Text = ""
        btnMidMid.Text = ""
        btnMidRight.Text = ""
        btnBottomLeft.Text = ""
        btnBottomMid.Text = ""
        btnBottomRight.Text = ""
    End Sub

    Private Sub btnTopLeft_Click(sender As Object, e As EventArgs) Handles btnTopLeft.Click
        send("TL")
    End Sub

    Private Sub btnTopMid_Click(sender As Object, e As EventArgs) Handles btnTopMid.Click
        send("TM")
    End Sub

    Private Sub btntopRight_Click(sender As Object, e As EventArgs) Handles btntopRight.Click
        send("TR")
    End Sub

    Private Sub btnMidLeft_Click(sender As Object, e As EventArgs) Handles btnMidLeft.Click
        send("ML")
    End Sub

    Private Sub btnMidMid_Click(sender As Object, e As EventArgs) Handles btnMidMid.Click
        send("MM")
    End Sub

    Private Sub btnMidRight_Click(sender As Object, e As EventArgs) Handles btnMidRight.Click
        send("MR")
    End Sub

    Private Sub btnBottomLeft_Click(sender As Object, e As EventArgs) Handles btnBottomLeft.Click
        send("BL")
    End Sub

    Private Sub btnBottomMid_Click(sender As Object, e As EventArgs) Handles btnBottomMid.Click
        send("BM")
    End Sub

    Private Sub btnBottomRight_Click(sender As Object, e As EventArgs) Handles btnBottomRight.Click
        send("BR")
    End Sub

    Public Function getOpp() As Conversation
        Return opp
    End Function

    Private Sub Xs_and_Os_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Games.Remove(Me)
    End Sub

    Private Sub Xs_and_Os_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOpp.Text = opp.getName
    End Sub
End Class