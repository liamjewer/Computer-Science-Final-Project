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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.cmbConvos = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOut.Font = New System.Drawing.Font("Monospac821 BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(13, 12)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
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
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(501, 160)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(53, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
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
        Me.btnNew.Location = New System.Drawing.Point(260, 188)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(294, 21)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New Contact"
        Me.btnNew.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 220)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.cmbConvos)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.txtOut)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOut As TextBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents cmbConvos As ComboBox
    Friend WithEvents btnNew As Button
    Friend WithEvents Label4 As Label
End Class
