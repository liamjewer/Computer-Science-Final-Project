Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Dim strHostName As String
    Dim strIPAddress As String
    Dim running As Boolean = False
    Dim conversations As List(Of Conversation) = New List(Of Conversation)
    Dim currentConvo As Conversation
    Dim tempConvo As Conversation

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Me.Text = strIPAddress
        running = True

        newConvo(strIPAddress, 15000, "This computer")

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
        Dim serverSocket As New TcpListener(currentConvo.getPort)
        Dim clientSocket As TcpClient
        Dim messageReceived As Boolean = False
        While running
            messageReceived = False
            serverSocket.Start()
            Console.WriteLine("Server Started")
            clientSocket = serverSocket.AcceptTcpClient()
            Console.WriteLine("Accept connection from client")

            While (Not (messageReceived))
                Try
                    Dim networkStream As NetworkStream = clientSocket.GetStream()
                    Dim bytesFrom(10024) As Byte
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length)
                    Dim dataFromClient As String = System.Text.Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.Length)
                    'invoke into other thread
                    txtOut.Invoke(Sub()
                                      txtOut.Text += currentConvo.getName
                                      txtOut.Text += vbNewLine
                                      txtOut.Text += dataFromClient
                                      txtOut.Text += vbNewLine + vbNewLine
                                      currentConvo.setmessages(txtOut.Text)
                                  End Sub)
                    messageReceived = True
                    networkStream.Flush()
                Catch ex As Exception
                    End
                End Try
            End While
            clientSocket.Close()
            serverSocket.Stop()
            Console.WriteLine("exit")
            Console.ReadLine()
        End While
    End Sub

    Public Sub WriteData(ByVal data As String, ByRef IP As String)
        Try
            txtOut.Text += "Me"
            txtOut.Text += vbNewLine
            txtOut.Text += data
            txtOut.Text += vbNewLine + vbNewLine
            currentConvo.setmessages(txtOut.Text)
            txtMsg.Clear()
            Console.WriteLine("Sending message """ & data & """ to " & IP)
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
        If Not (txtMsg.Text = vbNullString) AndAlso Not (txtIP.Text = vbNullString) Then
            WriteData(txtMsg.Text, txtIP.Text)
        End If
    End Sub

    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (txtMsg.Text = vbNullString) AndAlso Not (txtIP.Text = vbNullString) Then
                WriteData(txtMsg.Text, txtIP.Text)
            End If
        End If
    End Sub

    Private Sub newConvo(IP As String, port As Integer, name As String)
        txtName.Clear()
        tempConvo = New Conversation(IP, port, name)
        txtIP.Text = tempConvo.getIP
        txtPort.Text = tempConvo.getPort
        conversations.Add(tempConvo)
        cmbConvos.Items.Add(tempConvo.getName)
        cmbConvos.SelectedIndex = cmbConvos.FindString(name)
        changeConvo(tempConvo)
    End Sub

    Private Sub changeConvo(convo As Conversation)
        currentConvo = convo
        txtIP.Text = convo.getIP
        txtPort.Text = convo.getPort
        Me.Text = convo.getName
        txtOut.Text = convo.getMessages
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        newConvo(txtIP.Text, txtPort.Text, txtName.Text)
    End Sub

    Private Sub cmbConvos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConvos.SelectedIndexChanged
        changeConvo(getConvoByName(sender.items(sender.selectedindex)))
    End Sub

    Private Function getConvoByName(name As String) As Conversation
        For Each convo As Conversation In conversations
            Console.WriteLine(convo.getName + ", " + name)
            If convo.getName = name Then
                Return convo
                Exit For
            Else
                Console.WriteLine("name not found")
            End If
        Next
    End Function
End Class
