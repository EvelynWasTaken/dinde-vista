<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GDPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulgarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BugReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComingSoonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComingSoonToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.inGameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'inGameLogo
        '
        Me.inGameLogo.Image = Global.DindeGDPS_Vista_Final.My.Resources.Resources.logo
        Me.inGameLogo.Location = New System.Drawing.Point(196, 27)
        Me.inGameLogo.Name = "inGameLogo"
        Me.inGameLogo.Size = New System.Drawing.Size(417, 133)
        Me.inGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inGameLogo.TabIndex = 0
        Me.inGameLogo.TabStop = False
        '
        'btnInstall
        '
        Me.btnInstall.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnInstall.Location = New System.Drawing.Point(174, 236)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(113, 101)
        Me.btnInstall.TabIndex = 1
        Me.btnInstall.Text = "Install"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Location = New System.Drawing.Point(335, 236)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(113, 101)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'versionLabel
        '
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Location = New System.Drawing.Point(107, 421)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(397, 13)
        Me.versionLabel.TabIndex = 3
        Me.versionLabel.Text = "DindeGDPS Legacy Launcher v1.2 - Launcher by Zhevelyn - DindeGDPS by Jean"
        '
        'newsLabel
        '
        Me.newsLabel.AutoSize = True
        Me.newsLabel.Location = New System.Drawing.Point(193, 177)
        Me.newsLabel.Name = "newsLabel"
        Me.newsLabel.Size = New System.Drawing.Size(129, 13)
        Me.newsLabel.TabIndex = 8
        Me.newsLabel.Text = "News: Failed to get news!"
        Me.newsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gdLogo
        '
        Me.gdLogo.Image = Global.DindeGDPS_Vista_Final.My.Resources.Resources.dindes
        Me.gdLogo.Location = New System.Drawing.Point(26, 27)
        Me.gdLogo.Name = "gdLogo"
        Me.gdLogo.Size = New System.Drawing.Size(142, 133)
        Me.gdLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gdLogo.TabIndex = 9
        Me.gdLogo.TabStop = False
        '
        'discordLink
        '
        Me.discordLink.AutoSize = True
        Me.discordLink.Location = New System.Drawing.Point(157, 389)
        Me.discordLink.Name = "discordLink"
        Me.discordLink.Size = New System.Drawing.Size(43, 13)
        Me.discordLink.TabIndex = 10
        Me.discordLink.TabStop = True
        Me.discordLink.Text = "Discord"
        '
        'dindeYTLink
        '
        Me.dindeYTLink.AutoSize = True
        Me.dindeYTLink.Location = New System.Drawing.Point(251, 389)
        Me.dindeYTLink.Name = "dindeYTLink"
        Me.dindeYTLink.Size = New System.Drawing.Size(108, 13)
        Me.dindeYTLink.TabIndex = 11
        Me.dindeYTLink.TabStop = True
        Me.dindeYTLink.Text = "DindeGDPS Youtube"
        '
        'evyYTLink
        '
        Me.evyYTLink.AutoSize = True
        Me.evyYTLink.Location = New System.Drawing.Point(385, 389)
        Me.evyYTLink.Name = "evyYTLink"
        Me.evyYTLink.Size = New System.Drawing.Size(101, 13)
        Me.evyYTLink.TabIndex = 12
        Me.evyYTLink.TabStop = True
        Me.evyYTLink.Text = "Zhevelyn's Youtube"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GDPSToolStripMenuItem, Me.SpecialToolStripMenuItem, Me.LinksToolStripMenuItem, Me.SocialsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GDPSToolStripMenuItem
        '
        Me.GDPSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.GDPSToolStripMenuItem.Name = "GDPSToolStripMenuItem"
        Me.GDPSToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.GDPSToolStripMenuItem.Text = "GDPS"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SpecialToolStripMenuItem
        '
        Me.SpecialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BulgarianToolStripMenuItem})
        Me.SpecialToolStripMenuItem.Name = "SpecialToolStripMenuItem"
        Me.SpecialToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SpecialToolStripMenuItem.Text = "Special"
        '
        'BulgarianToolStripMenuItem
        '
        Me.BulgarianToolStripMenuItem.Name = "BulgarianToolStripMenuItem"
        Me.BulgarianToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BulgarianToolStripMenuItem.Text = "Bulgarian"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BugReportToolStripMenuItem, Me.WebsiteToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'BugReportToolStripMenuItem
        '
        Me.BugReportToolStripMenuItem.Name = "BugReportToolStripMenuItem"
        Me.BugReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BugReportToolStripMenuItem.Text = "Bug Report"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComingSoonToolStripMenuItem})
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.LinksToolStripMenuItem.Text = "Links"
        '
        'ComingSoonToolStripMenuItem
        '
        Me.ComingSoonToolStripMenuItem.Name = "ComingSoonToolStripMenuItem"
        Me.ComingSoonToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComingSoonToolStripMenuItem.Text = "Coming Soon..."
        '
        'SocialsToolStripMenuItem
        '
        Me.SocialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComingSoonToolStripMenuItem1})
        Me.SocialsToolStripMenuItem.Name = "SocialsToolStripMenuItem"
        Me.SocialsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SocialsToolStripMenuItem.Text = "Socials"
        '
        'ComingSoonToolStripMenuItem1
        '
        Me.ComingSoonToolStripMenuItem1.Name = "ComingSoonToolStripMenuItem1"
        Me.ComingSoonToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ComingSoonToolStripMenuItem1.Text = "Coming Soon..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 443)
        Me.Controls.Add(Me.evyYTLink)
        Me.Controls.Add(Me.dindeYTLink)
        Me.Controls.Add(Me.discordLink)
        Me.Controls.Add(Me.gdLogo)
        Me.Controls.Add(Me.newsLabel)
        Me.Controls.Add(Me.versionLabel)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.inGameLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DindeGDPS Launcher"
        CType(Me.inGameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GDPSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulgarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BugReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComingSoonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComingSoonToolStripMenuItem1 As ToolStripMenuItem
End Class
