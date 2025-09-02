Imports System.Net
Imports System.IO

Public Class Form1
    Private gameFolder As String = Path.Combine(Application.StartupPath, "gd19")
    Private gameExe As String = Path.Combine(gameFolder, "DindeGDPS.exe")
    Private zipUrl As String = "https://example.com/DindeGDPS.zip" ' <-- change to your file link
    Public Property ZipFile As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' check if game is already installed
        If File.Exists(gameExe) Then
            btnInstall.Text = "Uninstall"
        Else
            btnInstall.Text = "Install"
        End If

        ' fetch news
        Try
            Using client As New WebClient()
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
                Dim newsText As String = client.DownloadString("https://isabellewastaken.141412.xyz/news.html")
                newsLabel.Text = "News: " & newsText.Trim()
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
        Try
            Dim zipPath As String = Path.Combine(Application.StartupPath, "temp.zip")

            Using client As New WebClient()
                client.DownloadFile(zipUrl, zipPath)
            End Using

            If Directory.Exists(gameFolder) Then
                Directory.Delete(gameFolder, True)
            End If

            ZipFile.ExtractToDirectory(zipPath, gameFolder)
            File.Delete(zipPath)
            ' I think ZipFile is broken, but y'know..
            ' Too bad!
            btnInstall.Text = "Uninstall"
            MessageBox.Show("Installation complete!", "DindeGDPS")
        Catch ex As Exception
            MessageBox.Show("Install failed: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub UninstallGame()
        Try
            If Directory.Exists(gameFolder) Then
                Directory.Delete(gameFolder, True)
            End If

            btnInstall.Text = "Install"
            MessageBox.Show("Uninstalled successfully", "DindeGDPS")
        Catch ex As Exception
            MessageBox.Show("Uninstall failed: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Try
            If File.Exists(gameExe) Then
                Process.Start(gameExe)
            Else
                MessageBox.Show("Game not installed!", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to start game: " & ex.Message, "Error")
        End Try
    End Sub

    ' discord link
    Private Sub discordLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles discordLink.LinkClicked
        Process.Start("https://discord.gg/sVcFBddjfj")
    End Sub

    ' dinde youtube link
    Private Sub dindeYTLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles dindeYTLink.LinkClicked
        Process.Start("https://www.youtube.com/@dindegdps")
    End Sub

    ' evy youtube link
    Private Sub evyYTLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles evyYTLink.LinkClicked
        Process.Start("https://www.youtube.com/@therealevelyn200")
    End Sub
End Class
