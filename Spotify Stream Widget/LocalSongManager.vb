Imports Spotify_Stream_Widget.Logger

Public Class LocalSongManager
    'The purpose of this class is to give cover images for local songs because they aren't given by Spotify.
    'To Use: Initialize with a directory path containing the local songs that will be played on Spotify
    '( eg C:/Users/user/Music/ )
    'Then call ImageForSong(title, artist) to get the album cover if there's a matching local song and it has a cover. 

    Public Sub New(dir As String)
        InitLocalDir(dir)
    End Sub

    Public Sub InitLocalDir(dir As String)
        Log(1, "Reading local songs in " + dir)
    End Sub

    Public Function ImageForSong(title As String, artist As String) As Drawing.Image
        Return My.Resources.albumArt
    End Function

End Class