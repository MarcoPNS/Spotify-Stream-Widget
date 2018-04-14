Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get current settings
        VersionLabel.Text = Me.ProductVersion
        ColorSettingToggle.Checked = My.Settings.DarkMode
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
        ColorStyleBox.Text = My.Settings.Color
    End Sub

    Private Sub StartViewer(sender As Object, e As EventArgs) Handles ViewerControl.Click
        'save settings
        My.Settings.Size = SizeSettingBox.Text
        My.Settings.DarkMode = ColorSettingToggle.Checked
        My.Settings.ProgressBarStyle = ProgressStyleBox.Text
        My.Settings.Color = ColorStyleBox.Text
        My.Settings.Save()
        'load viewer
        Select Case SizeSettingBox.Text
            Case "Small"
                SmallViewer.Show()
                SmallViewer.SpotifyConnect()
            Case "Normal"
                NormalViewer.Show()
                NormalViewer.SpotifyConnect()
            Case "Big"
                BigViewer.Show()
                BigViewer.SpotifyConnect()
        End Select
    End Sub

    Private Sub CreditLink_Click(sender As Object, e As EventArgs) Handles CreditLink.Click
        Process.Start("https://twitter.com/MarcoSadowski")
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles CreditsLink.Click
        CreditPanel.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreditPanel.Visible = False
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles ReportLink.Click
        Process.Start("https://github.com/MarcoPNS/Spotify-Stream-Widget/issues")
    End Sub
End Class
