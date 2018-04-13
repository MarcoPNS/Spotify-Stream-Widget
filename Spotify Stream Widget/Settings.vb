Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorSettingToggle.Checked = My.Settings.DarkMode
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
    End Sub

    Private Sub StartViewer(sender As Object, e As EventArgs) Handles ViewerControl.Click
        My.Settings.Size = SizeSettingBox.Text
        My.Settings.DarkMode = ColorSettingToggle.Checked
        My.Settings.Save()

        If SizeSettingBox.Text = "Small" Then
            SmallViewer.Show()
            SmallViewer.SpotifyConnect()
        End If
        If SizeSettingBox.Text = "Normal" Then
            NormalViewer.Show()
            NormalViewer.SpotifyConnect()
        End If
        If SizeSettingBox.Text = "Big" Then
            BigViewer.Show()
            BigViewer.SpotifyConnect()
        End If
    End Sub
    Private Sub LoadViewer()
        If ColorSettingToggle.Checked = True Then
            BigViewer.Show()
            BigViewer.SpotifyConnect()
        Else
            BigViewer.Show()
            BigViewer.SpotifyConnect()
        End If
    End Sub

    Private Sub CreditLink_Click(sender As Object, e As EventArgs) Handles CreditLink.Click
        Process.Start("https://twitter.com/MarcoSadowski")
    End Sub
End Class
