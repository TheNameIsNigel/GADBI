Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms
Imports AutoUpdaterDotNET
Imports RegawMOD.Android
Public Class MainMenu

    Dim android As AndroidController
    Dim device As Device
    Dim serial As String
    Dim adbCmd As AdbCommand = Adb.FormAdbCommand("logcat", "-d")
    Dim logcatOutput As String = Adb.ExecuteAdbCommand(adbCmd)

    Private Sub MainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Usually, you want to load this at startup, may take up to 5 seconds to initialize/set up resources/start server
        android = AndroidController.Instance
        android.UpdateDeviceList()
        ListBox1.Items.Clear()



        If android.HasConnectedDevices Then
            serial = android.ConnectedDevices(0)
            device = android.GetConnectedDevice(serial)

            'Adds all of the build.prop keys to the listbox
            ListBox1.Items.AddRange(device.BuildProp.Keys.ToArray)

            'So no items are selected right away
            ListBox1.SelectedValue = "ro.build.product"
        End If
    End Sub

    Private Sub MainMenu_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'ALWAYS remember to call this when you're done with AndroidController.  It removes used resources
        android.Dispose()
    End Sub

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
        AutoUpdater.Start("http://apps.projectopencannibal.org/win/cot/updater.xml")
    End Sub

    Private Sub RebootToBootloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToBootloaderToolStripMenuItem.Click

    End Sub

    Private Sub RebootToDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToDownloadToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Enterprises\GADBI\adb.exe", "reboot download")
    End Sub

    Private Sub RebootToRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToRecoveryToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Solutions\GADBI\adb.exe", "reboot recovery")
    End Sub

    Private Sub RebootToSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToSystemToolStripMenuItem.Click
        Process.Start("C:\Program Files\Norris Solutions\GADBI\adb.exe", "reboot")
    End Sub

    Private Sub ProjectOpenCannibalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectOpenCannibalToolStripMenuItem.Click
        Process.Start("iexplore.exe", "http://forums.projectopencannibal.org")
    End Sub

    Private Sub XDAForumsThreadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XDAForumsThreadToolStripMenuItem.Click
        Process.Start("iexplore", "http://forum.xda-developers.com")
    End Sub

    Private Sub AndroidCentralThreadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndroidCentralThreadToolStripMenuItem.Click
        Process.Start("iexplore.exe", "http://forums.androidcentral.com")
    End Sub

    Private Sub ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub InstallCOTThemesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallCOTThemesToolStripMenuItem.Click
        Themes.ShowDialog()
    End Sub

    Private Sub TowelRootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TowelRootToolStripMenuItem.Click
        Process.Start("iexplore", "https://towelroot.com")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label4.Text = device.BuildProp.GetProp(ListBox1.SelectedItem.ToString())
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Console.WriteLine("Waiting For Device...")
        android.WaitForDevice()

    End Sub

    Private Sub CreditsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem1.Click
        Credits.ShowDialog()
    End Sub
End Class
