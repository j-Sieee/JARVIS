Public Class SettingForm

    'Friend socialcommands() As String = New Object SocialCommandsTextBox.Lines
    'Friend socialresponse() As String = SocialResponseTextBox.Lines

    Friend socialresponse As String



    Friend socialcommands As String




    Private Sub SettingForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainForm.Show()


    End Sub

    Private Sub SettingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '        Dim socialcommands As String = SocialCommandsTextBox.Lines(0)



        '

        'socialcommands = SocialCommandsTextBox.Text


        '       For A As Integer = 0 To socialcommands.Count Step 1






        'Next
        SocialCommandsTextBox.Lines = System.IO.File.ReadAllLines("Social Commands.txt")
        SocialResponseTextBox.Lines = System.IO.File.ReadAllLines("Social Response.txt")
        WebCommandsTextBox.Lines = System.IO.File.ReadAllLines("Web Commands.txt")
        WebResponseTextBox.Lines = System.IO.File.ReadAllLines("Web Response.txt")
        WebsiteTextBox.Lines = System.IO.File.ReadAllLines("Web URL.txt")
        ShellCommandsTextBox.Lines = System.IO.File.ReadAllLines("Shell Commands.txt")
        ShellResponseTextBox.Lines = System.IO.File.ReadAllLines("Shell Response.txt")

        'For i As Integer = 0 To SocialCommands.Count - 1
        'SocialCommandsTextBox.Text = SocialCommands(i)


        ' Next




        ' Dim SocialResponse() As String = System.IO.File.ReadAllLines("Social Response.txt")

        ' For i As Integer = 0 To SocialResponse.Count - 1
        'SocialCommandsTextBox.Text.Insert(0, SocialResponse(i))


        '  Next
        '
        '  Dim WebResponse() As String = System.IO.File.ReadAllLines("Web Response.txt")

        'For i As Integer = 0 To WebResponse.Count - 1
        '  WebResponseTextBox.Text.Insert(0 + 1, WebResponse(i))
        '
        'Next
        '
        'Dim WebCommands() As String = System.IO.File.ReadAllLines("Web Commands.txt")

        'For i As Integer = 0 To WebCommands.Count - 1
        ' WebCommandsTextBox.Text.Insert(0, WebCommands(i))

        ' Next

        ' Dim WebURL() As String = System.IO.File.ReadAllLines("Web URL.txt")
        '
        ' For i As Integer = 0 To WebResponse.Count - 1
        'WebsiteTextBox.Text.Insert(0, WebURL(i))
        '
        ' Next





    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click


       









        System.IO.File.WriteAllText("Social Commands.txt", SocialCommandsTextBox.Text)
        System.IO.File.WriteAllText("Social Response.txt", SocialResponseTextBox.Text)
        System.IO.File.WriteAllText("Web Response.txt", WebResponseTextBox.Text)
        System.IO.File.WriteAllText("Web Commands.txt", WebCommandsTextBox.Text)
        System.IO.File.WriteAllText("Web URL.txt", WebCommandsTextBox.Text)
        System.IO.File.WriteAllText("Shell Commands.txt", ShellCommandsTextBox.Text)
        System.IO.File.WriteAllText("Shell Response.txt", ShellResponseTextBox.Text)
        System.IO.File.WriteAllText("Shell Location.txt", ShellLocationTextBox.Text)





        ' For i As Integer = 0 To socialcommands.Count - 1
        '
        'SocialCommandsTextBox.Text.Contains(i)


        'Next


        'For i As Integer = 0 To socialresponse.Count - 1

        'SocialResponseTextBox.Text.Contains(i)

        '        Next





    End Sub

    Private Sub BrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        OpenFileDialog1.ShowDialog()

        



    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        If OpenFileDialog1.FileName = "" Then
            Exit Sub

        End If

        ShellLocationTextBox.Text = OpenFileDialog1.FileName



    End Sub

    Private Sub WebCommandsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebCommandsTextBox.TextChanged







    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim asd As Array = SocialCommandsTextBox.Lines
        Dim qwe As Array = SocialResponseTextBox.Lines



        ' socialcommands = SocialCommandsTextBox.Lines.Count()

        ' socialcommands = SocialCommandsTextBox.Lines(1)
        'MsgBox(socialcommands)

        ' For i As Integer = 0 To socialcommands Step 1

        '   TextBox2.Text = SocialResponseTextBox.Lines(i)

        '   Next

        If TextBox1.Text = asd(1) Then

            TextBox2.Text = SocialResponseTextBox.Lines(qwe(1))



        End If

        '
        '

        ' 






    End Sub
End Class