Public Class StartVahan

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnVahan_Click(sender As System.Object, e As System.EventArgs) Handles BtnVahan.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("TptClient.exe")
        Else
            Dim pi = New ProcessStartInfo("TptClient.exe")
            pi.UseShellExecute = True
            pi.Verb = "runas"
            Process.Start(pi)
        End If
        Me.Close()
    End Sub

    Private Sub BtnTempReg_Click(sender As System.Object, e As System.EventArgs) Handles BtnTempReg.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("TempReg.exe")
        Else
            Dim pi = New ProcessStartInfo("TempReg.exe")
            pi.UseShellExecute = True
            pi.Verb = "runas"
            Process.Start(pi)
        End If
        Me.Close()
    End Sub

    Private Sub BtnRVS_Click(sender As System.Object, e As System.EventArgs) Handles BtnRVS.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("RVS.exe")
        Else
            Dim pi = New ProcessStartInfo("RVS.exe")
            pi.UseShellExecute = True
            pi.Verb = "runas"
            Process.Start(pi)
        End If
        Me.Close()
    End Sub
End Class
