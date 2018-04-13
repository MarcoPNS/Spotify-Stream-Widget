﻿Imports SpotifyAPI.Local, SpotifyAPI.Local.Enums, SpotifyAPI.Local.Models
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

    Public Sub SpotifyConnect()
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
        AlbumLabel.Text = track.AlbumResource?.Name
        AlbumCover.Image = If(track.AlbumResource IsNot Nothing, Await track.GetAlbumArtAsync(AlbumArtSize.Size160), Nothing)
        'change text size when the title is longer
        If TrackLabel.Text.Length < 21 Then
            TrackLabel.Font = New Font("Calibri", 20)
        End If
        If TrackLabel.Text.Length > 20 Then
            TrackLabel.Font = New Font("Calibri", 12)
        End If
    End Sub

    'backup
    Public Sub UpdateInfos_()
        TrackLabel.Text = _spotify.GetStatus.Track.TrackResource.Name
        'change text size when the title is longer
        If TrackLabel.Text.Length < 21 Then
            TrackLabel.Font = New Font("Calibri", 20)
        End If
        If TrackLabel.Text.Length > 20 Then
            TrackLabel.Font = New Font("Calibri", 12)
        End If
        Try
            TrackLabel.Text = ""
            ArtistLabel.Text = ""
            AlbumLabel.Text = ""
            AlbumCover.Image = Nothing
            ArtistLabel.Text = _spotify.GetStatus.Track.ArtistResource.Name
            AlbumLabel.Text = _spotify.GetStatus.Track.AlbumResource.Name
            AlbumCover.Image = _spotify.GetStatus.Track.GetAlbumArt(AlbumArtSize.Size160)
        Catch ex As Exception

        End Try
        'timeProgressBar.Maximum = _currentTrack.Length
    End Sub



    'Public Sub _spotify_OnTrackChange__(ByVal sender As Object, ByVal e As TrackChangeEventArgs)
    '   Console.Write("Track changed")
    'Try
    '       UpdateInfos()
    'Catch ex As Exception
    'End Try
    'End Sub

    Private Sub _spotify_OnTrackChange(ByVal sender As Object, ByVal e As TrackChangeEventArgs)
        If InvokeRequired Then
            Invoke(Sub()
                       _spotify_OnTrackChange(sender, e)
                   End Sub)
            Return
        End If

        UpdateTrack(e.NewTrack)
    End Sub
    Public Sub _spotify_OnTrackTimeChange(ByVal sender As Object, ByVal e As TrackTimeChangeEventArgs)
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
End Class