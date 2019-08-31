<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BigViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BigViewer))
        Me.AlbumCover = New System.Windows.Forms.PictureBox()
        Me.TrackLabel = New System.Windows.Forms.Label()
        Me.ArtistLabel = New System.Windows.Forms.Label()
        Me.AlbumLabel = New System.Windows.Forms.Label()
        Me.timeProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.timeLabel = New MetroFramework.Controls.MetroLabel()
        CType(Me.AlbumCover,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'AlbumCover
        '
        Me.AlbumCover.Location = New System.Drawing.Point(20, 20)
        Me.AlbumCover.Name = "AlbumCover"
        Me.AlbumCover.Size = New System.Drawing.Size(160, 160)
        Me.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlbumCover.TabIndex = 0
        Me.AlbumCover.TabStop = false
        '
        'TrackLabel
        '
        Me.TrackLabel.AutoSize = true
        Me.TrackLabel.Font = New System.Drawing.Font("Calibri", 20!)
        Me.TrackLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TrackLabel.Location = New System.Drawing.Point(196, 29)
        Me.TrackLabel.Name = "TrackLabel"
        Me.TrackLabel.Size = New System.Drawing.Size(205, 33)
        Me.TrackLabel.TabIndex = 4
        Me.TrackLabel.Text = "<< Track Name >>"
        '
        'ArtistLabel
        '
        Me.ArtistLabel.AutoSize = true
        Me.ArtistLabel.Font = New System.Drawing.Font("Calibri", 16!)
        Me.ArtistLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ArtistLabel.Location = New System.Drawing.Point(197, 64)
        Me.ArtistLabel.Name = "ArtistLabel"
        Me.ArtistLabel.Size = New System.Drawing.Size(174, 27)
        Me.ArtistLabel.TabIndex = 5
        Me.ArtistLabel.Text = "<< Artist Name >>"
        '
        'AlbumLabel
        '
        Me.AlbumLabel.AutoSize = true
        Me.AlbumLabel.Font = New System.Drawing.Font("Calibri", 14!)
        Me.AlbumLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AlbumLabel.Location = New System.Drawing.Point(198, 99)
        Me.AlbumLabel.Name = "AlbumLabel"
        Me.AlbumLabel.Size = New System.Drawing.Size(153, 23)
        Me.AlbumLabel.TabIndex = 6
        Me.AlbumLabel.Text = "<< Album Name >>"
        '
        'timeProgressBar
        '
        Me.timeProgressBar.Location = New System.Drawing.Point(197, 139)
        Me.timeProgressBar.Name = "timeProgressBar"
        Me.timeProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.timeProgressBar.Size = New System.Drawing.Size(350, 17)
        Me.timeProgressBar.Style = MetroFramework.MetroColorStyle.Green
        Me.timeProgressBar.TabIndex = 7
        Me.timeProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'timeLabel
        '
        Me.timeLabel.Location = New System.Drawing.Point(197, 159)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(350, 19)
        Me.timeLabel.TabIndex = 8
        Me.timeLabel.Text = "time"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.timeLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BigViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 200)
        Me.ControlBox = false
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.timeProgressBar)
        Me.Controls.Add(Me.AlbumLabel)
        Me.Controls.Add(Me.ArtistLabel)
        Me.Controls.Add(Me.TrackLabel)
        Me.Controls.Add(Me.AlbumCover)
        Me.DisplayHeader = false
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "BigViewer"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = false
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Viewer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.AlbumCover,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents AlbumCover As PictureBox
    Friend WithEvents TrackLabel As Label
    Friend WithEvents ArtistLabel As Label
    Friend WithEvents AlbumLabel As Label
    Friend WithEvents timeLabel As MetroFramework.Controls.MetroLabel
    Public WithEvents timeProgressBar As MetroFramework.Controls.MetroProgressBar
End Class
