Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO

Public Class Form1
    'Programmer: Liam Jewer
    'Date: May 22nd 2019
    'project: final project!!!!
    'purpose: send/receive messages between two computers and have some cool features such as basic online games

    'local ip
    Dim strHostName As String = Dns.GetHostName() 'local Host name as string
    Dim strIPAddress As String = Dns.GetHostByName(strHostName).AddressList(0).ToString() 'local ip as string
    'application variables
    Dim running As Boolean = False 'if program is running
    'object lists
    Public conversations As List(Of Conversation) = New List(Of Conversation) 'all conversations
    Public Games As List(Of Xs_and_Os) = New List(Of Xs_and_Os) 'all games
    'file variables
    Dim file As System.IO.StreamWriter 'file for writing (set later)
    'temporary objects
    Dim tempConvo As Conversation 'temporary conversation object
    Dim tempemote As emote 'temporary emote object
    Dim tempGame As Xs_and_Os 'temporary game object
    'temp converation atributes
    Dim tempIP As String 'temporary conversation ip
    Dim tempPort As Integer 'temporary conversation port
    Dim tempName As String 'temporary conversation name
    Dim currentConvo As Conversation 'current selected conversation
    'for saving files
    Dim lines() As String 'lines in settings.txt
    Public rgb(3) As String 'rgb values from settings.txt
    Public darkMode As Boolean 'if app is in dark mode
    'paths to txt files
    Const convosPath As String = "convos.txt"
    Const settingsPath As String = "settings.txt"
    'for sending
    Dim client As TcpClient
    Dim stream As NetworkStream
    Dim sendBytes As Byte()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load all .txt files
        loadConvos()
        newConvo(strIPAddress, 15000, "This computer")
        loadConvoMsgs()
        cmbConvos.SelectedIndex = 0
        loadsettings()

        'run listener on separate thread
        Dim listenTrd As Thread
        listenTrd = New Thread(AddressOf StartServer)
        listenTrd.IsBackground = True
        listenTrd.Start()

        'program is now running
        running = True

        'hide loading form
        Comm_Test_receiver.Load.Hide()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        'essentialy save current state of the app into .txts
        savesettings()
        saveConvos(conversations.ToArray)
        saveMsgs()
        End
        running = False
    End Sub

    Sub StartServer()
        'start the tcp listener
        Dim serversocket = New TcpListener(currentConvo.getPort) 'socket
        Dim clientSocket As TcpClient 'client
        Dim messageReceived As Boolean = False 'if message has been received
        Dim clientip As String 'senders ip adress
        Dim found As Boolean = False 'if client has been found
        'used in receiving the message
        Dim networkStream As NetworkStream
        Dim bytesFrom(10024) As Byte
        Dim dataFromClient As String
        Dim clientconvo As Conversation

        While running 'repeat as long as the app is running
            'listen...
            messageReceived = False
            serversocket.Start()
            Console.WriteLine("Server Started")
            clientSocket = serversocket.AcceptTcpClient()
            clientip = DirectCast(clientSocket.Client.RemoteEndPoint, IPEndPoint).Address.ToString
            Console.WriteLine("received from: " + clientip)
            Console.WriteLine("Accept connection from client")

            While (Not (messageReceived))
                'read message
                networkStream = clientSocket.GetStream()
                networkStream.Read(bytesFrom, 0, bytesFrom.Length)
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                dataFromClient = dataFromClient.Substring(0, dataFromClient.Length)
                dataFromClient = decrypt(dataFromClient)
                'find if conversation exists, if not create new conversation
                For Each c As Conversation In conversations
                    If clientip = c.getIP() Then 'if this is true we have a match! the convo exists!
                        found = True
                        clientconvo = c
                        'set the messages of the convo to include new message
                        If Not (c.messages = vbNullString) Then
                            c.messages += vbNewLine + vbNewLine
                        End If
                        c.messages += c.getName
                        c.messages += vbNewLine
                        c.messages += dataFromClient
                        If Not (currentConvo.getIP = c.getIP) Then 'if the message comes from another convo other than the current one, popup
                            MsgBox("new message from:" + vbNewLine + c.getName + vbNewLine + dataFromClient)
                        End If
                    End If
                Next
                If found = False AndAlso Not (dataFromClient.ToCharArray.GetValue(0) = "|" OrElse dataFromClient.ToCharArray.GetValue(0) = ">") Then 'if message is not special, show it in the chatbox
                    txtOut.Invoke(Sub() 'invoke into main thread
                                      'create a new convo
                                      newConvo(clientip, 15000, clientip)
                                      tempConvo = getConvoByName(clientip)
                                      tempConvo.messages += tempConvo.getName
                                      tempConvo.messages += vbNewLine
                                      tempConvo.messages += dataFromClient
                                  End Sub)
                    clientconvo = getConvoByName(clientip)
                    MsgBox("new message from:" + vbNewLine + clientip + vbNewLine + dataFromClient) 'new message from unknown person
                End If

                If dataFromClient.ToCharArray.GetValue(0) = "|" Then 'check if message is special
                    txtOut.Invoke(Sub() 'invoke into main thread
                                      tempemote = New emote(dataFromClient.Remove(0, 1)) 'popup emote
                                  End Sub)
                ElseIf dataFromClient.Substring(0, 6) = ">XsOs:" Then
                    txtOut.Invoke(Sub() 'invoke into main thread
                                      Try
                                          getGameByIP(clientip).receive(dataFromClient.ToCharArray.GetValue(6) + dataFromClient.ToCharArray.GetValue(7)) 'if game exists display the turn
                                      Catch
                                          'if game does not exist create a new one and display the turn
                                          tempGame = New Xs_and_Os(clientconvo, False)
                                          Games.Add(tempGame)
                                          tempGame.receive(dataFromClient.ToCharArray.GetValue(6) + dataFromClient.ToCharArray.GetValue(7))
                                      End Try
                                  End Sub)
                Else
                    txtOut.Invoke(Sub() 'invoke into main thread
                                      'update messages textbox
                                      txtOut.Text = currentConvo.getMessages()
                                      txtOut.SelectionStart = txtOut.TextLength
                                      txtOut.ScrollToCaret()
                                  End Sub)
                End If

                'finish up receiving the message
                messageReceived = True
                networkStream.Flush()
            End While
            'close server
            clientSocket.Close()
            serversocket.Stop()
            Console.WriteLine("exit")
            Console.ReadLine()
            'repeat to restart
        End While
    End Sub

    Public Sub WriteData(ByVal data As String, ByRef name As String)
        'send data to peeps
        Try
            If Not (data.ToCharArray.GetValue(0) = "|" OrElse data.ToCharArray.GetValue(0) = ">") Then 'if message is not special
                'update textbox
                If Not (txtOut.Text = vbNullString) Then
                    txtOut.Text += vbNewLine + vbNewLine
                End If
                txtOut.Text += "Me"
                txtOut.Text += vbNewLine
                txtOut.Text += data
                currentConvo.setmessages(txtOut.Text)
                txtOut.SelectionStart = txtOut.TextLength
                txtOut.ScrollToCaret()
            End If
            'clear message textbox
            txtMsg.Clear()
            'encrypt the data for safety against mean hacker boioz
            data = encrypt(data)
            'send dat data
            Console.WriteLine("Sending message """ & data & """ to " & getConvoByName(name).getIP)
            client = New TcpClient()
            client.Connect(New IPEndPoint(IPAddress.Parse(getConvoByName(name).getIP), getConvoByName(name).getPort))
            Stream = client.GetStream()
            sendBytes = Encoding.ASCII.GetBytes(data)
            stream.Write(sendBytes, 0, sendBytes.Length)
        Catch ex As Exception
            'msg the most common error
            MsgBox("Could not contact, please make sure contact is listening")
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not (txtMsg.Text = vbNullString) AndAlso Not (currentConvo.getIP = vbNullString) Then 'send data if msg textbox isnt empty and currentconvo has an ip
            WriteData(txtMsg.Text, currentConvo.getName)
        End If
    End Sub

    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then 'do the above but on enter press
            If Not (txtMsg.Text = vbNullString) AndAlso Not (currentConvo.getIP = vbNullString) Then
                WriteData(txtMsg.Text, currentConvo.getName)
            End If
        End If
    End Sub

    Public Sub newConvo(IP As String, port As Integer, name As String)
        'reate a new conversation and add it to conversation list
        tempConvo = New Conversation(IP, port, name)
        conversations.Add(tempConvo)
        cmbConvos.Items.Add(tempConvo.getName)
    End Sub

    Private Sub changeConvo(convo As Conversation)
        'switch the current conversation
        currentConvo = convo
        Me.Text = convo.getName
        txtOut.Text = convo.getMessages
        txtOut.SelectionStart = txtOut.TextLength
        txtOut.ScrollToCaret()
    End Sub

    Private Sub cmbConvos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConvos.SelectedIndexChanged
        'if combobox is used change the convo to the selected one
        changeConvo(getConvoByName(sender.items(sender.selectedindex)))
    End Sub

    Public Function getConvoByName(name As String) As Conversation
        'go through convos and see if there are any that match the name and return it
        For Each convo As Conversation In conversations
            If convo.getName = name Then
                Return convo
                Exit For
            End If
        Next
    End Function

    Public Function getGameByIP(IP As String) As Xs_and_Os
        'go through games and see if there are any that match the ip and return it
        For Each game As Xs_and_Os In Games
            If game.getOpp.getIP = IP Then
                Return game
                Exit For
            End If
        Next
    End Function

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'Open the menu
        appMenu.Show()
    End Sub

    Function encrypt(str As String) As String
        'encrypt data (3 asciis to the right excluding special chars)
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
        'decrypt data (3 asciis to the left excluding special chars)
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
        'if user selects a new emote to send
        WriteData("|" + sender.items(cmbEmote.SelectedIndex).substring(0, 1), currentConvo.getName)
    End Sub

    Private Sub saveConvos(convos() As Conversation)
        System.IO.File.WriteAllText(convosPath, "") 'clear file
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(convosPath, True) 'open file
        For Each convo As Conversation In convos 'write each convos information to a line
            If Not (convo.getName = "This computer") Then
                file.WriteLine(encrypt(convo.getIP) + "," + encrypt(convo.getPort.ToString) + "," + encrypt(convo.getName))
            End If
        Next
        file.Close() 'close file
    End Sub

    Private Sub loadConvos()
        Try
            If Not (System.IO.File.ReadAllText(convosPath) = "") Then
                FileOpen(1, convosPath, OpenMode.Input) 'open file for reading
                'read the lines of the file (convos)
                Do Until EOF(1)
                    Input(1, tempIP)
                    Input(1, tempPort)
                    Input(1, tempName)

                    tempConvo = New Conversation(decrypt(tempIP), decrypt(tempPort), decrypt(tempName))
                    conversations.Add(tempConvo)
                    cmbConvos.Items.Add(tempConvo.getName)
                Loop
            End If
            FileClose(1) 'close file
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub savesettings()
        Console.WriteLine("saving...")
        System.IO.File.WriteAllText(settingsPath, "") 'clear file
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(settingsPath, True) 'open file
        'write data to lines
        file.WriteLine(darkMode.ToString)
        file.WriteLine(rgb(0))
        file.WriteLine(rgb(1))
        file.WriteLine(rgb(2))
        file.Close() 'close file
    End Sub

    Private Sub loadsettings()
        lines = Split(System.IO.File.ReadAllText(settingsPath), vbNewLine) 'split into each line as a string
        'Read each line And set the respective variables
        rgb(0) = lines(1)
        rgb(1) = lines(2)
        rgb(2) = lines(3)
        appMenu.CBDT.Checked = lines(0)
        appMenu.numR.Value = rgb(0)
        appMenu.numG.Value = rgb(1)
        appMenu.numB.Value = rgb(2)
    End Sub

    Private Sub saveMsgs()
        For Each convo As Conversation In conversations 'for each conversation write the messages to a file
            If Not (convo.getMessages = "") Then
                System.IO.File.Create(encrypt(convo.getName) + ".txt").Dispose() 'create/overwrite
                System.IO.File.WriteAllText(encrypt(convo.getName) + ".txt", encrypt(convo.getMessages))
            End If
        Next
    End Sub

    Private Sub loadConvoMsgs()
        For Each convo As Conversation In conversations 'read each messages file for each convo
            If My.Computer.FileSystem.FileExists(encrypt(convo.getName) + ".txt") Then
                convo.setmessages(decrypt(System.IO.File.ReadAllText(encrypt(convo.getName) + ".txt")))
            End If
        Next
    End Sub
End Class
