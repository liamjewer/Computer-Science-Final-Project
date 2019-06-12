<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emote
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(emote))
        Me.picEmote = New System.Windows.Forms.PictureBox()
        Me.Emotes = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picEmote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEmote
        '
        Me.picEmote.Image = CType(resources.GetObject("picEmote.Image"), System.Drawing.Image)
        Me.picEmote.Location = New System.Drawing.Point(0, 0)
        Me.picEmote.Name = "picEmote"
        Me.picEmote.Size = New System.Drawing.Size(180, 180)
        Me.picEmote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmote.TabIndex = 0
        Me.picEmote.TabStop = False
        '
        'Emotes
        '
        Me.Emotes.ImageStream = CType(resources.GetObject("Emotes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Emotes.TransparentColor = System.Drawing.Color.Transparent
        Me.Emotes.Images.SetKeyName(0, "thumbs up.jpg")
        Me.Emotes.Images.SetKeyName(1, "thumbs down.jpg")
        '
        'emote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 181)
        Me.Controls.Add(Me.picEmote)
        Me.Name = "emote"
        Me.Text = "emote"
        CType(Me.picEmote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEmote As PictureBox
    Friend WithEvents Emotes As ImageList
End Class
