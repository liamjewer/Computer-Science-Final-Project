<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appMenu
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbOpps = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 75)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(294, 21)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "New Contact"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("BankGothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(13, 13)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(155, 40)
        Me.lblIP.TabIndex = 12
        Me.lblIP.Text = "Your IP"
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(6, 59)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(276, 21)
        Me.btnNewGame.TabIndex = 13
        Me.btnNewGame.Text = "Create"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbOpps)
        Me.GroupBox1.Controls.Add(Me.btnNewGame)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 87)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Game"
        '
        'cmbOpps
        '
        Me.cmbOpps.FormattingEnabled = True
        Me.cmbOpps.Location = New System.Drawing.Point(6, 32)
        Me.cmbOpps.Name = "cmbOpps"
        Me.cmbOpps.Size = New System.Drawing.Size(276, 21)
        Me.cmbOpps.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Choose Opponant"
        '
        'appMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 214)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "appMenu"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents lblIP As Label
    Friend WithEvents btnNewGame As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOpps As ComboBox
End Class
