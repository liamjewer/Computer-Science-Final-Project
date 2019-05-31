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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtLPort = New System.Windows.Forms.TextBox()
        Me.txtOPort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(13, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(218, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "listen"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Monospac821 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(13, 43)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOut.Size = New System.Drawing.Size(218, 112)
        Me.txtOut.TabIndex = 1
        '
        'txtMsg
        '
        Me.txtMsg.AllowDrop = True
        Me.txtMsg.Location = New System.Drawing.Point(13, 162)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(218, 20)
        Me.txtMsg.TabIndex = 2
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(112, 188)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(100, 20)
        Me.txtIP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IP:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(13, 188)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(53, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtLPort
        '
        Me.txtLPort.Location = New System.Drawing.Point(112, 215)
        Me.txtLPort.Name = "txtLPort"
        Me.txtLPort.Size = New System.Drawing.Size(40, 20)
        Me.txtLPort.TabIndex = 6
        Me.txtLPort.Text = "15000"
        '
        'txtOPort
        '
        Me.txtOPort.Location = New System.Drawing.Point(175, 215)
        Me.txtOPort.Name = "txtOPort"
        Me.txtOPort.Size = New System.Drawing.Size(37, 20)
        Me.txtOPort.TabIndex = 7
        Me.txtOPort.Text = "16000"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 239)
        Me.Controls.Add(Me.txtOPort)
        Me.Controls.Add(Me.txtLPort)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txtOut As TextBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents txtLPort As TextBox
    Friend WithEvents txtOPort As TextBox
End Class
