Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewerControl.Click

        Viewer.Show()
        Viewer.SpotifyConnect()
    End Sub
    Private Sub LoadViewer()
        If DarkWindow.Checked = True Then
            Viewer.Show()
            Viewer.SpotifyConnect()
        Else
            Viewer.Show()
            Viewer.SpotifyConnect()
        End If
    End Sub

    Private Sub CreditLink_Click(sender As Object, e As EventArgs) Handles CreditLink.Click
        Process.Start("https://twitter.com/MarcoSadowski")
    End Sub
End Class
