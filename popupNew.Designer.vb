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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.LBContacts = New System.Windows.Forms.CheckedListBox()
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
        Me.btnNewGroup.Location = New System.Drawing.Point(307, 87)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(71, 23)
        Me.btnNewGroup.TabIndex = 23
        Me.btnNewGroup.Text = "new Group"
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(230, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add member"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'LBContacts
        '
        Me.LBContacts.FormattingEnabled = True
        Me.LBContacts.Location = New System.Drawing.Point(230, 6)
        Me.LBContacts.Name = "LBContacts"
        Me.LBContacts.Size = New System.Drawing.Size(148, 79)
        Me.LBContacts.TabIndex = 26
        '
        'popupNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 122)
        Me.Controls.Add(Me.LBContacts)
        Me.Controls.Add(Me.btnAdd)
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents LBContacts As CheckedListBox
End Class
