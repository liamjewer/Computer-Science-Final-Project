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
        'appMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 108)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "appMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents lblIP As Label
End Class
