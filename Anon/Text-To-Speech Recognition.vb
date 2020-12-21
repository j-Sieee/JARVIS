Imports System.Speech


Public Class Text_To_Speech_Recognition

    Private Sub Text_To_Speech_Recognition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextToSpeechTextBox.Text = "OBJECT ORIENTED PROGRAMMING FINAL DEFENSE"






    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        Dim Texttospeech As New Synthesis.SpeechSynthesizer '= CreateObject("sapi.spvoice")


        If TextToSpeechTextBox.Text = "" Then

            PlayButton.Enabled = False
            

        Else

            PlayButton.Enabled = True

        End If


        If TextToSpeechTextBox.SelectedText = "" Then
            Texttospeech.SpeakAsync(TextToSpeechTextBox.Text)



        Else

            Texttospeech.SpeakAsync(TextToSpeechTextBox.SelectedText)


        End If

    End Sub

    Private Sub TextToSpeechTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToSpeechTextBox.TextChanged

        PlayButton.Enabled = True
        '  StopButton.Enabled = True


    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim stoptext As New Synthesis.SpeechSynthesizer






        '        stoptext.SpeakAsyncCancelAll()








    End Sub
End Class