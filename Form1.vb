Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Dim strHostName As String
    Dim strIPAddress As String
    Dim running As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Me.Text = strIPAddress
        txtIP.Text = strIPAddress
        running = True

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
        Dim serverSocket As New TcpListener(CInt(txtPort.Text))
        Dim requestCount As Integer
        Dim clientSocket As TcpClient
        Dim messageReceived As Boolean = False
        While running
            messageReceived = False
            serverSocket.Start()
            msg("Server Started")
            clientSocket = serverSocket.AcceptTcpClient()
            msg("Accept connection from client")
            requestCount = 0

            While (Not (messageReceived))
                Try
                    requestCount = requestCount + 1
                    Dim networkStream As NetworkStream = clientSocket.GetStream()
                    Dim bytesFrom(10024) As Byte
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length)
                    Dim dataFromClient As String = System.Text.Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.Length)
                    'invoke into other thread
                    txtOut.Invoke(Sub()
                                      txtOut.Text += dataFromClient
                                      txtOut.Text += vbNewLine
                                  End Sub)

                    messageReceived = True
                    Dim serverResponse As String = "Server response " + Convert.ToString(requestCount)
                    Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(serverResponse)
                    networkStream.Write(sendBytes, 0, sendBytes.Length)
                    networkStream.Flush()
                Catch ex As Exception
                    End
                End Try
            End While
            clientSocket.Close()
            serverSocket.Stop()
            msg("exit")
            Console.ReadLine()
        End While
    End Sub

    Sub msg(ByVal mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub

    Public Sub WriteData(ByVal data As String, ByRef IP As String)
        Try
            txtOut.Text += data.PadRight(1)
            txtOut.Text += vbNewLine
            txtMsg.Clear()
            Console.WriteLine("Sending message """ & data & """ to " & IP)
            Dim client As TcpClient = New TcpClient()
            client.Connect(New IPEndPoint(IPAddress.Parse(IP), CInt(txtPort.Text)))
            Dim stream As NetworkStream = client.GetStream()
            Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(data)
            stream.Write(sendBytes, 0, sendBytes.Length)
        Catch ex As Exception
            msg(ex.ToString)
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

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'find all local adresses and put in combobox (button will be removed later)
    End Sub
End Class
