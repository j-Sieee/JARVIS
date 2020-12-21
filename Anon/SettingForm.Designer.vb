<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.WebResponseTextBox = New System.Windows.Forms.TextBox()
        Me.WebCommandsTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SocialResponseTextBox = New System.Windows.Forms.TextBox()
        Me.SocialCommandsTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShellLocationTextBox = New System.Windows.Forms.TextBox()
        Me.ShellResponseTextBox = New System.Windows.Forms.TextBox()
        Me.ShellCommandsTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(118, 70)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PassTextBox.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(698, 232)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis2
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.WebsiteTextBox)
        Me.TabPage1.Controls.Add(Me.WebResponseTextBox)
        Me.TabPage1.Controls.Add(Me.WebCommandsTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(690, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Web Commands"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(531, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Website:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(320, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Response:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(44, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Commands:"
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.Location = New System.Drawing.Point(463, 39)
        Me.WebsiteTextBox.Multiline = True
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(224, 161)
        Me.WebsiteTextBox.TabIndex = 8
        '
        'WebResponseTextBox
        '
        Me.WebResponseTextBox.Location = New System.Drawing.Point(233, 39)
        Me.WebResponseTextBox.Multiline = True
        Me.WebResponseTextBox.Name = "WebResponseTextBox"
        Me.WebResponseTextBox.Size = New System.Drawing.Size(224, 161)
        Me.WebResponseTextBox.TabIndex = 7
        '
        'WebCommandsTextBox
        '
        Me.WebCommandsTextBox.Location = New System.Drawing.Point(3, 39)
        Me.WebCommandsTextBox.Multiline = True
        Me.WebCommandsTextBox.Name = "WebCommandsTextBox"
        Me.WebCommandsTextBox.Size = New System.Drawing.Size(224, 161)
        Me.WebCommandsTextBox.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis2
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.SocialResponseTextBox)
        Me.TabPage2.Controls.Add(Me.SocialCommandsTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(690, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Social Commands"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(312, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(312, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(522, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Response:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(93, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Commands:"
        '
        'SocialResponseTextBox
        '
        Me.SocialResponseTextBox.Location = New System.Drawing.Point(435, 39)
        Me.SocialResponseTextBox.Multiline = True
        Me.SocialResponseTextBox.Name = "SocialResponseTextBox"
        Me.SocialResponseTextBox.Size = New System.Drawing.Size(224, 161)
        Me.SocialResponseTextBox.TabIndex = 7
        '
        'SocialCommandsTextBox
        '
        Me.SocialCommandsTextBox.Location = New System.Drawing.Point(28, 39)
        Me.SocialCommandsTextBox.Multiline = True
        Me.SocialCommandsTextBox.Name = "SocialCommandsTextBox"
        Me.SocialCommandsTextBox.Size = New System.Drawing.Size(224, 161)
        Me.SocialCommandsTextBox.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis2
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.BrowseButton)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.ShellLocationTextBox)
        Me.TabPage3.Controls.Add(Me.ShellResponseTextBox)
        Me.TabPage3.Controls.Add(Me.ShellCommandsTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(690, 206)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Shell Commands"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(523, 180)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 3
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Cyan
        Me.Label10.Location = New System.Drawing.Point(531, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Location:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Cyan
        Me.Label11.Location = New System.Drawing.Point(320, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Response:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Cyan
        Me.Label12.Location = New System.Drawing.Point(44, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Commands:"
        '
        'ShellLocationTextBox
        '
        Me.ShellLocationTextBox.Location = New System.Drawing.Point(463, 39)
        Me.ShellLocationTextBox.Multiline = True
        Me.ShellLocationTextBox.Name = "ShellLocationTextBox"
        Me.ShellLocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.ShellLocationTextBox.Size = New System.Drawing.Size(224, 136)
        Me.ShellLocationTextBox.TabIndex = 8
        '
        'ShellResponseTextBox
        '
        Me.ShellResponseTextBox.Location = New System.Drawing.Point(233, 39)
        Me.ShellResponseTextBox.Multiline = True
        Me.ShellResponseTextBox.Name = "ShellResponseTextBox"
        Me.ShellResponseTextBox.Size = New System.Drawing.Size(224, 161)
        Me.ShellResponseTextBox.TabIndex = 7
        '
        'ShellCommandsTextBox
        '
        Me.ShellCommandsTextBox.Location = New System.Drawing.Point(3, 39)
        Me.ShellCommandsTextBox.Multiline = True
        Me.ShellCommandsTextBox.Name = "ShellCommandsTextBox"
        Me.ShellCommandsTextBox.Size = New System.Drawing.Size(224, 161)
        Me.ShellCommandsTextBox.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis2
        Me.TabPage4.Controls.Add(Me.PassLabel)
        Me.TabPage4.Controls.Add(Me.PassTextBox)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.NameLabel)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(690, 206)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "User Info"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.BackColor = System.Drawing.Color.Black
        Me.PassLabel.ForeColor = System.Drawing.Color.Cyan
        Me.PassLabel.Location = New System.Drawing.Point(53, 73)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(53, 13)
        Me.PassLabel.TabIndex = 4
        Me.PassLabel.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(371, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Black
        Me.NameLabel.ForeColor = System.Drawing.Color.Cyan
        Me.NameLabel.Location = New System.Drawing.Point(53, 34)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name:"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(294, 309)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|Executabe Files (*.exe)|*.exe|Word Documents (*.docx)|*." & _
            "docx|Presentation Documents (*.pptx)|*.pptx|Pdf files (*.pdf)|*.pdf|Jpg files (*" & _
            ".jpg)|.jpg"
        Me.OpenFileDialog1.Title = "Select a File"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(527, 309)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "sHOW"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(697, 344)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "SettingForm"
        Me.Text = "Setting"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebResponseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebCommandsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SocialResponseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SocialCommandsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ShellLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShellResponseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShellCommandsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
