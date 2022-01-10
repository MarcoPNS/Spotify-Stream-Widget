<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.NameLabel = New MetroFramework.Controls.MetroLabel()
        Me.Credits = New MetroFramework.Controls.MetroLabel()
        Me.Copyright = New MetroFramework.Controls.MetroLabel()
        Me.LoadingBar = New MetroFramework.Controls.MetroProgressBar()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Image = Global.Spotify_Stream_Widget.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(12, 68)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(374, 179)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.NameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.NameLabel.ForeColor = System.Drawing.Color.Snow
        Me.NameLabel.Location = New System.Drawing.Point(12, 260)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(374, 29)
        Me.NameLabel.Style = MetroFramework.MetroColorStyle.White
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Stream Widget"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NameLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.NameLabel.UseCustomBackColor = True
        Me.NameLabel.UseCustomForeColor = True
        '
        'Credits
        '
        Me.Credits.BackColor = System.Drawing.Color.Transparent
        Me.Credits.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Credits.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Credits.ForeColor = System.Drawing.Color.Snow
        Me.Credits.Location = New System.Drawing.Point(12, 357)
        Me.Credits.Name = "Credits"
        Me.Credits.Size = New System.Drawing.Size(374, 29)
        Me.Credits.Style = MetroFramework.MetroColorStyle.White
        Me.Credits.TabIndex = 2
        Me.Credits.Text = "Made by Marco Sadowski"
        Me.Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Credits.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Credits.UseCustomBackColor = True
        Me.Credits.UseCustomForeColor = True
        '
        'Copyright
        '
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Copyright.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Copyright.ForeColor = System.Drawing.Color.Snow
        Me.Copyright.Location = New System.Drawing.Point(12, 386)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(374, 29)
        Me.Copyright.Style = MetroFramework.MetroColorStyle.White
        Me.Copyright.TabIndex = 3
        Me.Copyright.Text = "© Marco Sadowski 2021"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Copyright.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Copyright.UseCustomBackColor = True
        Me.Copyright.UseCustomForeColor = True
        '
        'LoadingBar
        '
        Me.LoadingBar.Location = New System.Drawing.Point(12, 309)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(374, 23)
        Me.LoadingBar.TabIndex = 4
        Me.LoadingBar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LoadingBar.UseCustomBackColor = True
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Credits)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents NameLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents Credits As MetroFramework.Controls.MetroLabel
    Friend WithEvents Copyright As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingBar As MetroFramework.Controls.MetroProgressBar
End Class
