<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewer
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AlbumCover = New System.Windows.Forms.PictureBox()
        Me.TrackLabel = New MetroFramework.Controls.MetroLabel()
        Me.ArtistLabel = New MetroFramework.Controls.MetroLabel()
        Me.AlbumLabel = New MetroFramework.Controls.MetroLabel()
        CType(Me.AlbumCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlbumCover
        '
        Me.AlbumCover.Location = New System.Drawing.Point(23, 18)
        Me.AlbumCover.Name = "AlbumCover"
        Me.AlbumCover.Size = New System.Drawing.Size(130, 130)
        Me.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlbumCover.TabIndex = 0
        Me.AlbumCover.TabStop = False
        '
        'TrackLabel
        '
        Me.TrackLabel.AutoSize = True
        Me.TrackLabel.CustomBackground = True
        Me.TrackLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.TrackLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.TrackLabel.Location = New System.Drawing.Point(172, 18)
        Me.TrackLabel.Name = "TrackLabel"
        Me.TrackLabel.Size = New System.Drawing.Size(161, 25)
        Me.TrackLabel.TabIndex = 1
        Me.TrackLabel.Text = "<< Track Name >>"
        Me.TrackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TrackLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ArtistLabel
        '
        Me.ArtistLabel.AutoSize = True
        Me.ArtistLabel.CustomBackground = True
        Me.ArtistLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ArtistLabel.Location = New System.Drawing.Point(172, 59)
        Me.ArtistLabel.Name = "ArtistLabel"
        Me.ArtistLabel.Size = New System.Drawing.Size(130, 19)
        Me.ArtistLabel.TabIndex = 2
        Me.ArtistLabel.Text = "<< Artist Name >>"
        Me.ArtistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ArtistLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'AlbumLabel
        '
        Me.AlbumLabel.AutoSize = True
        Me.AlbumLabel.CustomBackground = True
        Me.AlbumLabel.FontSize = MetroFramework.MetroLabelSize.Small
        Me.AlbumLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.AlbumLabel.Location = New System.Drawing.Point(172, 104)
        Me.AlbumLabel.Name = "AlbumLabel"
        Me.AlbumLabel.Size = New System.Drawing.Size(116, 15)
        Me.AlbumLabel.TabIndex = 3
        Me.AlbumLabel.Text = "<< Album Name >>"
        Me.AlbumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AlbumLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.AlbumLabel)
        Me.Controls.Add(Me.ArtistLabel)
        Me.Controls.Add(Me.TrackLabel)
        Me.Controls.Add(Me.AlbumCover)
        Me.DisplayHeader = False
        Me.Name = "Viewer"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Player Viewer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.AlbumCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlbumCover As PictureBox
    Friend WithEvents TrackLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ArtistLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents AlbumLabel As MetroFramework.Controls.MetroLabel
End Class
