<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.SpotifyConnectBtn = New System.Windows.Forms.Button()
        Me.ColorSettingToggle = New MetroFramework.Controls.MetroToggle()
        Me.ColorSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.CreditLink = New MetroFramework.Controls.MetroLink()
        Me.SizeSettingBox = New MetroFramework.Controls.MetroComboBox()
        Me.SizeSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressStyleLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressStyleBox = New MetroFramework.Controls.MetroComboBox()
        Me.ReportLink = New MetroFramework.Controls.MetroLink()
        Me.ColorStyleLabel = New MetroFramework.Controls.MetroLabel()
        Me.ColorStyleBox = New MetroFramework.Controls.MetroComboBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.VersionCheck = New System.ComponentModel.BackgroundWorker()
        Me.ExportSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.ExportSettingToggle = New MetroFramework.Controls.MetroToggle()
        Me.StatusLabel = New MetroFramework.Controls.MetroLabel()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.LocalDirLabel = New MetroFramework.Controls.MetroLabel()
        Me.LocalDirValueLabel = New MetroFramework.Controls.MetroLabel()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ExportFolderBtn = New System.Windows.Forms.PictureBox()
        Me.LocalDirBtn = New System.Windows.Forms.PictureBox()
        CType(Me.ExportFolderBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalDirBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpotifyConnectBtn
        '
        Me.SpotifyConnectBtn.Location = New System.Drawing.Point(23, 373)
        Me.SpotifyConnectBtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SpotifyConnectBtn.Name = "SpotifyConnectBtn"
        Me.SpotifyConnectBtn.Size = New System.Drawing.Size(251, 23)
        Me.SpotifyConnectBtn.TabIndex = 0
        Me.SpotifyConnectBtn.Text = "Connect to Spotify"
        Me.SpotifyConnectBtn.UseVisualStyleBackColor = True
        '
        'ColorSettingToggle
        '
        Me.ColorSettingToggle.AutoSize = True
        Me.ColorSettingToggle.Checked = True
        Me.ColorSettingToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ColorSettingToggle.Location = New System.Drawing.Point(182, 75)
        Me.ColorSettingToggle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ColorSettingToggle.Name = "ColorSettingToggle"
        Me.ColorSettingToggle.Size = New System.Drawing.Size(80, 17)
        Me.ColorSettingToggle.TabIndex = 1
        Me.ColorSettingToggle.Text = "On"
        Me.ColorSettingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorSettingToggle.UseCustomBackColor = True
        Me.ColorSettingToggle.UseSelectable = True
        '
        'ColorSettingLabel
        '
        Me.ColorSettingLabel.AutoSize = True
        Me.ColorSettingLabel.BackColor = System.Drawing.Color.Transparent
        Me.ColorSettingLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ColorSettingLabel.Location = New System.Drawing.Point(13, 70)
        Me.ColorSettingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ColorSettingLabel.Name = "ColorSettingLabel"
        Me.ColorSettingLabel.Size = New System.Drawing.Size(75, 19)
        Me.ColorSettingLabel.TabIndex = 2
        Me.ColorSettingLabel.Text = "Dark Mode"
        Me.ColorSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorSettingLabel.UseCustomBackColor = True
        '
        'CreditLink
        '
        Me.CreditLink.Location = New System.Drawing.Point(23, 400)
        Me.CreditLink.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CreditLink.Name = "CreditLink"
        Me.CreditLink.Size = New System.Drawing.Size(251, 18)
        Me.CreditLink.TabIndex = 3
        Me.CreditLink.Text = "Made by Marco Sadowski"
        Me.CreditLink.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CreditLink.UseCustomBackColor = True
        Me.CreditLink.UseSelectable = True
        Me.CreditLink.UseStyleColors = True
        '
        'SizeSettingBox
        '
        Me.SizeSettingBox.FormattingEnabled = True
        Me.SizeSettingBox.ItemHeight = 23
        Me.SizeSettingBox.Items.AddRange(New Object() {"Small", "Normal", "Big"})
        Me.SizeSettingBox.Location = New System.Drawing.Point(161, 105)
        Me.SizeSettingBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SizeSettingBox.Name = "SizeSettingBox"
        Me.SizeSettingBox.Size = New System.Drawing.Size(102, 29)
        Me.SizeSettingBox.Style = MetroFramework.MetroColorStyle.Green
        Me.SizeSettingBox.TabIndex = 4
        Me.SizeSettingBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SizeSettingBox.UseSelectable = True
        '
        'SizeSettingLabel
        '
        Me.SizeSettingLabel.AutoSize = True
        Me.SizeSettingLabel.BackColor = System.Drawing.Color.Transparent
        Me.SizeSettingLabel.Location = New System.Drawing.Point(13, 105)
        Me.SizeSettingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SizeSettingLabel.Name = "SizeSettingLabel"
        Me.SizeSettingLabel.Size = New System.Drawing.Size(75, 19)
        Me.SizeSettingLabel.TabIndex = 5
        Me.SizeSettingLabel.Text = "Viewer Size"
        Me.SizeSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SizeSettingLabel.UseCustomBackColor = True
        '
        'ProgressStyleLabel
        '
        Me.ProgressStyleLabel.AutoSize = True
        Me.ProgressStyleLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProgressStyleLabel.Location = New System.Drawing.Point(13, 140)
        Me.ProgressStyleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProgressStyleLabel.Name = "ProgressStyleLabel"
        Me.ProgressStyleLabel.Size = New System.Drawing.Size(111, 19)
        Me.ProgressStyleLabel.TabIndex = 7
        Me.ProgressStyleLabel.Text = "ProgressBar Style"
        Me.ProgressStyleLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ProgressStyleLabel.UseCustomBackColor = True
        '
        'ProgressStyleBox
        '
        Me.ProgressStyleBox.FormattingEnabled = True
        Me.ProgressStyleBox.ItemHeight = 23
        Me.ProgressStyleBox.Items.AddRange(New Object() {"Blocks", "Continuous", "Marquee", "Off"})
        Me.ProgressStyleBox.Location = New System.Drawing.Point(161, 140)
        Me.ProgressStyleBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ProgressStyleBox.Name = "ProgressStyleBox"
        Me.ProgressStyleBox.Size = New System.Drawing.Size(102, 29)
        Me.ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Green
        Me.ProgressStyleBox.TabIndex = 6
        Me.ProgressStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTips.SetToolTip(Me.ProgressStyleBox, "Change the Style of the ProgressBar - Use Marquee to save CPU%")
        Me.ProgressStyleBox.UseSelectable = True
        '
        'ReportLink
        '
        Me.ReportLink.Location = New System.Drawing.Point(0, 424)
        Me.ReportLink.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ReportLink.Name = "ReportLink"
        Me.ReportLink.Size = New System.Drawing.Size(88, 18)
        Me.ReportLink.TabIndex = 10
        Me.ReportLink.Text = "Report a bug"
        Me.ReportLink.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ReportLink.UseCustomBackColor = True
        Me.ReportLink.UseSelectable = True
        Me.ReportLink.UseStyleColors = True
        '
        'ColorStyleLabel
        '
        Me.ColorStyleLabel.AutoSize = True
        Me.ColorStyleLabel.BackColor = System.Drawing.Color.Transparent
        Me.ColorStyleLabel.Location = New System.Drawing.Point(13, 175)
        Me.ColorStyleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ColorStyleLabel.Name = "ColorStyleLabel"
        Me.ColorStyleLabel.Size = New System.Drawing.Size(116, 19)
        Me.ColorStyleLabel.TabIndex = 12
        Me.ColorStyleLabel.Text = "Viewer Style Color"
        Me.ColorStyleLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorStyleLabel.UseCustomBackColor = True
        '
        'ColorStyleBox
        '
        Me.ColorStyleBox.FormattingEnabled = True
        Me.ColorStyleBox.ItemHeight = 23
        Me.ColorStyleBox.Items.AddRange(New Object() {"Green", "Black", "White", "Silver", "Blue", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"})
        Me.ColorStyleBox.Location = New System.Drawing.Point(161, 175)
        Me.ColorStyleBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ColorStyleBox.Name = "ColorStyleBox"
        Me.ColorStyleBox.Size = New System.Drawing.Size(102, 29)
        Me.ColorStyleBox.Style = MetroFramework.MetroColorStyle.Green
        Me.ColorStyleBox.TabIndex = 11
        Me.ColorStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorStyleBox.UseSelectable = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.VersionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VersionLabel.Location = New System.Drawing.Point(254, 49)
        Me.VersionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(30, 9)
        Me.VersionLabel.TabIndex = 13
        Me.VersionLabel.Text = "version"
        '
        'VersionCheck
        '
        '
        'ExportSettingLabel
        '
        Me.ExportSettingLabel.AutoSize = True
        Me.ExportSettingLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExportSettingLabel.Location = New System.Drawing.Point(13, 210)
        Me.ExportSettingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ExportSettingLabel.Name = "ExportSettingLabel"
        Me.ExportSettingLabel.Size = New System.Drawing.Size(90, 19)
        Me.ExportSettingLabel.TabIndex = 15
        Me.ExportSettingLabel.Text = "Export Details"
        Me.ExportSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTips.SetToolTip(Me.ExportSettingLabel, "This mode exports all song details as file. You can embed the files inside your s" &
        "treaming software.")
        Me.ExportSettingLabel.UseCustomBackColor = True
        '
        'ExportSettingToggle
        '
        Me.ExportSettingToggle.AutoSize = True
        Me.ExportSettingToggle.Checked = True
        Me.ExportSettingToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExportSettingToggle.Location = New System.Drawing.Point(182, 215)
        Me.ExportSettingToggle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ExportSettingToggle.Name = "ExportSettingToggle"
        Me.ExportSettingToggle.Size = New System.Drawing.Size(80, 17)
        Me.ExportSettingToggle.Style = MetroFramework.MetroColorStyle.Green
        Me.ExportSettingToggle.TabIndex = 14
        Me.ExportSettingToggle.Text = "On"
        Me.ExportSettingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ExportSettingToggle.UseCustomBackColor = True
        Me.ExportSettingToggle.UseSelectable = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.FontSize = MetroFramework.MetroLabelSize.Small
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(22, 357)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(119, 15)
        Me.StatusLabel.TabIndex = 17
        Me.StatusLabel.Text = "Status: Not connected"
        Me.StatusLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.StatusLabel.UseCustomBackColor = True
        Me.StatusLabel.UseCustomForeColor = True
        '
        'ToolTips
        '
        Me.ToolTips.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ToolTips.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ToolTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTips.ToolTipTitle = "Info"
        '
        'LocalDirLabel
        '
        Me.LocalDirLabel.AutoSize = True
        Me.LocalDirLabel.BackColor = System.Drawing.Color.Transparent
        Me.LocalDirLabel.Location = New System.Drawing.Point(13, 245)
        Me.LocalDirLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocalDirLabel.Name = "LocalDirLabel"
        Me.LocalDirLabel.Size = New System.Drawing.Size(120, 19)
        Me.LocalDirLabel.TabIndex = 18
        Me.LocalDirLabel.Text = "Local Songs Folder"
        Me.LocalDirLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ToolTips.SetToolTip(Me.LocalDirLabel, "Choose the folder containing local Spotify song files.")
        Me.LocalDirLabel.UseCustomBackColor = True
        '
        'LocalDirValueLabel
        '
        Me.LocalDirValueLabel.Location = New System.Drawing.Point(182, 245)
        Me.LocalDirValueLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocalDirValueLabel.Name = "LocalDirValueLabel"
        Me.LocalDirValueLabel.Size = New System.Drawing.Size(102, 19)
        Me.LocalDirValueLabel.TabIndex = 19
        Me.LocalDirValueLabel.Text = "None"
        Me.LocalDirValueLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LocalDirValueLabel.UseCustomBackColor = True
        Me.LocalDirValueLabel.UseSelectable = True
        '
        'ExportFolderBtn
        '
        Me.ExportFolderBtn.Image = CType(resources.GetObject("ExportFolderBtn.Image"), System.Drawing.Image)
        Me.ExportFolderBtn.Location = New System.Drawing.Point(162, 215)
        Me.ExportFolderBtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ExportFolderBtn.Name = "ExportFolderBtn"
        Me.ExportFolderBtn.Size = New System.Drawing.Size(14, 16)
        Me.ExportFolderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ExportFolderBtn.TabIndex = 16
        Me.ExportFolderBtn.TabStop = False
        Me.ToolTips.SetToolTip(Me.ExportFolderBtn, "Open the Export Destination")
        '
        'LocalDirBtn
        '
        Me.LocalDirBtn.Image = CType(resources.GetObject("LocalDirBtn.Image"), System.Drawing.Image)
        Me.LocalDirBtn.Location = New System.Drawing.Point(162, 245)
        Me.LocalDirBtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LocalDirBtn.Name = "LocalDirBtn"
        Me.LocalDirBtn.Size = New System.Drawing.Size(14, 16)
        Me.LocalDirBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LocalDirBtn.TabIndex = 16
        Me.LocalDirBtn.TabStop = False
        Me.ToolTips.SetToolTip(Me.LocalDirBtn, "Choose the folder containing local Spotify song files.")
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 441)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.ExportFolderBtn)
        Me.Controls.Add(Me.ExportSettingLabel)
        Me.Controls.Add(Me.ExportSettingToggle)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.ColorStyleLabel)
        Me.Controls.Add(Me.ColorStyleBox)
        Me.Controls.Add(Me.ReportLink)
        Me.Controls.Add(Me.ProgressStyleLabel)
        Me.Controls.Add(Me.ProgressStyleBox)
        Me.Controls.Add(Me.SizeSettingLabel)
        Me.Controls.Add(Me.SizeSettingBox)
        Me.Controls.Add(Me.CreditLink)
        Me.Controls.Add(Me.ColorSettingLabel)
        Me.Controls.Add(Me.ColorSettingToggle)
        Me.Controls.Add(Me.SpotifyConnectBtn)
        Me.Controls.Add(Me.LocalDirLabel)
        Me.Controls.Add(Me.LocalDirBtn)
        Me.Controls.Add(Me.LocalDirValueLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Stream Widget"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ExportFolderBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalDirBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorSettingToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents ColorSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents CreditLink As MetroFramework.Controls.MetroLink
    Friend WithEvents SizeSettingBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents SizeSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressStyleLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressStyleBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ReportLink As MetroFramework.Controls.MetroLink
    Friend WithEvents ColorStyleLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColorStyleBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents VersionCheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents ExportSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ExportSettingToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents SpotifyConnectBtn As Button
    Friend WithEvents ExportFolderBtn As PictureBox
    Friend WithEvents StatusLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents LocalDirLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents LocalDirBtn As PictureBox
    Friend WithEvents LocalDirValueLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents FolderDialog As FolderBrowserDialog
End Class
