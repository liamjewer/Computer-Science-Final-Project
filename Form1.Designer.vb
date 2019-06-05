<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.cmbConvos = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Monospac821 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(13, 12)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOut.Size = New System.Drawing.Size(541, 143)
        Me.txtOut.TabIndex = 1
        '
        'txtMsg
        '
        Me.txtMsg.AllowDrop = True
        Me.txtMsg.Location = New System.Drawing.Point(13, 162)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(482, 20)
        Me.txtMsg.TabIndex = 2
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(250, 271)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(86, 20)
        Me.txtIP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IP:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(501, 160)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(53, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(295, 297)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(41, 20)
        Me.txtPort.TabIndex = 6
        Me.txtPort.Text = "15000"
        '
        'cmbConvos
        '
        Me.cmbConvos.FormattingEnabled = True
        Me.cmbConvos.Location = New System.Drawing.Point(130, 188)
        Me.cmbConvos.Name = "cmbConvos"
        Me.cmbConvos.Size = New System.Drawing.Size(124, 21)
        Me.cmbConvos.TabIndex = 9
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(250, 352)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 23)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "new"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(250, 326)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(86, 20)
        Me.txtName.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Select Contact:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Create new Contact"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 381)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.cmbConvos)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.txtOut)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOut As TextBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents cmbConvos As ComboBox
    Friend WithEvents btnNew As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
