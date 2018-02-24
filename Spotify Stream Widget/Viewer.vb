Imports SpotifyAPI.Local, SpotifyAPI.Local.Enums, SpotifyAPI.Local.Models
Imports System, System.Diagnostics, System.Globalization, System.Windows.Forms, System.Threading, System.ComponentModel
Public Class Viewer
    Private _spotify As SpotifyLocalAPI
    Private _currentTrack As Track
    Public Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _spotify = New SpotifyLocalAPI()
        AddHandler _spotify.OnPlayStateChange, AddressOf _spotify_OnPlayStateChange
        AddHandler _spotify.OnTrackChange, AddressOf _spotify_OnTrackChange
        AddHandler _spotify.OnTrackTimeChange, AddressOf _spotify_OnTrackTimeChange
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub SpotifyConnect()
        'check if Spotfiy is ready
        If Not SpotifyLocalAPI.IsSpotifyRunning Then
            MessageBox.Show("Spotify isn't running!")
            Return
        End If

        If Not SpotifyLocalAPI.IsSpotifyWebHelperRunning Then
            MessageBox.Show("SpotifyWebHelper isn't running!")
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

        _spotify.Connect()
    End Sub
    Public Sub UpdateInfos()
        TrackLabel.Text = _spotify.GetStatus.Track.TrackResource.Name
        ArtistLabel.Text = _spotify.GetStatus.Track.ArtistResource.Name
        AlbumLabel.Text = _spotify.GetStatus.Track.AlbumResource.Name
        AlbumCover.Image = _spotify.GetStatus.Track.GetAlbumArt(AlbumArtSize.Size160)
    End Sub
    Public Sub _spotify_OnTrackChange(ByVal sender As Object, ByVal e As TrackChangeEventArgs)
        Console.Write("Track changed")
        Dim Status As StatusResponse = _spotify.GetStatus
        If Status Is Nothing Then
        Else
            TrackLabel.Text = _spotify.GetStatus.Track.TrackResource.Name
            ArtistLabel.Text = _spotify.GetStatus.Track.ArtistResource.Name
            AlbumLabel.Text = _spotify.GetStatus.Track.AlbumResource.Name
            AlbumCover.Image = _spotify.GetStatus.Track.GetAlbumArt(AlbumArtSize.Size160)
        End If
    End Sub
    Public Sub _spotify_OnTrackTimeChange()
        Console.Write("Track Time changed")
    End Sub
    Public Sub _spotify_OnPlayStateChange()
        Console.Write("Play State changed")
    End Sub
End Class