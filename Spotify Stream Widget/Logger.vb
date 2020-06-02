Imports System.IO

Module Logger
    Public Sub Log(logType As Integer, logMsg As String)
        Dim outputFolder = Application.StartupPath & "\Logs\"
        Dim lvlText = " [INFO] "
        Select Case logType
            Case 1
                'default debug
                lvlText = " [DEBUG] "
            Case 2
                'error
                lvlText = " [ERROR] "
            Case 3
                'exception
                lvlText = " [EXCEPTION] "
        End Select
        If Debugger.IsAttached Then
            Debug.WriteLine(Date.Now.ToString("yyyy/MM/dd HH:mm:ss") & " Call " & My.Settings.ApiCalls & lvlText & logMsg)
        End If
        Try
            If Directory.Exists(outputFolder) = False Then
                Directory.CreateDirectory(outputFolder)
            End If
            Using sw As StreamWriter = File.AppendText(outputFolder & Date.Now.ToString("yyyy-MM-dd") & ".log")
                sw.WriteLine(Date.Now.ToString("yyyy/MM/dd HH:mm:ss") & lvlText & logMsg)
            End Using
        Catch ex As Exception
                Debug.WriteLine(Date.Now.ToString("yyyy/MM/dd HH:mm:ss") & " [EXCEPTION] Can't create log file. " & ex.ToString())
            End Try
    End Sub
    Public Sub Log(logMsg As String)
        Log(1, logMsg)
    End Sub
End Module