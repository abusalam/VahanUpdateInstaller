Public Class StartVahan

    Private Sub StartVahan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnVahan.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblVahan.Text = "1.1.0.27/45"
        LblTempReg.Text = "1.0.0.66"
        LblRVS.Text = "2.1.0.12"
        LblSPVS.Text = "1.2.0.31"
        LblSarathi.Text = "1.0.0.25"
        LblUpdate.Text = "Last Update: Updated to Vahan-27 TempReg-66 RVS_VerControl-12 HSRP-31"
    End Sub

    Private Sub BtnVahan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVahan.Click
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

    Private Sub BtnTempReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTempReg.Click
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

    Private Sub BtnRVS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRVS.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("RVS_VerControll.exe")
        Else
            Dim pi = New ProcessStartInfo("RVS_VerControll.exe")
            pi.UseShellExecute = True
            pi.Verb = "runas"
            Process.Start(pi)
        End If
        Me.Close()
    End Sub
    Private Sub BtnHSRP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHSRP.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If osVer.Major = 5 Then
            Process.Start("VahanScmHsrp.exe")
        Else
            Dim pi = New ProcessStartInfo("VahanScmHsrp.exe")
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
