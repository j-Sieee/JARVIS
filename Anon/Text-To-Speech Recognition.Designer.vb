<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Text_To_Speech_Recognition
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
        Me.TextToSpeechTextBox = New System.Windows.Forms.TextBox()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextToSpeechTextBox
        '
        Me.TextToSpeechTextBox.Location = New System.Drawing.Point(12, 30)
        Me.TextToSpeechTextBox.Multiline = True
        Me.TextToSpeechTextBox.Name = "TextToSpeechTextBox"
        Me.TextToSpeechTextBox.Size = New System.Drawing.Size(349, 97)
        Me.TextToSpeechTextBox.TabIndex = 0
        '
        'PlayButton
        '
        Me.PlayButton.Enabled = False
        Me.PlayButton.Location = New System.Drawing.Point(141, 138)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(75, 23)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Text_To_Speech_Recognition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Anon.My.Resources.Resources.Jarvis
        Me.ClientSize = New System.Drawing.Size(373, 173)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.TextToSpeechTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Text_To_Speech_Recognition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text To Speech Recognition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextToSpeechTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlayButton As System.Windows.Forms.Button
End Class
