Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class EventLogger
    Public Sub New()

        'default constructor

    End Sub



    '*************************************************************
    'NAME:          WriteToErrorLog
    'PURPOSE:       Open or create an error log and submit error message
    'PARAMETERS:    msg - message to be written to error file
    '               stkTrace - stack trace from error message
    '               title - title of the error file entry
    'RETURNS:       Nothing
    '*************************************************************
    Public Sub WriteToErrorLog(ByVal msg As String, stktrace As String, ByVal title As String)

        'check and make the directory if necessary; this is set to look in the application
        'folder, you may wish to place the error log in another location depending upon the
        'the user's role and write access to different areas of the file system
        If Not System.IO.Directory.Exists(Application.StartupPath & "\Events\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Events\")
        End If

        'check the file
        Dim fs As FileStream = New FileStream(Application.StartupPath & "\Events\evlogs.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Events\evlogs.txt", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write("Titulo: " & title & vbCrLf)
        s1.Write("Mensaje: " & msg & vbCrLf)
        s1.Write("StackTrace: " & stktrace & vbCrLf)
        s1.Write("Fecha/Hora: " & DateTime.Now.ToString() & vbCrLf)
        s1.Write("===========================================================================================" & vbCrLf)
        s1.Close()
        fs1.Close()

    End Sub
End Class
