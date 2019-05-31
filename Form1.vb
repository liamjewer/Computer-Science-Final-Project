Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Dim strHostName As String
    Dim strIPAddress As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Me.Text = strIPAddress
        txtIP.Text = strIPAddress
    End Sub

    Sub listen()
        Dim serverSocket As New TcpListener(CInt(txtLPort.Text))
        Dim requestCount As Integer
        Dim clientSocket As TcpClient
        Dim messageReceived As Boolean = False
        serverSocket.Start()
        msg("Server Started")
        clientSocket = serverSocket.AcceptTcpClient()
        msg("Accept connection from client")
        requestCount = 0

        While (Not (messageReceived))
            Try
                requestCount = requestCount + 1
                Dim networkStream As NetworkStream =
                        clientSocket.GetStream()
                Dim bytesFrom(10024) As Byte
                networkStream.Read(bytesFrom, 0, bytesFrom.Length)
                Dim dataFromClient As String =
                        System.Text.Encoding.ASCII.GetString(bytesFrom)
                dataFromClient =
                    dataFromClient.Substring(0, dataFromClient.Length)
                txtOut.Text += dataFromClient
                txtOut.Text += vbNewLine
                messageReceived = True
                Dim serverResponse As String =
                    "Server response " + Convert.ToString(requestCount)
                Dim sendBytes As [Byte]() =
                    Encoding.ASCII.GetBytes(serverResponse)
                networkStream.Write(sendBytes, 0, sendBytes.Length)
                networkStream.Flush()
                msg(serverResponse)
            Catch ex As Exception
                End
            End Try
        End While


        clientSocket.Close()
        serverSocket.Stop()
        msg("exit")
        Console.ReadLine()
    End Sub

    Sub msg(ByVal mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        listen()
    End Sub

    Public Sub WriteData(ByVal data As String, ByRef IP As String)
        Try
            txtOut.Text += data.PadLeft(30)
            txtOut.Text += vbNewLine
            txtMsg.Clear()
            Console.WriteLine("Sending message """ & data & """ to " & IP)
            Dim client As TcpClient = New TcpClient()
            client.Connect(New IPEndPoint(IPAddress.Parse(IP), CInt(txtOPort.Text)))
            Dim stream As NetworkStream = client.GetStream()
            Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(data)
            stream.Write(sendBytes, 0, sendBytes.Length)
        Catch ex As Exception
            msg(ex.ToString)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        WriteData(txtMsg.Text, txtIP.Text)
    End Sub
End Class
