'===================================================================
'       Written by Marco Sadowski
'       Last Update: 2019-09-27
'       Please add your name after mine if you edit this code <3
'
'       Usage of the Viewer Form:
'       -   This is the main viewer which shows the current track from Spotify 
'       -   The Viewer uses the SmallViewer, NormalViewer and BigViewer as Template.
'       -   If you want to change the look of the form then you need to edit the templates, not this form.
'===================================================================

Imports SpotifyAPI.Web, SpotifyAPI.Web.Auth, SpotifyAPI.Web.Enums, SpotifyAPI.Web.Models
Imports Spotify_Stream_Widget.Logger
Public Class Viewer
    Private Shared _spotify As SpotifyWebAPI
    Shared ReadOnly ClientId = "2ee62a35a2ec45a4a7fe26b81f7f3681"
    Private Shared _spotifyAuth As ImplicitGrantAuth = New ImplicitGrantAuth(ClientId, "http://localhost:4002", "http://localhost:4002", Scope.UserReadPlaybackState)
    Dim _playback As PlaybackContext
    Dim _currentTrackId As String

    'The Load Event apply the user settings and the event handler for the spotify API
    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyProgressBarStyle()
        ApplySize()
        If My.Settings.DarkMode = False Then
            ActivateWhite()
        End If
        SetColor()
    End Sub


#Region "Apply User Settings"
    'The user settings will be applied in this region. It change this size, change the color and change the theme.
    'If there is a new option that need to be applied in the viewer then add it in this region.
    Private Sub ApplyProgressBarStyle()
        Select Case My.Settings.ProgressBarStyle
            Case "Blocks"
                timeProgressBar.ProgressBarStyle = ProgressBarStyle.Blocks
            Case "Continuous"
                timeProgressBar.ProgressBarStyle = ProgressBarStyle.Continuous
            Case "Marquee"
                timeProgressBar.ProgressBarStyle = ProgressBarStyle.Marquee
        End Select
    End Sub

    'copy the location of the objects and the size from the template based on the user settings.
    Private Sub ApplySize()
        Select Case My.Settings.Size
            Case "Small"
                Size = SmallViewer.Size
                AlbumCover.Size = SmallViewer.AlbumCover.Size
                AlbumCover.Location = SmallViewer.AlbumCover.Location
                TrackLabel.Location = SmallViewer.TrackLabel.Location
                ArtistLabel.Location = SmallViewer.ArtistLabel.Location
                timeProgressBar.Location = SmallViewer.timeProgressBar.Location
                timeProgressBar.Size = SmallViewer.timeProgressBar.Size
                timeLabel.Visible = False
                AlbumLabel.Visible = False
            Case "Normal"
                Size = NormalViewer.Size
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
                Size = BigViewer.Size
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

    'change the style color of the viewer
    Private Sub SetColor()
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

    'activate the Metro UI Light Theme // normaly it is dark so only needed to be switched when the user want a light overlay
    Private Sub ActivateWhite()
        Theme = MetroFramework.MetroThemeStyle.Light
        timeProgressBar.Theme = MetroFramework.MetroThemeStyle.Light
        timeLabel.Theme = MetroFramework.MetroThemeStyle.Light
        TrackLabel.ForeColor = Color.FromArgb(64, 64, 64)
        ArtistLabel.ForeColor = Color.FromArgb(64, 64, 64)
        AlbumLabel.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

#End Region


    'Connects with Spotify. Needs to be called before all other SpotifyAPI functions
    Public Sub SpotifyConnect()
        timeLabel.Text = ""
        Settings.ViewerLaunchBtn.Text = "Close Viewer"
        Settings.ViewerLaunchBtn.Enabled = True
        'Spotify Auth
        MsgBox("The Widget will open your browser to connect to the Spotify API")
        AddHandler _spotifyAuth.AuthReceived, AddressOf _spotify_AuthReceived
        _spotifyAuth.Start()
        _spotifyAuth.OpenBrowser()
        UpdateTrack()
    End Sub

    Private Sub _spotify_AuthReceived(sender, payload)
        _spotifyAuth.Stop()
        _spotify = New SpotifyWebAPI() With {
                .TokenType = payload.TokenType,
                .AccessToken = payload.AccessToken
                }
    End Sub

    'Pause the work of the SpotifyAPI when the viewer is closed
    Private Sub SpotifyApiSleep(sender As Object, e As EventArgs) Handles Me.FormClosing
        Settings.ColorSettingToggle.Enabled = True
        Settings.ColorStyleBox.Enabled = True
        Settings.SizeSettingBox.Enabled = True
        Settings.ProgressStyleBox.Enabled = True
        Settings.ViewerLaunchBtn.Enabled = True
        Settings.ViewerLaunchBtn.Text = "Open Viewer"
    End Sub

    Private Async Sub UpdateTrack()

        'If the API is not authorized yet then _spotify is nothing. 
        'I don't trigger UpdateTrack() after AuthReceived got fired because I don't want to Invoke everything.
        If _spotify Is Nothing Then
            Await Task.Delay(5000)
            UpdateTrack()
            Return
        End If

        'get the current track
        _playback = _spotify.GetPlayback()
        
        If _playback.HasError() Then
            Log(2, "Error Status: " & _playback.Error.Status & " Msg: " & _playback.Error.Message)
            Await Task.Delay(5000)
            UpdateTrack()
            Return
        End If

        If _playback.Item Is Nothing Then
            Await Task.Delay(5000)
            UpdateTrack()
            Return
        End If

        'update the time
        timeProgressBar.Maximum = _playback.Item.DurationMs
        timeLabel.Text = $"{FormatTime(_playback.ProgressMs)}/{FormatTime(_playback.Item.DurationMs)}"
        If _playback.ProgressMs < _playback.Item.DurationMs Then timeProgressBar.Value = CInt(_playback.ProgressMs)

        'check if the song is the same so the entire UI don't need to update
        If _currentTrackId = _playback.Item.Uri Then
            Await Task.Delay(2000)
            UpdateTrack()
            Return
        Else
            _currentTrackId = _playback.Item.Uri
        End If
        
        If _playback.Item.Error IsNot Nothing Then
            MsgBox(_playback.Item.Error.Message)
            Return
        End If

        TrackLabel.Text = _playback.Item.Name
        Dim artists = ""
        For Each artist As SimpleArtist In _playback.Item.Artists
            If artists = "" Then
                artists = artist.Name
            Else
                artists = artists + " - " + artist.Name
            End If
           
        Next
        ArtistLabel.Text = artists
        AlbumLabel.Text = _playback.Item.Album.Name

        If _playback.Item.Album.Images.Count > 0 Then
            Try

                AlbumCover.Image = If(_playback.Item.Album.Images.Item(0).Url IsNot Nothing, GetImageFromUri(_playback.Item.Album.Images.Item(1).Url), Nothing)
            Catch ex As Exception
                Log(3, "AlbumCover Exception: " & ex.ToString())
                Dim iDefaultImage As Drawing.Image = New Bitmap(1, 1)
                AlbumCover.Image = iDefaultImage
            End Try
        Else 
            AlbumCover.Image = My.Resources.albumArt
        End If

        'change text size when the title is longer
        ResponsiveText()

        Await Task.Delay(1000)
        UpdateTrack()
    End Sub

    'change the text size based on the text length
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

    Private Shared Function FormatTime(ByVal ms As Double) As String
        Dim span As TimeSpan = TimeSpan.FromMilliseconds(ms)
        Dim secs As String = span.Seconds.ToString(), mins As String = span.Minutes.ToString()
        If secs.Length < 2 Then secs = "0" & secs
        Return mins & ":" + secs
    End Function

    Private Function GetImageFromUri(ByVal url As String) As Drawing.Image

        Dim retVal As Drawing.Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As Net.WebRequest = Net.WebRequest.Create(url.Trim)

                Using request As Net.WebResponse = req.GetResponse
                    Using stream As IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            Log(3, "GetImageFromUri() Exception: " & ex.ToString())
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}", vbCrLf, ex.Message), "Exception Thrown", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return retVal

    End Function
End Class
