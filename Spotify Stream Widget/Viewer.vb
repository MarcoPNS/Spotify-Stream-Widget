Imports SpotifyAPI.Local, SpotifyAPI.Local.Enums, SpotifyAPI.Local.Models
Public Class Viewer
    Private _spotify As SpotifyLocalAPI
    Private _currentTrack As Track
    Public Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySize()
        Select Case My.Settings.ProgressBarStyle
            Case "Blocks"
                timeProgressBar.ProgressBarStyle = ProgressBarStyle.Blocks
            Case "Continuous"
                timeProgressBar.ProgressBarStyle = ProgressBarStyle.Continuous
            Case "Marquee"
                timeProgressBar.ProgressBarStyle = ProgressBarStyle.Marquee
        End Select
        If My.Settings.DarkMode = False Then
            ActivateWhite()
        End If
        GetColor()
        _spotify = New SpotifyLocalAPI()
        AddHandler _spotify.OnTrackChange, AddressOf _spotify_OnTrackChange
        AddHandler _spotify.OnTrackTimeChange, AddressOf _spotify_OnTrackTimeChange
    End Sub
    Private Sub ApplySize()
        Select Case My.Settings.Size
            Case "Small"
                Me.Size = SmallViewer.Size
                AlbumCover.Size = SmallViewer.AlbumCover.Size
                AlbumCover.Location = SmallViewer.AlbumCover.Location
                TrackLabel.Location = SmallViewer.TrackLabel.Location
                ArtistLabel.Location = SmallViewer.ArtistLabel.Location
                timeProgressBar.Location = SmallViewer.timeProgressBar.Location
                timeProgressBar.Size = SmallViewer.timeProgressBar.Size
                timeLabel.Visible = False
                AlbumLabel.Visible = False
            Case "Normal"
                Me.Size = NormalViewer.Size
                AlbumCover.Size = NormalViewer.AlbumCover.Size
                AlbumCover.Location = NormalViewer.AlbumCover.Location
                TrackLabel.Location = NormalViewer.TrackLabel.Location
                ArtistLabel.Location = NormalViewer.ArtistLabel.Location
                timeProgressBar.Location = NormalViewer.timeProgressBar.Location
                timeProgressBar.Size = NormalViewer.timeProgressBar.Size
                timeLabel.Visible = True
                timeLabel.Location = NormalViewer.timeLabel.Location
                timeLabel.Size = NormalViewer.timeLabel.Size
                AlbumLabel.Visible = False
            Case "Big"
                Me.Size = BigViewer.Size
                AlbumCover.Size = BigViewer.AlbumCover.Size
                AlbumCover.Location = BigViewer.AlbumCover.Location
                TrackLabel.Location = BigViewer.TrackLabel.Location
                ArtistLabel.Location = BigViewer.ArtistLabel.Location
                timeProgressBar.Location = BigViewer.timeProgressBar.Location
                timeProgressBar.Size = BigViewer.timeProgressBar.Size
                timeLabel.Visible = True
                timeLabel.Location = BigViewer.timeLabel.Location
                timeLabel.Size = BigViewer.timeLabel.Size
                AlbumLabel.Visible = True
                AlbumLabel.Location = BigViewer.AlbumLabel.Location
        End Select
    End Sub
    Private Sub GetColor()
        Select Case My.Settings.Color
            Case "Green"
                Style = MetroFramework.MetroColorStyle.Green
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Green
            Case "Black"
                Style = MetroFramework.MetroColorStyle.Black
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Black
            Case "White"
                Style = MetroFramework.MetroColorStyle.White
                timeProgressBar.Style = MetroFramework.MetroColorStyle.White
            Case "Silver"
                Style = MetroFramework.MetroColorStyle.Silver
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Silver
            Case "Blue"
                Style = MetroFramework.MetroColorStyle.Blue
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Blue
            Case "Lime"
                Style = MetroFramework.MetroColorStyle.Lime
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Lime
            Case "Teal"
                Style = MetroFramework.MetroColorStyle.Teal
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Teal
            Case "Orange"
                Style = MetroFramework.MetroColorStyle.Orange
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Orange
            Case "Brown"
                Style = MetroFramework.MetroColorStyle.Brown
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Brown
            Case "Pink"
                Style = MetroFramework.MetroColorStyle.Pink
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Pink
            Case "Magenta"
                Style = MetroFramework.MetroColorStyle.Magenta
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Magenta
            Case "Purple"
                Style = MetroFramework.MetroColorStyle.Purple
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Purple
            Case "Red"
                Style = MetroFramework.MetroColorStyle.Red
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Red
            Case "Yellow"
                Style = MetroFramework.MetroColorStyle.Yellow
                timeProgressBar.Style = MetroFramework.MetroColorStyle.Yellow
        End Select
    End Sub
    Private Sub ActivateWhite()
        'turn the lights on!
        Theme = MetroFramework.MetroThemeStyle.Light
        timeProgressBar.Theme = MetroFramework.MetroThemeStyle.Light
        timeLabel.Theme = MetroFramework.MetroThemeStyle.Light
        TrackLabel.ForeColor = Color.FromArgb(64, 64, 64)
        ArtistLabel.ForeColor = Color.FromArgb(64, 64, 64)
        AlbumLabel.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub
    Public Sub SpotifyConnect()
        timeLabel.Text = ""
        'check if Spotfiy is ready
        If Not SpotifyLocalAPI.IsSpotifyRunning Then
            Dim res As DialogResult = MessageBox.Show("Spotify isn't running! Should we try to start it?" & vbNewLine & "If this error still appears after some retrys then please start Spotify.", "Spotify", MessageBoxButtons.YesNo)
            If (res = DialogResult.Yes) Then
                'try to start it
                SpotifyLocalAPI.RunSpotify()
                Settings.ColorSettingToggle.Enabled = True
                Settings.ColorStyleBox.Enabled = True
                Settings.SizeSettingBox.Enabled = True
                Settings.ProgressStyleBox.Enabled = True
                Settings.ViewerLaunchBtn.Enabled = True
                Close()
            Else
                Settings.ColorSettingToggle.Enabled = True
                Settings.ColorStyleBox.Enabled = True
                Settings.SizeSettingBox.Enabled = True
                Settings.ProgressStyleBox.Enabled = True
                Settings.ViewerLaunchBtn.Enabled = True
                Close()
            End If
            Return
        End If
        'check if the WebHelper is running
        If Not SpotifyLocalAPI.IsSpotifyWebHelperRunning Then
            Dim res As DialogResult = MessageBox.Show("SpotifyWebHelper isn't running! Should we try to start it?" & vbNewLine & "If this error still appears after some retrys then please check your Spotify settings and activate ""Allow Spotify to be opened from the web"" and restart it.", "Spotify", MessageBoxButtons.YesNo)
            If (res = DialogResult.Yes) Then
                'try to start it
                SpotifyLocalAPI.RunSpotifyWebHelper()
                Settings.ColorSettingToggle.Enabled = True
                Settings.ColorStyleBox.Enabled = True
                Settings.SizeSettingBox.Enabled = True
                Settings.ProgressStyleBox.Enabled = True
                Settings.ViewerLaunchBtn.Enabled = True
                Close()
            Else
                Settings.ColorSettingToggle.Enabled = True
                Settings.ColorStyleBox.Enabled = True
                Settings.SizeSettingBox.Enabled = True
                Settings.ProgressStyleBox.Enabled = True
                Settings.ViewerLaunchBtn.Enabled = True
                Close()
            End If
            Return
        End If
        Dim successful As Boolean
        'Check if the WebHelper is ready to speak. It can drop some random exception if not. 
        Try
            successful = _spotify.Connect
        Catch ex As Exception
            MsgBox("Can't connect to Spotify. Please restart Spotify or check your connection." & vbNewLine & ex.Message.ToString)
            Settings.ColorSettingToggle.Enabled = True
            Settings.ColorStyleBox.Enabled = True
            Settings.SizeSettingBox.Enabled = True
            Settings.ProgressStyleBox.Enabled = True
            Settings.ViewerLaunchBtn.Enabled = True
            Close()
            Return
        End Try
        If successful Then
            Settings.ViewerLaunchBtn.Enabled = True
            Settings.ViewerLaunchBtn.Text = "Close Viewer"
            UpdateInfos()
            _spotify.ListenForEvents = True
        Else
            Dim res As DialogResult = MessageBox.Show("Couldn't connect to the spotify client. Retry?", "Spotify", MessageBoxButtons.YesNo)
            If (res = DialogResult.Yes) Then
                SpotifyConnect()
            Else
                Settings.ColorSettingToggle.Enabled = True
                Settings.ColorStyleBox.Enabled = True
                Settings.SizeSettingBox.Enabled = True
                Settings.ProgressStyleBox.Enabled = True
                Settings.ViewerLaunchBtn.Enabled = True
                Close()
            End If
        End If
    End Sub
    Private Sub SpotifyAPISleep(sender As Object, e As EventArgs) Handles Me.FormClosing
        _spotify.ListenForEvents = False
    End Sub
    Public Sub UpdateInfos()
        Dim status As StatusResponse = _spotify.GetStatus()
        If status Is Nothing Then Return
        If status.Track IsNot Nothing Then UpdateTrack(status.Track)
    End Sub
    Public Async Sub UpdateTrack(ByVal track As Track)
        _currentTrack = track
        TrackLabel.Text = If(track.IsAd(), "ADVERT", "")
        timeProgressBar.Maximum = track.Length
        If track.IsAd() Then Return
        TrackLabel.Text = track.TrackResource?.Name
        ArtistLabel.Text = track.ArtistResource?.Name
        AlbumLabel.Text = track.AlbumResource?.Name
        AlbumCover.Image = If(track.AlbumResource IsNot Nothing, Await track.GetAlbumArtAsync(AlbumArtSize.Size160), Nothing)
        'change text size when the title is longer
        ResponsiveText()
    End Sub
    Private Sub ResponsiveText()
        'Track
        Select Case TrackLabel.Text.Length
            Case 0 To 24
                TrackLabel.Font = New Font("Calibri", 20)
            Case 25 To 30
                TrackLabel.Font = New Font("Calibri", 17)
            Case 31 To 35
                TrackLabel.Font = New Font("Calibri", 15)
            Case Is >= 36
                TrackLabel.Font = New Font("Calibri", 12)
        End Select
        'Artist
        Select Case ArtistLabel.Text.Length
            Case 0 To 24
                ArtistLabel.Font = New Font("Calibri", 16)
            Case 25 To 30
                ArtistLabel.Font = New Font("Calibri", 14)
            Case 31 To 35
                ArtistLabel.Font = New Font("Calibri", 12)
            Case Is >= 36
                ArtistLabel.Font = New Font("Calibri", 10)
        End Select
        'Album
        Select Case AlbumLabel.Text.Length
            Case 0 To 30
                AlbumLabel.Font = New Font("Calibri", 14)
            Case 31 To 35
                AlbumLabel.Font = New Font("Calibri", 12)
            Case Is >= 36
                AlbumLabel.Font = New Font("Calibri", 10)
        End Select
    End Sub
    Private Sub _spotify_OnTrackChange(ByVal sender As Object, ByVal e As TrackChangeEventArgs)
        If InvokeRequired Then
            Invoke(Sub()
                       _spotify_OnTrackChange(sender, e)
                   End Sub)
            Return
        End If
        UpdateTrack(e.NewTrack)
    End Sub
    Private Sub _spotify_OnTrackTimeChange(ByVal sender As Object, ByVal e As TrackTimeChangeEventArgs)
        If InvokeRequired Then
            Invoke(Sub()
                       _spotify_OnTrackTimeChange(sender, e)
                   End Sub)
            Return
        End If
        timeLabel.Text = $"{FormatTime(e.TrackTime)}/{FormatTime(_currentTrack.Length)}"
        If e.TrackTime < _currentTrack.Length Then timeProgressBar.Value = CInt(e.TrackTime)
    End Sub
    Private Shared Function FormatTime(ByVal sec As Double) As String
        Dim span As TimeSpan = TimeSpan.FromSeconds(sec)
        Dim secs As String = span.Seconds.ToString(), mins As String = span.Minutes.ToString()
        If secs.Length < 2 Then secs = "0" & secs
        Return mins & ":" + secs
    End Function
End Class