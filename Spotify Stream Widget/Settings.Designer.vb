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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DarkWindow = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Open Viewer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DarkWindow
        '
        Me.DarkWindow.AutoSize = True
        Me.DarkWindow.Checked = True
        Me.DarkWindow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DarkWindow.Location = New System.Drawing.Point(171, 63)
        Me.DarkWindow.Name = "DarkWindow"
        Me.DarkWindow.Size = New System.Drawing.Size(80, 17)
        Me.DarkWindow.TabIndex = 1
        Me.DarkWindow.Text = "An"
        Me.DarkWindow.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.DarkWindow.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(40, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Dark Viewer"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 441)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.DarkWindow)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Settings"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Stream Widget"
        Me.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DarkWindow As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
