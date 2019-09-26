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

    'This is the Load Event.
    '
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log("Application started")
        'check for new version
        VersionCheck.RunWorkerAsync()
        'get current settings
        VersionLabel.Text = ProductVersion
        ColorSettingToggle.Checked = My.Settings.DarkMode
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
        ColorStyleBox.Text = My.Settings.Color
    End Sub

    'start event
    Private Sub StartViewer(sender As Object, e As EventArgs) Handles ViewerLaunchBtn.Click
        'close the viewer
        If ViewerLaunchBtn.Text = "Close Viewer" Then
            Log("Viewer closed")
            Viewer.Close()
            Return
        End If
        ViewerLaunchBtn.Enabled = False
        'save settings
        My.Settings.Size = SizeSettingBox.Text
        My.Settings.DarkMode = ColorSettingToggle.Checked
        My.Settings.ProgressBarStyle = ProgressStyleBox.Text
        My.Settings.Color = ColorStyleBox.Text
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

End Class