Imports System.Net
Imports Ionic.Zip
Imports System.IO

Public Class Form1
    Private gdpsFolder As String = Path.Combine(Application.StartupPath, "gd19")
    Private gdpsExe As String = Path.Combine(Application.StartupPath, "gd19", "DindeGDPS.exe")
    Private newsUrl As String = "https://isabellewastaken.141412.xyz/news.html"
    Private zipUrl As String = "https://yourdownloadlink.com/dindegdps.zip"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set install/uninstall button text
        If Directory.Exists(gdpsFolder) AndAlso File.Exists(gdpsExe) Then
            btnInstall.Text = "Uninstall"
        Else
            btnInstall.Text = "Install"
        End If

        ' try to fetch news
        Try
            Using client As New WebClient()
                Dim newsText As String = client.DownloadString(newsUrl).Trim()
                newsLabel.Text = "News: " & newsText
            End Using
        Catch ex As Exception
            newsLabel.Text = "News: Failed to load"
        End Try
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        If btnInstall.Text = "Install" Then
            InstallGame()
        Else
            UninstallGame()
        End If
    End Sub

    Private Sub InstallGame()
        Dim zipPath As String = Path.Combine(Application.StartupPath, "gd19.zip")

        Try
            ' download the zip
            Using client As New WebClient()
                client.DownloadFile(zipUrl, zipPath)
            End Using

            ' extract it
            Using zip As ZipFile = ZipFile.Read(zipPath)
                For Each entry In zip
                    entry.Extract(gdpsFolder, ExtractExistingFileAction.OverwriteSilently)
                Next
            End Using

            File.Delete(zipPath)
            MessageBox.Show("Installed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnInstall.Text = "Uninstall"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Install failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UninstallGame()
        Try
            If Directory.Exists(gdpsFolder) Then
                Directory.Delete(gdpsFolder, True)
            End If
            MessageBox.Show("Uninstalled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnInstall.Text = "Install"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Uninstall failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Try
            If File.Exists(gdpsExe) Then
                Process.Start(New ProcessStartInfo(gdpsExe) With {.UseShellExecute = True})
            Else
                MessageBox.Show("Game not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Failed to start", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===== links =====
    Private Sub discordLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles discordLink.LinkClicked
        Process.Start(New ProcessStartInfo("https://discord.gg/sVcFBddjfj") With {.UseShellExecute = True})
    End Sub

    Private Sub dindeYTLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles dindeYTLink.LinkClicked
        Process.Start(New ProcessStartInfo("https://www.youtube.com/@dindegdps") With {.UseShellExecute = True})
    End Sub

    Private Sub evyYTLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles evyYTLink.LinkClicked
        Process.Start(New ProcessStartInfo("https://www.youtube.com/@therealevelyn200") With {.UseShellExecute = True})
    End Sub

    ' ===== menu strip =====
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BulgarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulgarianToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show(
            "You're probably an adult bulgarian",
            "real",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
        )

        If result = DialogResult.OK Then
            Process.Start(New ProcessStartInfo("https://www.youtube.com/@alexeez") With {.UseShellExecute = True})
        End If
    End Sub

    Private Sub BugReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BugReportToolStripMenuItem.Click
        MessageBox.Show(
            "If you have found any bugs, screenshot it and send it to jeantasoeur (discord) or contactus@dimisaio.be with body: ""DindeGDPS Bug!""",
            "Bugs? Oh noes!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start(New ProcessStartInfo("https://dimisaio.be/") With {.UseShellExecute = True})
    End Sub
End Class
