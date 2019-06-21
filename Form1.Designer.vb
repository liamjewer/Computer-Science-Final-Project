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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.cmbConvos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmote = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOut.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(298, 10)
        Me.txtOut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOut.Size = New System.Drawing.Size(924, 359)
        Me.txtOut.TabIndex = 1
        '
        'txtMsg
        '
        Me.txtMsg.AllowDrop = True
        Me.txtMsg.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsg.Location = New System.Drawing.Point(298, 377)
        Me.txtMsg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(787, 23)
        Me.txtMsg.TabIndex = 2
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.White
        Me.btnSend.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(1093, 375)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(129, 25)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'cmbConvos
        '
        Me.cmbConvos.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConvos.FormattingEnabled = True
        Me.cmbConvos.Location = New System.Drawing.Point(20, 46)
        Me.cmbConvos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbConvos.Name = "cmbConvos"
        Me.cmbConvos.Size = New System.Drawing.Size(247, 23)
        Me.cmbConvos.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Select Contact:"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(19, 325)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(248, 75)
        Me.btnMenu.TabIndex = 15
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Emotes:"
        '
        'cmbEmote
        '
        Me.cmbEmote.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmote.FormattingEnabled = True
        Me.cmbEmote.Items.AddRange(New Object() {"0 - Thumbs Up", "1 - Thumbs Down", "2 - Crying Laughing", "3 - Kappa", "4 - LUL", "5 - Blac Box"})
        Me.cmbEmote.Location = New System.Drawing.Point(20, 115)
        Me.cmbEmote.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbEmote.Name = "cmbEmote"
        Me.cmbEmote.Size = New System.Drawing.Size(247, 23)
        Me.cmbEmote.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1240, 415)
        Me.Controls.Add(Me.cmbEmote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbConvos)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.txtOut)
        Me.Font = New System.Drawing.Font("Unispace", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOut As TextBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents cmbConvos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEmote As ComboBox
End Class
