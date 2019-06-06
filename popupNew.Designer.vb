<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popupNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.btnNewGroup = New System.Windows.Forms.Button()
        Me.LBContacts = New System.Windows.Forms.CheckedListBox()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGroupPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Port:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(56, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(131, 20)
        Me.txtName.TabIndex = 20
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 87)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 23)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "new"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(47, 61)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(41, 20)
        Me.txtPort.TabIndex = 18
        Me.txtPort.Text = "15000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "IP:"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(38, 35)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(86, 20)
        Me.txtIP.TabIndex = 16
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(230, 142)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(148, 23)
        Me.btnNewGroup.TabIndex = 23
        Me.btnNewGroup.Text = "new Group"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'LBContacts
        '
        Me.LBContacts.FormattingEnabled = True
        Me.LBContacts.Location = New System.Drawing.Point(230, 6)
        Me.LBContacts.Name = "LBContacts"
        Me.LBContacts.Size = New System.Drawing.Size(148, 79)
        Me.LBContacts.TabIndex = 26
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(230, 116)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(148, 20)
        Me.txtGroupName.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Name:"
        '
        'txtGroupPort
        '
        Me.txtGroupPort.Location = New System.Drawing.Point(230, 90)
        Me.txtGroupPort.Name = "txtGroupPort"
        Me.txtGroupPort.Size = New System.Drawing.Size(148, 20)
        Me.txtGroupPort.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Port:"
        '
        'popupNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 177)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGroupPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.LBContacts)
        Me.Controls.Add(Me.btnNewGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Name = "popupNew"
        Me.Text = "new Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnNewGroup As Button
    Friend WithEvents LBContacts As CheckedListBox
    Friend WithEvents txtGroupName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGroupPort As TextBox
    Friend WithEvents Label5 As Label
End Class
