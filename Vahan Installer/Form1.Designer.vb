<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartVahan
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
        Me.BtnDLO = New System.Windows.Forms.Button()
        Me.BtnSPVS = New System.Windows.Forms.Button()
        Me.BtnRVS = New System.Windows.Forms.Button()
        Me.BtnTempReg = New System.Windows.Forms.Button()
        Me.BtnVahan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnDLO
        '
        Me.BtnDLO.Image = Global.Vahan.My.Resources.Resources.Sarathi
        Me.BtnDLO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDLO.Location = New System.Drawing.Point(324, 12)
        Me.BtnDLO.Name = "BtnDLO"
        Me.BtnDLO.Size = New System.Drawing.Size(72, 58)
        Me.BtnDLO.TabIndex = 4
        Me.BtnDLO.Text = "Sarathi"
        Me.BtnDLO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDLO.UseVisualStyleBackColor = True
        '
        'BtnSPVS
        '
        Me.BtnSPVS.Image = Global.Vahan.My.Resources.Resources.SPVS
        Me.BtnSPVS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSPVS.Location = New System.Drawing.Point(246, 12)
        Me.BtnSPVS.Name = "BtnSPVS"
        Me.BtnSPVS.Size = New System.Drawing.Size(72, 58)
        Me.BtnSPVS.TabIndex = 3
        Me.BtnSPVS.Text = "SPVS"
        Me.BtnSPVS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSPVS.UseVisualStyleBackColor = True
        '
        'BtnRVS
        '
        Me.BtnRVS.Image = Global.Vahan.My.Resources.Resources.RVS
        Me.BtnRVS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRVS.Location = New System.Drawing.Point(168, 12)
        Me.BtnRVS.Name = "BtnRVS"
        Me.BtnRVS.Size = New System.Drawing.Size(72, 58)
        Me.BtnRVS.TabIndex = 2
        Me.BtnRVS.Text = "RVS"
        Me.BtnRVS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRVS.UseVisualStyleBackColor = True
        '
        'BtnTempReg
        '
        Me.BtnTempReg.Image = Global.Vahan.My.Resources.Resources.TempReg
        Me.BtnTempReg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTempReg.Location = New System.Drawing.Point(90, 12)
        Me.BtnTempReg.Name = "BtnTempReg"
        Me.BtnTempReg.Size = New System.Drawing.Size(72, 58)
        Me.BtnTempReg.TabIndex = 1
        Me.BtnTempReg.Text = "TempReg"
        Me.BtnTempReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTempReg.UseVisualStyleBackColor = True
        '
        'BtnVahan
        '
        Me.BtnVahan.Image = Global.Vahan.My.Resources.Resources.VAHAN
        Me.BtnVahan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnVahan.Location = New System.Drawing.Point(12, 12)
        Me.BtnVahan.Name = "BtnVahan"
        Me.BtnVahan.Size = New System.Drawing.Size(72, 58)
        Me.BtnVahan.TabIndex = 0
        Me.BtnVahan.Text = "VAHAN"
        Me.BtnVahan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVahan.UseVisualStyleBackColor = True
        '
        'StartVahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 83)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnDLO)
        Me.Controls.Add(Me.BtnSPVS)
        Me.Controls.Add(Me.BtnRVS)
        Me.Controls.Add(Me.BtnTempReg)
        Me.Controls.Add(Me.BtnVahan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartVahan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnVahan As System.Windows.Forms.Button
    Friend WithEvents BtnTempReg As System.Windows.Forms.Button
    Friend WithEvents BtnRVS As System.Windows.Forms.Button
    Friend WithEvents BtnSPVS As System.Windows.Forms.Button
    Friend WithEvents BtnDLO As System.Windows.Forms.Button

End Class
