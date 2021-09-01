Public NotInheritable Class Splash

    Private Async Sub init(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingBar.UseCustomBackColor = True
        LoadingBar.BackColor = Color.FromArgb(0, 255, 104)
        LoadingBar.Value = 0
    End Sub
End Class
