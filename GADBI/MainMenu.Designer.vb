<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutGADBIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectOpenCannibalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XDAForumsThreadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndroidCentralThreadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Process1 = New System.Diagnostics.Process()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RebootDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToBootloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToDownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.LinksToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(997, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LoginToolStripMenuItem.Text = "Login..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RebootDeviceToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.AboutGADBIToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates..."
        '
        'AboutGADBIToolStripMenuItem
        '
        Me.AboutGADBIToolStripMenuItem.Name = "AboutGADBIToolStripMenuItem"
        Me.AboutGADBIToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutGADBIToolStripMenuItem.Text = "About GADBI"
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectOpenCannibalToolStripMenuItem, Me.XDAForumsThreadToolStripMenuItem, Me.AndroidCentralThreadToolStripMenuItem})
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.LinksToolStripMenuItem.Text = "Links"
        '
        'ProjectOpenCannibalToolStripMenuItem
        '
        Me.ProjectOpenCannibalToolStripMenuItem.Name = "ProjectOpenCannibalToolStripMenuItem"
        Me.ProjectOpenCannibalToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ProjectOpenCannibalToolStripMenuItem.Text = "Project Open Cannibal"
        '
        'XDAForumsThreadToolStripMenuItem
        '
        Me.XDAForumsThreadToolStripMenuItem.Name = "XDAForumsThreadToolStripMenuItem"
        Me.XDAForumsThreadToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.XDAForumsThreadToolStripMenuItem.Text = "XDA-Forums Thread"
        '
        'AndroidCentralThreadToolStripMenuItem
        '
        Me.AndroidCentralThreadToolStripMenuItem.Name = "AndroidCentralThreadToolStripMenuItem"
        Me.AndroidCentralThreadToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AndroidCentralThreadToolStripMenuItem.Text = "AndroidCentral Thread"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Device"
        '
        'RebootDeviceToolStripMenuItem
        '
        Me.RebootDeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RebootToBootloaderToolStripMenuItem, Me.RebootToDownloadToolStripMenuItem, Me.RebootToRecoveryToolStripMenuItem, Me.RebootToSystemToolStripMenuItem})
        Me.RebootDeviceToolStripMenuItem.Name = "RebootDeviceToolStripMenuItem"
        Me.RebootDeviceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RebootDeviceToolStripMenuItem.Text = "Reboot Device"
        '
        'RebootToBootloaderToolStripMenuItem
        '
        Me.RebootToBootloaderToolStripMenuItem.Name = "RebootToBootloaderToolStripMenuItem"
        Me.RebootToBootloaderToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RebootToBootloaderToolStripMenuItem.Text = "Reboot to Bootloader"
        '
        'RebootToDownloadToolStripMenuItem
        '
        Me.RebootToDownloadToolStripMenuItem.Name = "RebootToDownloadToolStripMenuItem"
        Me.RebootToDownloadToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RebootToDownloadToolStripMenuItem.Text = "Reboot to Download"
        '
        'RebootToRecoveryToolStripMenuItem
        '
        Me.RebootToRecoveryToolStripMenuItem.Name = "RebootToRecoveryToolStripMenuItem"
        Me.RebootToRecoveryToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RebootToRecoveryToolStripMenuItem.Text = "Reboot to Recovery"
        '
        'RebootToSystemToolStripMenuItem
        '
        Me.RebootToSystemToolStripMenuItem.Name = "RebootToSystemToolStripMenuItem"
        Me.RebootToSystemToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RebootToSystemToolStripMenuItem.Text = "Reboot to System"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 492)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graphical Android Debugging Bridge Interface"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutGADBIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectOpenCannibalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XDAForumsThreadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AndroidCentralThreadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootDeviceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToBootloaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToDownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToRecoveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
