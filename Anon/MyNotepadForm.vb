Imports System.Speech.Recognition
Imports System.Speech


Public Class MyNotepadForm


    Dim WithEvents NotepadRecognizer As New Recognition.SpeechRecognitionEngine

    Public Sub New()



        InitializeComponent()



        AddHandler NotepadRecognizer.SpeechRecognized, AddressOf NotepadRecognizer_SpeechRecognized
        AddHandler NotepadRecognizer.SpeechRecognitionRejected, AddressOf NotepadRecognizer_SpeechRecognitionRejected



    End Sub

    Private Sub NotepadRecognizer_SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Dim NP As New Synthesis.SpeechSynthesizer

        Select Case e.Result.Text.ToUpper


            Case Is = "SAVE", "SAVE THIS TEXT FILE"


                SaveToolStripMenuItem_Click(sender, e)
            Case Is = "INSERT SAMPLE TEXT"
                InserSampleTextToolStripMenuItem_Click(sender, e)


            Case Is = "DELETE ALL TEXT", "CLEAR ALL TEXT", "REMOVE ALL TEXT"

                NotepadTextBox.Clear()
            Case Is = "OPEN TEXT FILE"
                OpenToolStripMenuItem_Click(sender, e)

            Case Is = "NEW TEXT FILE"
                NewToolStripMenuItem_Click(sender, e)

            Case Is = "CLOSE NOTEPAD"
                Me.Close()
                MainForm.WindowState = FormWindowState.Normal



            Case Is = "SELECT ALL TEXT"
                SelectAllToolStripMenuItem_Click(sender, e)

            Case Is = "COPY", "COPY THAT TEXT"

                If NotepadTextBox.SelectedText = "" Then

                    NP.SpeakAsync("It appears that you did not select a text to be copy. Please select a text first")

                Else

                    CopyToolStripMenuItem2_Click(sender, e)
                    NP.SpeakAsync("Copy That Sir")

                End If



            Case Is = "CUT", "CUT THAT TEXT"

                CutToolStripMenuItem_Click(sender, e)


            Case Is = "PASTE", "PASTE THE TEXT NOW"

                If NotepadTextBox.SelectedText = "" Then

                    NotepadTextBox.SelectedText = Clipboard.GetText

                    If NotepadTextBox.SelectedText = Clipboard.GetText Then
                        NP.SpeakAsync("It appears that you do not have yet a copied text. Please copy some text first ")
                    End If




                Else

                    PasteToolStripMenuItem_Click(sender, e)



                End If

            Case Is = "SHOW FONT DIALOG"

                FontToolStripMenuItem_Click(sender, e)


            Case Is = "SELECT FILE"
                FileToolStripMenuItem_Click(sender, e)

            Case Is = "SELECT EDIT"

                EditToolStripMenuItem_Click(sender, e)
            Case Is = "SELECT HELP"

                HelpToolStripMenuItem_Click(sender, e)
            Case Is = "ABOUT THIS NOTEPAD"

                AboutToolStripMenuItem1_Click(sender, e)
            Case Is = "UNDO IT"
                UndoToolStripMenuItem_Click(sender, e)

            Case Is = "HIDE DROP DOWN LIST"
                FileToolStripMenuItem.HideDropDown()
                EditToolStripMenuItem.HideDropDown()
                HelpToolStripMenuItem.HideDropDown()


        End Select


    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        End
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NotepadTextBox.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        FileSystem.FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        FileSystem.Print(1, NotepadTextBox.Text)
        FileSystem.FileClose(1)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If
        ' this part loads the file
        Dim Tmp As String
        Tmp = ""
        FileSystem.FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        Do While Not FileSystem.EOF(1)
            Tmp = Tmp & FileSystem.LineInput(1)
            If Not FileSystem.EOF(1) Then
                Tmp = Tmp & Chr(13) & Chr(10)
            End If
        Loop
        FileSystem.FileClose(1)
        NotepadTextBox.Text = Tmp
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        NotepadTextBox.Font = FontDialog1.Font
    End Sub

    Private Sub CopyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem2.Click
        If NotepadTextBox.SelectedText = "" Then
        Else

            Clipboard.SetText(NotepadTextBox.SelectedText)
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetText(NotepadTextBox.SelectedText)
        NotepadTextBox.SelectedText = ""
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        NotepadTextBox.SelectedText = Clipboard.GetText
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("This application is created as a test project.", MsgBoxStyle.OkOnly, "About My Notepad")
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        NotepadTextBox.SelectAll()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotepadTextBox.Clear()
        NotepadRecognizer.SetInputToDefaultAudioDevice()

        Dim Grammar As New GrammarBuilder()
        Grammar.Append(New Choices(System.IO.File.ReadAllLines("Notepad Commands.txt")))

        NotepadRecognizer.LoadGrammar(New Recognition.Grammar(Grammar))
        NotepadRecognizer.RecognizeAsync()




    End Sub

    Private Sub notepadRecognizer_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles NotepadRecognizer.RecognizeCompleted
        NotepadRecognizer.RecognizeAsync()

    End Sub

    Public Sub InserSampleTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserSampleTextToolStripMenuItem.Click
        Dim Sample As String = "Hello! My Name is Anon (Project Jarvis Own Version)" & Environment.NewLine _
                                               & "This Notepad is a part of Project Jarvis." & Environment.NewLine & "This is a sample text."


        NotepadTextBox.Text = Sample
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        EditToolStripMenuItem.ShowDropDown()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        HelpToolStripMenuItem.ShowDropDown()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        NotepadTextBox.Undo()

    End Sub

    
    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
        FileToolStripMenuItem.ShowDropDown()

    End Sub
    Private Sub NotepadRecognizer_SpeechRecognitionRejected(ByVal sender As Object, ByVal e As SpeechRecognitionRejectedEventArgs)

    End Sub
End Class
