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
        VersionLabel.Text = "v" + ProductVersion
        ColorSettingToggle.Checked = My.Settings.DarkMode
        ExportSettingToggle.Checked = My.Settings.ExportMode
        SizeSettingBox.Text = My.Settings.Size
        ProgressStyleBox.Text = My.Settings.ProgressBarStyle
        ColorStyleBox.Text = My.Settings.Color
        If Not String.IsNullOrEmpty(My.Settings.LocalDir) Then
            Viewer.InitLocalDir(My.Settings.LocalDir)
            LocalDirValueLabel.Text = My.Settings.LocalDir
        End If
        Viewer.Show()
    End Sub

    'Set colours'
    Public Sub SetSettingsColor()
        Select Case My.Settings.Color
            Case "Green"
                Style = MetroFramework.MetroColorStyle.Green
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Green
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Green
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Green
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Green
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Green
            Case "Black"
                Style = MetroFramework.MetroColorStyle.Black
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Black
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Black
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Black
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Black
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Black
            Case "White"
                Style = MetroFramework.MetroColorStyle.White
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.White
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.White
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.White
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.White
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.White
            Case "Silver"
                Style = MetroFramework.MetroColorStyle.Silver
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Silver
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Silver
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Silver
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Silver
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Silver
            Case "Blue"
                Style = MetroFramework.MetroColorStyle.Blue
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Blue
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Blue
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Blue
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Blue
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Blue
            Case "Lime"
                Style = MetroFramework.MetroColorStyle.Lime
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Lime
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Lime
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Lime
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Lime
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Lime
            Case "Teal"
                Style = MetroFramework.MetroColorStyle.Teal
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Teal
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Teal
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Teal
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Teal
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Teal
            Case "Orange"
                Style = MetroFramework.MetroColorStyle.Orange
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Orange
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Orange
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Orange
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Orange
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Orange
            Case "Brown"
                Style = MetroFramework.MetroColorStyle.Brown
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Brown
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Brown
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Brown
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Brown
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Brown
            Case "Pink"
                Style = MetroFramework.MetroColorStyle.Pink
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Pink
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Pink
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Pink
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Pink
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Pink
            Case "Magenta"
                Style = MetroFramework.MetroColorStyle.Magenta
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Magenta
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Magenta
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Magenta
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Magenta
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Magenta
            Case "Purple"
                Style = MetroFramework.MetroColorStyle.Purple
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Purple
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Purple
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Purple
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Purple
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Purple
            Case "Red"
                Style = MetroFramework.MetroColorStyle.Red
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Red
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Red
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Red
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Red
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Red
            Case "Yellow"
                Style = MetroFramework.MetroColorStyle.Yellow
                ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Yellow
                ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Yellow
                SizeSettingBox.Style = MetroFramework.MetroColorStyle.Yellow
                ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Yellow
                ColorStyleBox.Style = MetroFramework.MetroColorStyle.Yellow
            Case "Custom"
                Style = MetroFramework.MetroColorStyle.Silver
        End Select
        Refresh()
    End Sub

    Public Sub ApplySettingLightning(mode As Integer)
        If mode = 1 Then
            Theme = MetroFramework.MetroThemeStyle.Light

            ColorSettingToggle.Theme = MetroFramework.MetroThemeStyle.Light
            ExportSettingToggle.Theme = MetroFramework.MetroThemeStyle.Light
            SizeSettingBox.Theme = MetroFramework.MetroThemeStyle.Light
            ProgressStyleBox.Theme = MetroFramework.MetroThemeStyle.Light
            ColorStyleBox.Theme = MetroFramework.MetroThemeStyle.Light
        Else
            Theme = MetroFramework.MetroThemeStyle.Dark

            ColorSettingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
            ExportSettingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
            SizeSettingBox.Theme = MetroFramework.MetroThemeStyle.Dark
            ProgressStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
            ColorStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
        End If
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
    Private Sub ReportProblemLink(sender As Object, e As EventArgs) Handles ReportLink.Click
        Process.Start("https://github.com/Dankyss/Spotify-Stream-Widget/issues")
    End Sub

    'This is a BackgroundWorker which check for a new version of the app.   
    'The String with the current version number comes from GitHub.
    Private Sub VersionCheck_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles VersionCheck.DoWork
        Try
            Dim version As Integer = Int32.Parse(Regex.Replace(ProductVersion, "\D", ""))
            Dim serverResponse As String = New WebClient().DownloadString("https://raw.githubusercontent.com/Dankyss/Spotify-Stream-Widget/main/Release/version.md")
            If serverResponse.Length = 7 Then
                Dim onlineVersion As Integer = Int32.Parse(Regex.Replace(serverResponse, "\D", ""))
                If Not version >= onlineVersion Then

                    Dim res As DialogResult = MessageBox.Show("A new version is available! Version " & serverResponse & vbNewLine & "Do you want to check it out? ", "Spotify Stream Widget", MessageBoxButtons.YesNo)
                    If (res = DialogResult.Yes) Then
                        Process.Start("https://github.com/Dankyss/Spotify-Stream-Widget/releases")
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
            ApplySettingLightning(1)
            Refresh()
        Else
            Viewer.ApplyLightning(0)
            ApplySettingLightning(0)
            Refresh()
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
        SetSettingsColor()
        Refresh()
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

    'choose local file folder from dialog, then init manager in Viewer
    Private Sub ChooseLocalDir()
        If (FolderDialog.ShowDialog() = DialogResult.OK) Then
            Dim dir = FolderDialog.SelectedPath

            LocalDirValueLabel.Text = dir   'set label showing directory
            My.Settings.LocalDir = dir      'set path in app settings to persist after this session

            '   ideally uses async for live updates like other settings toggles:
            '   Await Viewer.InitLocalDir(dir)
            '   Viewer.Refresh()
            Viewer.InitLocalDir(dir)

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

    Private Sub VersionLabel_Click(sender As Object, e As EventArgs) Handles VersionLabel.Click

    End Sub
End Class