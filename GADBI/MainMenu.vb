Public Class MainMenu

    Private Sub Process1_Exited(sender As Object, e As EventArgs) Handles Process1.Exited

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub AboutGADBIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutGADBIToolStripMenuItem.Click
        AboutGADBI.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub RebootToBootloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToBootloaderToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Enterprises\GADBI\adb.exe", "reboot bootloader")
    End Sub

    Private Sub RebootToDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToDownloadToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Enterprises\GADBI\adb.exe", "reboot download")
    End Sub

    Private Sub RebootToRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToRecoveryToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Enterprises\GADBI\adb.exe", "reboot recovery")
    End Sub

    Private Sub RebootToSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToSystemToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Enterprises\GADBI\adb.exe", "reboot")
    End Sub

    Private Sub ProjectOpenCannibalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectOpenCannibalToolStripMenuItem.Click
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", "http://forums.projectopencannibal.org")
    End Sub

    Private Sub XDAForumsThreadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XDAForumsThreadToolStripMenuItem.Click
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", "http://forum.xda-developers.com")
    End Sub

    Private Sub AndroidCentralThreadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndroidCentralThreadToolStripMenuItem.Click
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", "http://forums.androidcentral.com")
    End Sub
End Class
