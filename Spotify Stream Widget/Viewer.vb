Imports SpotifyAPI.Local, SpotifyAPI.Local.Enums, SpotifyAPI.Local.Models
Imports System, System.Diagnostics, System.Globalization, System.Windows.Forms
Public Class Viewer
    Dim _spotify As New SpotifyLocalAPI
    Dim track As SpotifyResource

    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles TrackLabel.Click

    End Sub
    Public Sub SpotifyConnect()
        'check if Spotfiy is ready
        If SpotifyLocalAPI.IsSpotifyInstalled Then
            If SpotifyLocalAPI.IsSpotifyRunning Then
                If SpotifyLocalAPI.IsSpotifyWebHelperRunning Then
                    MsgBox("Everything cool!")
                    _spotify.Connect()
                    AlbumCover.Image = _spotify.GetStatus.Track.GetAlbumArt(AlbumArtSize.Size160)
                    TrackLabel.Text = _spotify.GetStatus.Track.TrackResource.Name
                    ArtistLabel.Text = _spotify.GetStatus.Track.ArtistResource.Name
                    AlbumLabel.Text = _spotify.GetStatus.Track.AlbumResource.Name
                Else
                    MsgBox("Webhelper not Running!")
                End If
            Else
                MsgBox("Spotify not running!")
            End If
        Else
            MsgBox("Spotify not installed!")
        End If
    End Sub
End Class