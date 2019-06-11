Imports System.Net

Public Class appMenu
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        popupNew.Show()
    End Sub

    Private Sub AppMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strHostName As String = Dns.GetHostName()
        Dim strIPAddress As String = Dns.GetHostByName(strHostName).AddressList(0).ToString()
        lblIP.Text = strIPAddress
    End Sub
End Class