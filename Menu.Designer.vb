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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOpps = New System.Windows.Forms.ComboBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.CBDT = New System.Windows.Forms.CheckBox()
        Me.numG = New System.Windows.Forms.NumericUpDown()
        Me.numB = New System.Windows.Forms.NumericUpDown()
        Me.numR = New System.Windows.Forms.NumericUpDown()
        CType(Me.numG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(12, 75)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(294, 21)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "New Contact"
        Me.btnNew.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Choose Opponant"
        '
        'cmbOpps
        '
        Me.cmbOpps.FormattingEnabled = True
        Me.cmbOpps.Location = New System.Drawing.Point(18, 133)
        Me.cmbOpps.Name = "cmbOpps"
        Me.cmbOpps.Size = New System.Drawing.Size(276, 21)
        Me.cmbOpps.TabIndex = 17
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.White
        Me.btnNewGame.Location = New System.Drawing.Point(18, 160)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(276, 21)
        Me.btnNewGame.TabIndex = 16
        Me.btnNewGame.Text = "Create"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'CBDT
        '
        Me.CBDT.AutoSize = True
        Me.CBDT.Location = New System.Drawing.Point(18, 245)
        Me.CBDT.Name = "CBDT"
        Me.CBDT.Size = New System.Drawing.Size(85, 17)
        Me.CBDT.TabIndex = 21
        Me.CBDT.Text = "Dark Theme"
        Me.CBDT.UseVisualStyleBackColor = True
        '
        'numG
        '
        Me.numG.BackColor = System.Drawing.Color.Lime
        Me.numG.Location = New System.Drawing.Point(97, 219)
        Me.numG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numG.Name = "numG"
        Me.numG.Size = New System.Drawing.Size(70, 20)
        Me.numG.TabIndex = 2
        Me.numG.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'numB
        '
        Me.numB.BackColor = System.Drawing.Color.Blue
        Me.numB.Location = New System.Drawing.Point(174, 219)
        Me.numB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numB.Name = "numB"
        Me.numB.Size = New System.Drawing.Size(70, 20)
        Me.numB.TabIndex = 1
        Me.numB.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'numR
        '
        Me.numR.BackColor = System.Drawing.Color.Red
        Me.numR.Location = New System.Drawing.Point(18, 219)
        Me.numR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numR.Name = "numR"
        Me.numR.Size = New System.Drawing.Size(70, 20)
        Me.numR.TabIndex = 0
        Me.numR.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'appMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(313, 315)
        Me.Controls.Add(Me.numB)
        Me.Controls.Add(Me.numG)
        Me.Controls.Add(Me.CBDT)
        Me.Controls.Add(Me.numR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbOpps)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "appMenu"
        Me.Text = "Menu"
        CType(Me.numG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents lblIP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOpps As ComboBox
    Friend WithEvents btnNewGame As Button
    Friend WithEvents CBDT As CheckBox
    Friend WithEvents numG As NumericUpDown
    Friend WithEvents numB As NumericUpDown
    Friend WithEvents numR As NumericUpDown
End Class
