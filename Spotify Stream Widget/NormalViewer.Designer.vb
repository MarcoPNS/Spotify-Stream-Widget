<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NormalViewer
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
        Me.TrackLabel = New System.Windows.Forms.Label()
        Me.ArtistLabel = New System.Windows.Forms.Label()
        Me.AlbumLabel = New System.Windows.Forms.Label()
        Me.timeProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.timeLabel = New MetroFramework.Controls.MetroLabel()
        CType(Me.AlbumCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlbumCover
        '
        Me.AlbumCover.Location = New System.Drawing.Point(9, 14)
        Me.AlbumCover.Name = "AlbumCover"
        Me.AlbumCover.Size = New System.Drawing.Size(160, 160)
        Me.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlbumCover.TabIndex = 0
        Me.AlbumCover.TabStop = False
        '
        'TrackLabel
        '
        Me.TrackLabel.AutoSize = True
        Me.TrackLabel.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.TrackLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TrackLabel.Location = New System.Drawing.Point(177, 25)
        Me.TrackLabel.Name = "TrackLabel"
        Me.TrackLabel.Size = New System.Drawing.Size(187, 29)
        Me.TrackLabel.TabIndex = 4
        Me.TrackLabel.Text = "<< Track Name >>"
        '
        'ArtistLabel
        '
        Me.ArtistLabel.AutoSize = True
        Me.ArtistLabel.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.ArtistLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ArtistLabel.Location = New System.Drawing.Point(177, 60)
        Me.ArtistLabel.Name = "ArtistLabel"
        Me.ArtistLabel.Size = New System.Drawing.Size(174, 27)
        Me.ArtistLabel.TabIndex = 5
        Me.ArtistLabel.Text = "<< Artist Name >>"
        '
        'AlbumLabel
        '
        Me.AlbumLabel.AutoSize = True
        Me.AlbumLabel.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.AlbumLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AlbumLabel.Location = New System.Drawing.Point(177, 95)
        Me.AlbumLabel.Name = "AlbumLabel"
        Me.AlbumLabel.Size = New System.Drawing.Size(153, 23)
        Me.AlbumLabel.TabIndex = 6
        Me.AlbumLabel.Text = "<< Album Name >>"
        '
        'timeProgressBar
        '
        Me.timeProgressBar.Location = New System.Drawing.Point(177, 135)
        Me.timeProgressBar.Name = "timeProgressBar"
        Me.timeProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.timeProgressBar.Size = New System.Drawing.Size(286, 17)
        Me.timeProgressBar.Style = MetroFramework.MetroColorStyle.Green
        Me.timeProgressBar.TabIndex = 7
        Me.timeProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'timeLabel
        '
        Me.timeLabel.Location = New System.Drawing.Point(177, 155)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(286, 19)
        Me.timeLabel.TabIndex = 8
        Me.timeLabel.Text = "time"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.timeLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'NormalViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.timeProgressBar)
        Me.Controls.Add(Me.AlbumLabel)
        Me.Controls.Add(Me.ArtistLabel)
        Me.Controls.Add(Me.TrackLabel)
        Me.Controls.Add(Me.AlbumCover)
        Me.DisplayHeader = False
        Me.Name = "NormalViewer"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Viewer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.AlbumCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlbumCover As PictureBox
    Friend WithEvents TrackLabel As Label
    Friend WithEvents ArtistLabel As Label
    Friend WithEvents AlbumLabel As Label
    Friend WithEvents timeProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents timeLabel As MetroFramework.Controls.MetroLabel
End Class
