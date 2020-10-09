Imports Spotify_Stream_Widget.Logger

Public Class LocalSongManager
    'The purpose of this class is to give cover images for local songs because they aren't given by Spotify.
    'To Use: Initialize with a directory path containing the local songs that will be played on Spotify
    '( eg C:/Users/user/Music/ )
    'Then call ImageForSong(title, artist) to get the album cover if there's a matching local song. 

    Dim _dict As New Dictionary(Of String, String)
    Dim _validExtensions As HashSet(Of String) = New HashSet(Of String)({".aa", ".aax", ".aac", ".aiff", ".ape", ".dsf", ".flac", ".m4a", ".m4b", ".m4p", ".mp3", ".mpc", ".mpp", ".ogg", ".oga", ".wav", ".wma", ".wv", ".webm"})
    '   extensions from taglib docs: https://github.com/mono/taglib-sharp

    Public Sub New(dir As String)
        InitLocalDir(dir)
    End Sub

    Public Sub InitLocalDir(dir As String)
        'Given a directory path, set list of local song files (will searched thru later by Viewer)
        'Should be async, but too much of a hassle. 
        'Only UX annoyance will be that thumbnail won't update live when local dir is set.

        For Each filepath In IO.Directory.GetFiles(dir, "*.*").Where(Function(f) IsAudio(f))

            Try
                Dim title = "<None>"    'Technically this placeholder could cause problems if there's a song/artist called <None>...
                Dim artist = "<None>"

                Dim file As TagLib.File = TagLib.File.Create(filepath)
                title = file.Tag.Title

                'most likely cause of error when local file has no artist metadata
                If file.Tag.Performers.Length > 0 Then
                    artist = file.Tag.Performers(0)
                Else
                    Log(3, "Song at " + filepath + " has no artist")
                End If

                Dim key = Serialized(title, artist)
                _dict.Add(key, filepath)

            Catch ex As Exception
                Log(2, "Couldn't add local song at " + filepath + ": " + ex.ToString())
            End Try

        Next

        Log(1, "Added " + _dict.Count.ToString() + " local files: " + DictToString(_dict))
    End Sub

    Public Function ImageForSong(title As String, artist As String) As Drawing.Image
        'Returns cover image for a desired song, searched for using title and artist.
        'Returns default cover image if not found or error.

        Dim retval As Drawing.Image = My.Resources.albumArt
        Dim key As String = Serialized(title, artist)

        Try

            If _dict.ContainsKey(key) Then
                Dim path As String = _dict.Item(key)
                retval = GetImageFromPath(path)
            Else
                Log(3, title + " by " + artist + " not found in local folder.")
            End If

        Catch ex As Exception

            Log(2, "Error in ImageForSong(" + title + ", " + artist + "): " + ex.ToString())
        End Try

        Return retval

    End Function

    Private Function Serialized(title As String, artist As String) As String
        'For safer coverage, use album as well or at least instead of artist
        'Eg. an artist may cover a particular song twice and have same title, resulting in nonunique serialization
        Return title + artist
    End Function

    Private Function GetImageFromPath(path As String) As Drawing.Image

        Dim file = TagLib.File.Create(path)
        Dim retval As Drawing.Image = Nothing

        Try

            Using stream As New IO.MemoryStream(file.Tag.Pictures(0).Data.Data)
                retval = New Bitmap(Drawing.Image.FromStream(stream))
            End Using

        Catch ex As Exception

            retval = My.Resources.albumArt
            Log(3, "Couldn't getting cover image from local song at " + path)
        End Try

        Return retval

    End Function

    Private Function DictToString(dict As Dictionary(Of String, String)) As String
        'For debugging.
        Return String.Join(" -- ", dict.Select(Function(kvp) String.Format("{0},{1}", kvp.Key, kvp.Value)).ToArray())
    End Function

    Private Function IsAudio(filepath) As Boolean
        Return _validExtensions.Contains(IO.Path.GetExtension(filepath).ToLower())
    End Function

End Class