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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.ViewerControl = New System.Windows.Forms.Button()
        Me.ColorSettingToggle = New MetroFramework.Controls.MetroToggle()
        Me.ColorSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.CreditLink = New MetroFramework.Controls.MetroLink()
        Me.SizeSettingBox = New MetroFramework.Controls.MetroComboBox()
        Me.SizeSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressStyleLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressStyleBox = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.CreditPanel = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.CreditPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewerControl
        '
        Me.ViewerControl.Location = New System.Drawing.Point(23, 373)
        Me.ViewerControl.Name = "ViewerControl"
        Me.ViewerControl.Size = New System.Drawing.Size(251, 23)
        Me.ViewerControl.TabIndex = 0
        Me.ViewerControl.Text = "Open Viewer"
        Me.ViewerControl.UseVisualStyleBackColor = True
        '
        'ColorSettingToggle
        '
        Me.ColorSettingToggle.AutoSize = True
        Me.ColorSettingToggle.Checked = True
        Me.ColorSettingToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ColorSettingToggle.Location = New System.Drawing.Point(183, 63)
        Me.ColorSettingToggle.Name = "ColorSettingToggle"
        Me.ColorSettingToggle.Size = New System.Drawing.Size(80, 17)
        Me.ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Green
        Me.ColorSettingToggle.TabIndex = 1
        Me.ColorSettingToggle.Text = "An"
        Me.ColorSettingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorSettingToggle.UseSelectable = True
        '
        'ColorSettingLabel
        '
        Me.ColorSettingLabel.AutoSize = True
        Me.ColorSettingLabel.Location = New System.Drawing.Point(23, 63)
        Me.ColorSettingLabel.Name = "ColorSettingLabel"
        Me.ColorSettingLabel.Size = New System.Drawing.Size(75, 19)
        Me.ColorSettingLabel.TabIndex = 2
        Me.ColorSettingLabel.Text = "Dark Mode"
        Me.ColorSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CreditLink
        '
        Me.CreditLink.Location = New System.Drawing.Point(23, 400)
        Me.CreditLink.Name = "CreditLink"
        Me.CreditLink.Size = New System.Drawing.Size(251, 18)
        Me.CreditLink.TabIndex = 3
        Me.CreditLink.Text = "Made by Marco Sadowski"
        Me.CreditLink.UseCustomBackColor = True
        Me.CreditLink.UseSelectable = True
        Me.CreditLink.UseStyleColors = True
        '
        'SizeSettingBox
        '
        Me.SizeSettingBox.FormattingEnabled = True
        Me.SizeSettingBox.ItemHeight = 23
        Me.SizeSettingBox.Items.AddRange(New Object() {"Small", "Normal", "Big"})
        Me.SizeSettingBox.Location = New System.Drawing.Point(161, 86)
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
        Me.SizeSettingLabel.Location = New System.Drawing.Point(23, 96)
        Me.SizeSettingLabel.Name = "SizeSettingLabel"
        Me.SizeSettingLabel.Size = New System.Drawing.Size(75, 19)
        Me.SizeSettingLabel.TabIndex = 5
        Me.SizeSettingLabel.Text = "Viewer Size"
        Me.SizeSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ProgressStyleLabel
        '
        Me.ProgressStyleLabel.AutoSize = True
        Me.ProgressStyleLabel.Location = New System.Drawing.Point(23, 127)
        Me.ProgressStyleLabel.Name = "ProgressStyleLabel"
        Me.ProgressStyleLabel.Size = New System.Drawing.Size(111, 19)
        Me.ProgressStyleLabel.TabIndex = 7
        Me.ProgressStyleLabel.Text = "ProgressBar Style"
        Me.ProgressStyleLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ProgressStyleBox
        '
        Me.ProgressStyleBox.FormattingEnabled = True
        Me.ProgressStyleBox.ItemHeight = 23
        Me.ProgressStyleBox.Items.AddRange(New Object() {"Blocks", "Continuous", "Marquee"})
        Me.ProgressStyleBox.Location = New System.Drawing.Point(161, 121)
        Me.ProgressStyleBox.Name = "ProgressStyleBox"
        Me.ProgressStyleBox.Size = New System.Drawing.Size(102, 29)
        Me.ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Green
        Me.ProgressStyleBox.TabIndex = 6
        Me.ProgressStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ProgressStyleBox.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(183, 424)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(115, 18)
        Me.MetroLink1.TabIndex = 8
        Me.MetroLink1.Text = "Credits and License"
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'CreditPanel
        '
        Me.CreditPanel.Controls.Add(Me.Button1)
        Me.CreditPanel.Controls.Add(Me.TextBox1)
        Me.CreditPanel.Location = New System.Drawing.Point(251, 424)
        Me.CreditPanel.Name = "CreditPanel"
        Me.CreditPanel.Size = New System.Drawing.Size(251, 304)
        Me.CreditPanel.TabIndex = 9
        Me.CreditPanel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(251, 304)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Location = New System.Drawing.Point(0, 424)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(88, 18)
        Me.MetroLink2.TabIndex = 10
        Me.MetroLink2.Text = "Report a bug"
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 441)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.CreditPanel)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.ProgressStyleLabel)
        Me.Controls.Add(Me.ProgressStyleBox)
        Me.Controls.Add(Me.SizeSettingLabel)
        Me.Controls.Add(Me.SizeSettingBox)
        Me.Controls.Add(Me.CreditLink)
        Me.Controls.Add(Me.ColorSettingLabel)
        Me.Controls.Add(Me.ColorSettingToggle)
        Me.Controls.Add(Me.ViewerControl)
        Me.Name = "Settings"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Stream Widget Settings"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CreditPanel.ResumeLayout(False)
        Me.CreditPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ViewerControl As Button
    Friend WithEvents ColorSettingToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents ColorSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents CreditLink As MetroFramework.Controls.MetroLink
    Friend WithEvents SizeSettingBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents SizeSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressStyleLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressStyleBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents CreditPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
End Class
