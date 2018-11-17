<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnTrackIP = New System.Windows.Forms.Button()
        Me.lblKillerIP = New System.Windows.Forms.Label()
        Me.txtKillersIP = New System.Windows.Forms.TextBox()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.BackgroundImage = Global.VB_GUI_IPTracker.My.Resources.Resources.CSI
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.pbxLogo.Size = New System.Drawing.Size(1075, 284)
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'btnTrackIP
        '
        Me.btnTrackIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTrackIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackIP.Location = New System.Drawing.Point(248, 292)
        Me.btnTrackIP.Name = "btnTrackIP"
        Me.btnTrackIP.Size = New System.Drawing.Size(574, 69)
        Me.btnTrackIP.TabIndex = 1
        Me.btnTrackIP.Text = "Track the Killer's IP address"
        Me.btnTrackIP.UseVisualStyleBackColor = True
        '
        'lblKillerIP
        '
        Me.lblKillerIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblKillerIP.AutoSize = True
        Me.lblKillerIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKillerIP.Location = New System.Drawing.Point(244, 390)
        Me.lblKillerIP.Name = "lblKillerIP"
        Me.lblKillerIP.Size = New System.Drawing.Size(162, 24)
        Me.lblKillerIP.TabIndex = 2
        Me.lblKillerIP.Text = "Killer's IP address:"
        '
        'txtKillersIP
        '
        Me.txtKillersIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtKillersIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKillersIP.Location = New System.Drawing.Point(248, 417)
        Me.txtKillersIP.Name = "txtKillersIP"
        Me.txtKillersIP.Size = New System.Drawing.Size(574, 31)
        Me.txtKillersIP.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 532)
        Me.Controls.Add(Me.txtKillersIP)
        Me.Controls.Add(Me.lblKillerIP)
        Me.Controls.Add(Me.btnTrackIP)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "MainForm"
        Me.Text = "Visual Basic GUI Interface for tracking the killer"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnTrackIP As Button
    Friend WithEvents lblKillerIP As Label
    Friend WithEvents txtKillersIP As TextBox
End Class
