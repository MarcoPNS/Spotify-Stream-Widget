Imports SpotifyAPI.Local, SpotifyAPI.Local.Enums, SpotifyAPI.Local.Models
Public Class NormalViewer
    Private _spotify As SpotifyLocalAPI
    Private _currentTrack As Track
    Public Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        _spotify = New SpotifyLocalAPI()
        AddHandler _spotify.OnPlayStateChange, AddressOf _spotify_OnPlayStateChange
        AddHandler _spotify.OnTrackChange, AddressOf _spotify_OnTrackChange
        AddHandler _spotify.OnTrackTimeChange, AddressOf _spotify_OnTrackTimeChange
    End Sub
    Private Sub ActivateWhite()
        Me.Theme = MetroFramework.MetroThemeStyle.Light
        timeProgressBar.Theme = MetroFramework.MetroThemeStyle.Light
        timeLabel.Theme = MetroFramework.MetroThemeStyle.Light
        TrackLabel.ForeColor = Color.FromArgb(64, 64, 64)
        ArtistLabel.ForeColor = Color.FromArgb(64, 64, 64)

    End Sub
    Public Sub SpotifyConnect()
        timeLabel.Text = ""
        'check if Spotfiy is ready
        If Not SpotifyLocalAPI.IsSpotifyRunning Then
            MessageBox.Show("Spotify isn't running!")
            Me.Close()
            Return
        End If

        If Not SpotifyLocalAPI.IsSpotifyWebHelperRunning Then
            MessageBox.Show("SpotifyWebHelper isn't running!")
            Me.Close()
            Return
        End If

        Dim successful As Boolean = _spotify.Connect
        If successful Then
            Settings.ViewerControl.Text = "Connection to Spotify successful"
            Settings.ViewerControl.Enabled = False
            UpdateInfos()
            _spotify.ListenForEvents = True
        Else
            Dim res As DialogResult = MessageBox.Show("Couldn't connect to the spotify client. Retry?", "Spotify", MessageBoxButtons.YesNo)
            If (res = DialogResult.Yes) Then
                SpotifyConnect()
            End If
        End If
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
        AlbumCover.Image = If(track.AlbumResource IsNot Nothing, Await track.GetAlbumArtAsync(AlbumArtSize.Size160), Nothing)
        'change text size when the title is longer
        ResponsiveText()
    End Sub
    Private Sub ResponsiveText()
        'Track
        If TrackLabel.Text.Length < 21 Then
            TrackLabel.Font = New Font("Calibri", 20)
        End If
        If TrackLabel.Text.Length > 20 Then
            TrackLabel.Font = New Font("Calibri", 17)
        End If
        If TrackLabel.Text.Length > 25 Then
            TrackLabel.Font = New Font("Calibri", 15)
        End If
        If TrackLabel.Text.Length > 30 Then
            TrackLabel.Font = New Font("Calibri", 12)
        End If
        'Artist
        If ArtistLabel.Text.Length < 21 Then
            ArtistLabel.Font = New Font("Calibri", 16)
        End If
        If ArtistLabel.Text.Length > 20 Then
            ArtistLabel.Font = New Font("Calibri", 14)
        End If
        If ArtistLabel.Text.Length > 25 Then
            ArtistLabel.Font = New Font("Calibri", 12)
        End If
        If ArtistLabel.Text.Length > 30 Then
            ArtistLabel.Font = New Font("Calibri", 10)
        End If
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
    Public Sub _spotify_OnTrackTimeChange_(ByVal sender As Object, ByVal e As TrackTimeChangeEventArgs)
        Console.Write("Track Time changed")
        Try
            timeLabel.Text = _currentTrack.Length & " - " & e.TrackTime
        Catch ex As Exception
        End Try
        'If (e.TrackTime < Me._currentTrack.Length) Then
        'timeProgressBar.Value = CType(e.TrackTime, Integer)
        'End If
    End Sub
    Public Sub _spotify_OnPlayStateChange()
        Console.Write("Play State changed")
    End Sub

    Private Sub timeLabel_Click(sender As Object, e As EventArgs) Handles timeLabel.Click

    End Sub
End Class