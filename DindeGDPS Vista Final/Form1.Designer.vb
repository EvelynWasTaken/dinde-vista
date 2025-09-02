<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.inGameLogo = New System.Windows.Forms.PictureBox()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.newsLabel = New System.Windows.Forms.Label()
        Me.gdLogo = New System.Windows.Forms.PictureBox()
        Me.discordLink = New System.Windows.Forms.LinkLabel()
        Me.dindeYTLink = New System.Windows.Forms.LinkLabel()
        Me.evyYTLink = New System.Windows.Forms.LinkLabel()
        CType(Me.inGameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inGameLogo
        '
        Me.inGameLogo.Image = Global.DindeGDPS_Vista_Final.My.Resources.Resources.logo
        Me.inGameLogo.Location = New System.Drawing.Point(226, 12)
        Me.inGameLogo.Name = "inGameLogo"
        Me.inGameLogo.Size = New System.Drawing.Size(417, 133)
        Me.inGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inGameLogo.TabIndex = 0
        Me.inGameLogo.TabStop = False
        '
        'btnInstall
        '
        Me.btnInstall.Location = New System.Drawing.Point(186, 239)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(113, 101)
        Me.btnInstall.TabIndex = 1
        Me.btnInstall.Text = "Install"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Location = New System.Drawing.Point(359, 239)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(113, 101)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'versionLabel
        '
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Location = New System.Drawing.Point(143, 421)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(385, 13)
        Me.versionLabel.TabIndex = 3
        Me.versionLabel.Text = "DindeGDPS Vista Launcher v1.0 - Launcher by Zhevelyn - DindeGDPS by Jean"
        '
        'newsLabel
        '
        Me.newsLabel.AutoSize = True
        Me.newsLabel.Location = New System.Drawing.Point(183, 176)
        Me.newsLabel.Name = "newsLabel"
        Me.newsLabel.Size = New System.Drawing.Size(129, 13)
        Me.newsLabel.TabIndex = 8
        Me.newsLabel.Text = "News: Failed to get news!"
        Me.newsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gdLogo
        '
        Me.gdLogo.Image = Global.DindeGDPS_Vista_Final.My.Resources.Resources.dindes
        Me.gdLogo.Location = New System.Drawing.Point(38, 12)
        Me.gdLogo.Name = "gdLogo"
        Me.gdLogo.Size = New System.Drawing.Size(142, 133)
        Me.gdLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gdLogo.TabIndex = 9
        Me.gdLogo.TabStop = False
        '
        'discordLink
        '
        Me.discordLink.AutoSize = True
        Me.discordLink.Location = New System.Drawing.Point(183, 378)
        Me.discordLink.Name = "discordLink"
        Me.discordLink.Size = New System.Drawing.Size(43, 13)
        Me.discordLink.TabIndex = 10
        Me.discordLink.TabStop = True
        Me.discordLink.Text = "Discord"
        '
        'dindeYTLink
        '
        Me.dindeYTLink.AutoSize = True
        Me.dindeYTLink.Location = New System.Drawing.Point(285, 378)
        Me.dindeYTLink.Name = "dindeYTLink"
        Me.dindeYTLink.Size = New System.Drawing.Size(108, 13)
        Me.dindeYTLink.TabIndex = 11
        Me.dindeYTLink.TabStop = True
        Me.dindeYTLink.Text = "DindeGDPS Youtube"
        '
        'evyYTLink
        '
        Me.evyYTLink.AutoSize = True
        Me.evyYTLink.Location = New System.Drawing.Point(422, 378)
        Me.evyYTLink.Name = "evyYTLink"
        Me.evyYTLink.Size = New System.Drawing.Size(101, 13)
        Me.evyYTLink.TabIndex = 12
        Me.evyYTLink.TabStop = True
        Me.evyYTLink.Text = "Zhevelyn's Youtube"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 443)
        Me.Controls.Add(Me.evyYTLink)
        Me.Controls.Add(Me.dindeYTLink)
        Me.Controls.Add(Me.discordLink)
        Me.Controls.Add(Me.gdLogo)
        Me.Controls.Add(Me.newsLabel)
        Me.Controls.Add(Me.versionLabel)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.inGameLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DindeGDPS Launcher"
        CType(Me.inGameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inGameLogo As PictureBox
    Friend WithEvents btnInstall As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents versionLabel As Label
    Friend WithEvents newsLabel As Label
    Friend WithEvents gdLogo As PictureBox
    Friend WithEvents discordLink As LinkLabel
    Friend WithEvents dindeYTLink As LinkLabel
    Friend WithEvents evyYTLink As LinkLabel
End Class
