'===================================================================
'       Written by Marco Sadowski, J. Wong
'       Last Update: 2020-10-08
'       Please add your name after mine if you edit this code <3
'
'       Usage of the Settings Form:
'       -   This is the main form which the user sees when he open the application
'       -   The user can configure the viewer form here
'===================================================================

Imports System.IO, System.Net, System.Text.RegularExpressions
Public Class Settings
    'This is the Load Event.
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log("Application started - v" + ProductVersion)
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
            Dim version As Integer = Int32.Parse(Regex.Replace(ProductVersion, "\D", ""))
            Dim serverResponse As String = New WebClient().DownloadString("https://raw.githubusercontent.com/MarcoPNS/Spotify-Stream-Widget/master/Release/version.md")
            If serverResponse.Length = 7 Then
                Dim onlineVersion As Integer = Int32.Parse(Regex.Replace(serverResponse, "\D", ""))
                If Not version >= onlineVersion Then

                    Dim res As DialogResult = MessageBox.Show("A new version is available! Version " & serverResponse & vbNewLine & "Do you want to check it out? ", "Spotify Stream Widget", MessageBoxButtons.YesNo)
                    If (res = DialogResult.Yes) Then
                        Process.Start("https://github.com/MarcoPNS/Spotify-Stream-Widget/releases")
                    End If
                End If
            Else
                Log(3, "VersionCheck with invalid serverResponse: " & serverResponse)
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

    Private Sub ExportFolderBtn_Click(sender As Object, e As EventArgs) Handles ExportFolderBtn.Click
        Process.Start(Application.StartupPath + "/exported-details/")
    End Sub

    Private Sub ExportSettingToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ExportSettingToggle.CheckedChanged
        If Directory.Exists(Application.StartupPath + "/exported-details/") = False Then
            Try
                Directory.CreateDirectory(Application.StartupPath + "/exported-details/")
            Catch ex As Exception
                Log(3, ex.ToString())
                MsgBox("Can't create Directory for the exported Details. Please check the permissions of the application folder and try again. More Details can be found in the log file.")
                Exit Sub
            End Try
        End If
        My.Settings.ExportMode = ExportSettingToggle.Checked
        My.Settings.Save()
    End Sub

    Private Sub ChooseLocalDir()
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            'set label showing directory
            Dim dir = FolderBrowserDialog1.SelectedPath
            LocalDirValueLabel.Text = dir
        End If
    End Sub

    Private Sub LocalDirBtn_Click(sender As Object, e As EventArgs) Handles LocalDirBtn.Click
        ChooseLocalDir()
    End Sub

    Private Sub LocalDirValueLabel_Click(sender As Object, e As EventArgs) Handles LocalDirValueLabel.Click
        ChooseLocalDir()
    End Sub

    Private Sub CloseApp(sender As Object, e As EventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class