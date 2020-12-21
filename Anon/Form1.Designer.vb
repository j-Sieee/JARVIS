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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CommandsListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToSpeechRecognitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandsListBox
        '
        Me.CommandsListBox.BackColor = System.Drawing.SystemColors.WindowText
        Me.CommandsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandsListBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CommandsListBox.FormattingEnabled = True
        Me.CommandsListBox.ItemHeight = 20
        Me.CommandsListBox.Location = New System.Drawing.Point(12, 27)
        Me.CommandsListBox.Name = "CommandsListBox"
        Me.CommandsListBox.Size = New System.Drawing.Size(346, 204)
        Me.CommandsListBox.TabIndex = 1
        Me.CommandsListBox.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(370, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToSpeechRecognitionToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TextToSpeechRecognitionToolStripMenuItem
        '
        Me.TextToSpeechRecognitionToolStripMenuItem.Name = "TextToSpeechRecognitionToolStripMenuItem"
        Me.TextToSpeechRecognitionToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.TextToSpeechRecognitionToolStripMenuItem.Text = "Text To Speech Recognition"
        '
        'WindowsMediaPlayer1
        '
        Me.WindowsMediaPlayer1.Enabled = True
        Me.WindowsMediaPlayer1.Location = New System.Drawing.Point(70, 218)
        Me.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1"
        Me.WindowsMediaPlayer1.OcxState = CType(resources.GetObject("WindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WindowsMediaPlayer1.Size = New System.Drawing.Size(229, 77)
        Me.WindowsMediaPlayer1.TabIndex = 0
        Me.WindowsMediaPlayer1.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Jarvis"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem1.Text = "Open &Jarvis"
        Me.ToolStripMenuItem1.ToolTipText = "Show Jarvis Application"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem2.Text = "E&xit"
        Me.ToolStripMenuItem2.ToolTipText = "Quit Application"
        '
        'ShutdownTimer
        '
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditNameToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditNameToolStripMenuItem
        '
        Me.EditNameToolStripMenuItem.Name = "EditNameToolStripMenuItem"
        Me.EditNameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditNameToolStripMenuItem.Text = "Edit Name"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anon.My.Resources.Resources.NotSpeaking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(370, 294)
        Me.Controls.Add(Me.CommandsListBox)
        Me.Controls.Add(Me.WindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                 J.A.R.V.I.S v 1.0"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents CommandsListBox As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextToSpeechRecognitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ShutdownTimer As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
