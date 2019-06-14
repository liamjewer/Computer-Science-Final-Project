Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Dim strHostName As String
    Dim strIPAddress As String
    Dim running As Boolean = False
    Public conversations As List(Of Conversation) = New List(Of Conversation)
    Public Games As List(Of Xs_and_Os) = New List(Of Xs_and_Os)
    Dim currentConvo As Conversation
    Dim tempConvo As Conversation
    Dim i As Integer = 0
    Dim tempemote As emote
    Dim tempGame As Xs_and_Os

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Me.Text = strIPAddress
        running = True

        newConvo(strIPAddress, 15000, "This computer")
        cmbConvos.SelectedIndex = 0

        'run listener on separate thread
        Dim listenTrd As Thread
        listenTrd = New Thread(AddressOf StartServer)
        listenTrd.IsBackground = True
        listenTrd.Start()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        running = False
    End Sub

    Sub StartServer()
        Dim serversocket
        serversocket = New TcpListener(currentConvo.getPort)
        Dim clientSocket As TcpClient
        Dim messageReceived As Boolean = False
        Dim clientip As String
        Dim found As Boolean = False
        While running
            messageReceived = False
            serversocket.Start()
            Console.WriteLine("Server Started")
            clientSocket = serversocket.AcceptTcpClient()
            clientip = DirectCast(clientSocket.Client.RemoteEndPoint, IPEndPoint).Address.ToString
            Console.WriteLine("received from: " + clientip)
            Console.WriteLine("Accept connection from client")

            While (Not (messageReceived))
                'Try
                Dim networkStream As NetworkStream = clientSocket.GetStream()
                Dim bytesFrom(10024) As Byte
                networkStream.Read(bytesFrom, 0, bytesFrom.Length)
                Dim dataFromClient As String = System.Text.Encoding.ASCII.GetString(bytesFrom)
                Dim clientconvo As Conversation
                dataFromClient = dataFromClient.Substring(0, dataFromClient.Length)
                dataFromClient = decrypt(dataFromClient)
                For Each c As Conversation In conversations
                    If clientip = c.getIP() Then
                        found = True
                        clientconvo = c
                        If Not (c.messages = vbNullString) Then
                            c.messages += vbNewLine + vbNewLine
                        End If
                        c.messages += c.getName
                        c.messages += vbNewLine
                        c.messages += dataFromClient
                        If Not (currentConvo.getIP = c.getIP) Then
                            MsgBox("new message from:" + vbNewLine + c.getName + vbNewLine + dataFromClient)
                        End If
                    End If
                Next
                If found = False Then
                    txtOut.Invoke(Sub()
                                      newConvo(clientip, 15000, clientip)
                                      tempConvo = getConvoByName(clientip)
                                      tempConvo.messages += tempConvo.getName
                                      tempConvo.messages += vbNewLine
                                      tempConvo.messages += dataFromClient
                                  End Sub)
                    clientconvo = getConvoByName(clientip)
                    MsgBox("new message from:" + vbNewLine + clientip + vbNewLine + dataFromClient)
                End If

                If dataFromClient.ToCharArray.GetValue(0) = "|" Then 'check if message is special
                    txtOut.Invoke(Sub()
                                      tempemote = New emote(dataFromClient.Remove(0, 1))
                                  End Sub)
                ElseIf dataFromClient.Substring(0, 6) = ">XsOs:" Then
                    Try
                        getGameByConvo(clientconvo).winCheck(dataFromClient.ToCharArray.GetValue(6) + dataFromClient.ToCharArray.GetValue(7))
                    Catch
                        txtOut.Invoke(Sub()
                                          tempGame = New Xs_and_Os(clientconvo, False)
                                          Games.Add(tempGame)
                                          tempGame.winCheck(dataFromClient.ToCharArray.GetValue(6) + dataFromClient.ToCharArray.GetValue(7))
                                      End Sub)
                    End Try
                Else
                    txtOut.Invoke(Sub()
                                      txtOut.Text = currentConvo.getMessages()
                                      txtOut.SelectionStart = txtOut.TextLength
                                      txtOut.ScrollToCaret()
                                  End Sub)
                End If

                messageReceived = True
                networkStream.Flush()
            End While
            clientSocket.Close()
            serversocket.Stop()
            Console.WriteLine("exit")
            Console.ReadLine()
        End While
    End Sub

    Public Sub WriteData(ByVal data As String, ByRef name As String)
        Try
            If Not (txtOut.Text = vbNullString) Then
                txtOut.Text += vbNewLine + vbNewLine
            End If
            If Not (data.ToCharArray.GetValue(0) = "|" OrElse data.ToCharArray.GetValue(0) = ">") Then
                txtOut.Text += "Me"
                txtOut.Text += vbNewLine
                txtOut.Text += data
                currentConvo.setmessages(txtOut.Text)
                txtOut.SelectionStart = txtOut.TextLength
                txtOut.ScrollToCaret()
            End If
            txtMsg.Clear()
            data = encrypt(data)
            Console.WriteLine("Sending message """ & data & """ to " & getConvoByName(name).getIP)
            Dim client As TcpClient = New TcpClient()
            client.Connect(New IPEndPoint(IPAddress.Parse(currentConvo.getIP), currentConvo.getPort))
            Dim stream As NetworkStream = client.GetStream()
            Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(data)
            stream.Write(sendBytes, 0, sendBytes.Length)
        Catch ex As Exception
            MsgBox("Could not contact, please make sure contact is listening")
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not (txtMsg.Text = vbNullString) AndAlso Not (currentConvo.getIP = vbNullString) Then
            WriteData(txtMsg.Text, currentConvo.getName)
        End If
    End Sub

    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (txtMsg.Text = vbNullString) AndAlso Not (currentConvo.getIP = vbNullString) Then
                WriteData(txtMsg.Text, currentConvo.getName)
            End If
        End If
    End Sub

    Public Sub newConvo(IP As String, port As Integer, name As String)
        tempConvo = New Conversation(IP, port, name)
        conversations.Add(tempConvo)
        cmbConvos.Items.Add(tempConvo.getName)
    End Sub

    Private Sub changeConvo(convo As Conversation)
        currentConvo = convo
        Me.Text = convo.getName
        txtOut.Text = convo.getMessages
        txtOut.SelectionStart = txtOut.TextLength
        txtOut.ScrollToCaret()
    End Sub

    Private Sub cmbConvos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConvos.SelectedIndexChanged
        changeConvo(getConvoByName(sender.items(sender.selectedindex)))
    End Sub

    Public Function getConvoByName(name As String) As Conversation
        For Each convo As Conversation In conversations
            If convo.getName = name Then
                Return convo
                Exit For
            Else
                Console.WriteLine("name not found: " + name)
            End If
        Next
    End Function

    Public Function getGameByConvo(convo As Conversation) As Xs_and_Os
        For Each game As Xs_and_Os In Games
            If game.getOpp.getName = convo.getName Then
                Return game
                Exit For
            Else
                Console.WriteLine("game not found: " + Name)
            End If
        Next
    End Function

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        appMenu.Show()
    End Sub

    Function encrypt(str As String) As String
        Dim chars As Char() = str.ToCharArray
        Dim asciis As List(Of Integer) = New List(Of Integer)
        Dim encrypted As String = ""
        For Each c As Char In chars
            If (Asc(c) >= 65 And Asc(c) <= 90) Or (Asc(c) >= 97 And Asc(c) <= 122) Then
                If Asc(c) = 88 Then
                    asciis.Add(65)
                ElseIf Asc(c) = 89 Then
                    asciis.Add(65 + 1)
                ElseIf Asc(c) = 90 Then
                    asciis.Add(65 + 2)
                ElseIf Asc(c) = 120 Then
                    asciis.Add(97)
                ElseIf Asc(c) = 121 Then
                    asciis.Add(97 + 1)
                ElseIf Asc(c) = 122 Then
                    asciis.Add(97 + 2)
                Else
                    asciis.Add(Asc(c) + 3)
                End If
            Else
                asciis.Add(Asc(c))
            End If
        Next
        For Each i As Integer In asciis
            encrypted += Chr(i)
        Next
        Return encrypted
    End Function

    Private Function decrypt(str As String) As String
        Dim chars() = str.ToCharArray
        Dim asciis As List(Of Integer) = New List(Of Integer)
        Dim decrypted As String = ""

        For Each c As Char In chars
            If (Asc(c) >= 65 And Asc(c) <= 90) Or (Asc(c) >= 97 And Asc(c) <= 122) Then
                If Asc(c) = 65 Then
                    asciis.Add(88)
                ElseIf Asc(c) = 65 + 1 Then
                    asciis.Add(89)
                ElseIf Asc(c) = 65 + 2 Then
                    asciis.Add(90)
                ElseIf Asc(c) = 97 Then
                    asciis.Add(120)
                ElseIf Asc(c) = 97 + 1 Then
                    asciis.Add(121)
                ElseIf Asc(c) = 97 + 2 Then
                    asciis.Add(122)
                Else
                    asciis.Add(Asc(c) - 3)
                End If
            Else
                asciis.Add(Asc(c))
            End If
        Next
        For Each i As Integer In asciis
            decrypted += Chr(i)
        Next
        Return decrypted
    End Function

    Private Sub cmbEmote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmote.SelectedIndexChanged
        WriteData("|" + sender.items(cmbEmote.SelectedIndex).substring(0, 1), currentConvo.getName)
    End Sub
End Class
