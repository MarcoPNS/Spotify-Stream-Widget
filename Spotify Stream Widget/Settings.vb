'===================================================================
'       Written by Marco Sadowski 
'       Last Update: 2018-07-31
'       Please add your name after mine if you edit this code <3
'
'       Usage of the Settings Form:
'       -   This is the main form which the user sees when he open the application
'       -   The user can configure the viewer form here
'===================================================================

Imports System.Net
Imports Spotify_Stream_Widget.Logger
Public Class Settings
    Dim _viewerActive As Boolean = False

    'This is the Load Event.
    '
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log("Application started")
        'check for new version
        VersionCheck.RunWorkerAsync()
        'get current settings
        VersionLabel.Text = ProductVersion
        ColorSettingToggle.Checked = My.Settings.DarkMode
        ExportSettingToggle.Checked = My.Settings.ExportMode
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
        ColorStyleBox.Text = My.Settings.Color
        Viewer.Show()
    End Sub

    'start event
    Private Sub ConnectToSpotify(sender As Object, e As EventArgs) Handles SpotifyConnectBtn.Click
        SpotifyConnectBtn.Enabled = False
        'load viewer
        Viewer.SpotifyConnect()
    End Sub

    'credit stuff
    Private Sub CreditLink_Click(sender As Object, e As EventArgs) Handles CreditLink.Click
        Process.Start("https://twitter.com/MarcoSadowski") 'best guy on earth!
    End Sub
    Private Sub ShowCredits(sender As Object, e As EventArgs) Handles CreditsLink.Click
        CreditPanel.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreditPanel.Visible = False
    End Sub
    Private Sub ReportProblemLink(sender As Object, e As EventArgs) Handles ReportLink.Click
        Process.Start("https://github.com/MarcoPNS/Spotify-Stream-Widget/issues")
    End Sub

    'This is a BackgroundWorker which check for a new version of the app.   
    'The String with the current version number comes from GitHub.
    Private Sub VersionCheck_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles VersionCheck.DoWork
        Try
            Dim version As Integer = ProductVersion.Trim({"."c})
            Dim serverResponse As String = New WebClient().DownloadString("https://raw.githubusercontent.com/MarcoPNS/Spotify-Stream-Widget/master/Release/version.md")
            If version = serverResponse.Trim({"."c}) Then
            Else
                Dim res As DialogResult = MessageBox.Show("A new version is available! Version " & serverResponse & "Do you want to check it out? ", "Spotify Stream Widget", MessageBoxButtons.YesNo)
                If (res = DialogResult.Yes) Then
                    Process.Start("https://github.com/MarcoPNS/Spotify-Stream-Widget/releases")
                Else
                End If
            End If
        Catch ex As Exception
            Log(3, "VersionCheck_DoWork() Exception: " & ex.ToString())
        End Try
        Return
    End Sub

    Private Sub ColorSettingToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ColorSettingToggle.CheckedChanged
        My.Settings.DarkMode = ColorSettingToggle.Checked
        My.Settings.Save()
        If My.Settings.DarkMode = False Then
            Viewer.ApplyLightning(1)
        Else
            Viewer.ApplyLightning(0)
        End If
    End Sub

    Private Sub SizeSettingBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeSettingBox.SelectedIndexChanged
        My.Settings.Size = SizeSettingBox.Text
        My.Settings.Save()
        Viewer.ApplySize()
    End Sub

    Private Sub ProgressStyleBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgressStyleBox.SelectedIndexChanged
        My.Settings.ProgressBarStyle = ProgressStyleBox.Text
        My.Settings.Save()
        Viewer.ApplyProgressBarStyle()
    End Sub

    Private Sub ColorStyleBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColorStyleBox.SelectedIndexChanged
        My.Settings.Color = ColorStyleBox.Text
        My.Settings.Save()
        Viewer.SetColor()
    End Sub
End Class