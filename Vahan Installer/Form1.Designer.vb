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
        Me.BtnHSRP = New System.Windows.Forms.Button()
        Me.BtnRVS = New System.Windows.Forms.Button()
        Me.BtnTempReg = New System.Windows.Forms.Button()
        Me.BtnVahan = New System.Windows.Forms.Button()
        Me.LblUpdate = New System.Windows.Forms.Label()
        Me.LblVahan = New System.Windows.Forms.Label()
        Me.LblTempReg = New System.Windows.Forms.Label()
        Me.LblRVS = New System.Windows.Forms.Label()
        Me.LblSPVS = New System.Windows.Forms.Label()
        Me.LblSarathi = New System.Windows.Forms.Label()
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
        'BtnHSRP
        '
        Me.BtnHSRP.Image = Global.Vahan.My.Resources.Resources.SPVS
        Me.BtnHSRP.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHSRP.Location = New System.Drawing.Point(246, 12)
        Me.BtnHSRP.Name = "BtnHSRP"
        Me.BtnHSRP.Size = New System.Drawing.Size(72, 58)
        Me.BtnHSRP.TabIndex = 3
        Me.BtnHSRP.Text = "HSRP"
        Me.BtnHSRP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHSRP.UseVisualStyleBackColor = True
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
        'LblUpdate
        '
        Me.LblUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUpdate.Location = New System.Drawing.Point(9, 96)
        Me.LblUpdate.Name = "LblUpdate"
        Me.LblUpdate.Size = New System.Drawing.Size(387, 26)
        Me.LblUpdate.TabIndex = 5
        Me.LblUpdate.Text = "Update:"
        Me.LblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblVahan
        '
        Me.LblVahan.Location = New System.Drawing.Point(12, 73)
        Me.LblVahan.Name = "LblVahan"
        Me.LblVahan.Size = New System.Drawing.Size(72, 23)
        Me.LblVahan.TabIndex = 6
        Me.LblVahan.Text = "Version"
        Me.LblVahan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTempReg
        '
        Me.LblTempReg.Location = New System.Drawing.Point(90, 73)
        Me.LblTempReg.Name = "LblTempReg"
        Me.LblTempReg.Size = New System.Drawing.Size(72, 23)
        Me.LblTempReg.TabIndex = 7
        Me.LblTempReg.Text = "Version"
        Me.LblTempReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRVS
        '
        Me.LblRVS.Location = New System.Drawing.Point(168, 73)
        Me.LblRVS.Name = "LblRVS"
        Me.LblRVS.Size = New System.Drawing.Size(72, 23)
        Me.LblRVS.TabIndex = 8
        Me.LblRVS.Text = "Version"
        Me.LblRVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSPVS
        '
        Me.LblSPVS.Location = New System.Drawing.Point(246, 73)
        Me.LblSPVS.Name = "LblSPVS"
        Me.LblSPVS.Size = New System.Drawing.Size(72, 23)
        Me.LblSPVS.TabIndex = 9
        Me.LblSPVS.Text = "Version"
        Me.LblSPVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSarathi
        '
        Me.LblSarathi.Location = New System.Drawing.Point(324, 73)
        Me.LblSarathi.Name = "LblSarathi"
        Me.LblSarathi.Size = New System.Drawing.Size(72, 23)
        Me.LblSarathi.TabIndex = 10
        Me.LblSarathi.Text = "Version"
        Me.LblSarathi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartVahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblSarathi)
        Me.Controls.Add(Me.LblSPVS)
        Me.Controls.Add(Me.LblRVS)
        Me.Controls.Add(Me.LblTempReg)
        Me.Controls.Add(Me.LblVahan)
        Me.Controls.Add(Me.LblUpdate)
        Me.Controls.Add(Me.BtnDLO)
        Me.Controls.Add(Me.BtnHSRP)
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
    Friend WithEvents BtnHSRP As System.Windows.Forms.Button
    Friend WithEvents BtnDLO As System.Windows.Forms.Button
    Friend WithEvents LblUpdate As System.Windows.Forms.Label
    Friend WithEvents LblVahan As System.Windows.Forms.Label
    Friend WithEvents LblTempReg As System.Windows.Forms.Label
    Friend WithEvents LblRVS As System.Windows.Forms.Label
    Friend WithEvents LblSPVS As System.Windows.Forms.Label
    Friend WithEvents LblSarathi As System.Windows.Forms.Label

End Class
