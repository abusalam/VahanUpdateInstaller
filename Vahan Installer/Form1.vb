Public Class StartVahan

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblVahan.Text = "1.1.0.24/42"
        LblTempReg.Text = "1.0.0.28"
        LblRVS.Text = "1.0.0.496"
        LblSPVS.Text = "2.0.0.52"
        LblSarathi.Text = "1.0.0.25"
        LblUpdate.Text = "Last Update: Updated RVS-496."
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
    Private Sub BtnSPVS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSPVS.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("SPVS.exe")
        Else
            Dim pi = New ProcessStartInfo("SPVS.exe")
            pi.UseShellExecute = True
            pi.Verb = "runas"
            Process.Start(pi)
        End If
        Me.Close()
    End Sub

    Private Sub BtnDLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDLO.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("Sarathi.exe")
        Else
            Dim pi = New ProcessStartInfo("Sarathi.exe")
            pi.UseShellExecute = True
            pi.Verb = "runas"
            Process.Start(pi)
        End If
        Me.Close()
    End Sub
End Class
