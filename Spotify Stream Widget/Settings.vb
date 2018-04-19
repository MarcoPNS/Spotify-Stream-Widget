Imports System.Threading, System.Net
Public Class Settings

    'load stuff
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check for new version
        VersionCheck.RunWorkerAsync()
        'get current settings
        VersionLabel.Text = ProductVersion
        ColorSettingToggle.Checked = My.Settings.DarkMode
        ReloadToggle.Checked = My.Settings.HideReload
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
        ColorStyleBox.Text = My.Settings.Color
    End Sub

    'start event
    Private Sub StartViewer(sender As Object, e As EventArgs) Handles ViewerLaunchBtn.Click
        'close the viewer
        If ViewerLaunchBtn.Text = "Close Viewer" Then
            Viewer.Close()
            ColorSettingToggle.Enabled = True
            ColorStyleBox.Enabled = True
            SizeSettingBox.Enabled = True
            ProgressStyleBox.Enabled = True
            ViewerLaunchBtn.Text = "Open Viewer"
            Return
        End If
        ViewerLaunchBtn.Enabled = False
        'save settings
        My.Settings.Size = SizeSettingBox.Text
        My.Settings.DarkMode = ColorSettingToggle.Checked
        My.Settings.ProgressBarStyle = ProgressStyleBox.Text
        My.Settings.Color = ColorStyleBox.Text
        My.Settings.HideReload = ReloadToggle.Checked
        My.Settings.Save()
        ColorSettingToggle.Enabled = False
        ColorStyleBox.Enabled = False
        SizeSettingBox.Enabled = False
        ProgressStyleBox.Enabled = False
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

    'check for updates
    Private Sub VersionCheck_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles VersionCheck.DoWork
        Try
            Dim Version As Integer = Me.ProductVersion.Trim({"."c})
            Dim ServerResponse As String = New WebClient().DownloadString("https://raw.githubusercontent.com/MarcoPNS/Spotify-Stream-Widget/master/Release/version.md")
            If Version = ServerResponse.Trim({"."c}) Then
            Else
                Dim res As DialogResult = MessageBox.Show("A new version is available! & (v" & ServerResponse & ") Do you want to check it out? ", "Spotify", MessageBoxButtons.YesNo)
                If (res = DialogResult.Yes) Then
                    Process.Start("https://github.com/MarcoPNS/Spotify-Stream-Widget/releases")
                Else
                End If
            End If
        Catch ex As Exception
        End Try
        Return
    End Sub
End Class