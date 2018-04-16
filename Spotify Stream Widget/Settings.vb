Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get current settings
        VersionLabel.Text = ProductVersion
        ColorSettingToggle.Checked = My.Settings.DarkMode
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
        ColorStyleBox.Text = My.Settings.Color
    End Sub
    'TODO: just a idea - To fix the problem with the "new viewer" maybe just call the SpotifyAPI only in the main form and not in the viewer.
    Dim ActiveViewer As Form = SmallViewer
    'start event
    Private Sub StartViewer(sender As Object, e As EventArgs) Handles ViewerLaunchBtn.Click
        'close the old viewer
        'TODO: "new viewer feature" need some rework. It produce a lot of memory garbage.
        If ViewerLaunchBtn.Text = "Close Viewer" Then
            Viewer.Close()
            ViewerLaunchBtn.Text = "Open Viewer"
            Return
        End If
        ViewerLaunchBtn.Enabled = False
        'save settings
        My.Settings.Size = SizeSettingBox.Text
        My.Settings.DarkMode = ColorSettingToggle.Checked
        My.Settings.ProgressBarStyle = ProgressStyleBox.Text
        My.Settings.Color = ColorStyleBox.Text
        My.Settings.Save()
        'load viewer
        Viewer.Show()
        Viewer.SpotifyConnect()
    End Sub
    'credit stuff
    Private Sub CreditLink_Click(sender As Object, e As EventArgs) Handles CreditLink.Click
        Process.Start("https://twitter.com/MarcoSadowski") 'best guy on earth!
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