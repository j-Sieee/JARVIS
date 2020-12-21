Imports System.Speech.Recognition
Imports System.Speech
Imports System.Speech.Recognition.SrgsGrammar
Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports System.IO
Imports System.Speech.Synthesis
Imports System.Globalization





Public Class MainForm




    Dim Myname As String


    Dim WithEvents Player As New WMPLib.WindowsMediaPlayer
    Dim MyMusicPaths As Collections.ObjectModel.ReadOnlyCollection(Of String)



    Dim WithEvents AnonRecognizer As New Recognition.SpeechRecognitionEngine()
    Dim WithEvents startlistening As New Recognition.SpeechRecognitionEngine
    Dim Anon As New Synthesis.SpeechSynthesizer



    Private timenow As DateTime = DateTime.Now
    Dim QuestionEvent As String
    Private rnd As Random = New Random
    Dim CurrentPlaying As Integer = 0
    Dim PreviouslyPlaying As Integer = 0
    Dim count As Integer = 1

    Dim files As Collections.ObjectModel.ReadOnlyCollection(Of String)





    Public Sub New()



        InitializeComponent()



        AddHandler AnonRecognizer.SpeechRecognized, AddressOf AnonRecognizer_SpeechRecognized
        AddHandler AnonRecognizer.SpeechRecognitionRejected, AddressOf recognizer_SpeechRecognitionRejected



    End Sub

    Private Sub AnonRecognizer_SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Dim Random As New Random
        Dim Number As Integer = Random.Next(1, 10)

        MyMusicPaths = FileIO.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyMusic, FileIO.SearchOption.SearchAllSubDirectories, "*.mp3")
        If UserInfo.NameTextBox.Text = "" Then

            Myname = My.Computer.Name
        Else

            Myname = UserInfo.NameTextBox.Text


        End If

        


        Dim Ran As Integer = Me.rnd.Next(0, MyMusicPaths.Count)

        Select Case e.Result.Text.ToUpper





            Case Is = "GOOD MORNING JARVIS"
                If Me.timenow.Hour >= 5 AndAlso Me.timenow.Hour < 12 Then

                    Anon.SpeakAsync("Goodmorning " & Myname)

                End If

                If Me.timenow.Hour >= 12 AndAlso Me.timenow.Hour < 18 Then
                    Anon.SpeakAsync("It's Afternoon " & Myname)

                End If


                If Me.timenow.Hour >= 18 AndAlso Me.timenow.Hour < 24 Then
                    Anon.SpeakAsync("It's evening " & Myname)

                End If

                If Me.timenow.Hour < 5 Then
                    Anon.SpeakAsync("Goodmorning " & Myname)

                End If


            Case Is = "GOOD EVENING JARVIS"


                If Me.timenow.Hour >= 5 AndAlso Me.timenow.Hour < 12 Then

                    Anon.SpeakAsync("It's morning" & Myname)

                End If

                If Me.timenow.Hour >= 12 AndAlso Me.timenow.Hour < 18 Then
                    Anon.SpeakAsync("It's Afternoon " & Myname)

                End If


                If Me.timenow.Hour >= 18 AndAlso Me.timenow.Hour < 24 Then
                    Anon.SpeakAsync("Good evening " & Myname)

                End If

                If Me.timenow.Hour < 5 Then
                    Anon.SpeakAsync("It's already morning" & Myname)

                End If


            Case Is = "GOOD AFTERNOON"
                If Me.timenow.Hour >= 5 AndAlso Me.timenow.Hour < 12 Then

                    Anon.SpeakAsync("It's morning" & Myname)

                End If

                If Me.timenow.Hour >= 12 AndAlso Me.timenow.Hour < 18 Then
                    Anon.SpeakAsync("Good Afternoon " & Myname)

                End If


                If Me.timenow.Hour >= 18 AndAlso Me.timenow.Hour < 24 Then
                    Anon.SpeakAsync("It's evening " & Myname)

                End If

                If Me.timenow.Hour < 5 Then
                    Anon.SpeakAsync("It's already morning" & Myname)

                End If

            Case Is = "HI", "HELLO JARVIS", "HELLO"

                If Me.timenow.Hour >= 5 AndAlso Me.timenow.Hour < 12 Then

                    Anon.SpeakAsync("Goodmorning" & Myname)

                End If

                If Me.timenow.Hour >= 12 AndAlso Me.timenow.Hour < 18 Then
                    Anon.SpeakAsync("Good Afternoon " & Myname)

                End If


                If Me.timenow.Hour >= 18 AndAlso Me.timenow.Hour < 24 Then
                    Anon.SpeakAsync("Good evening " & Myname)

                End If

                If Me.timenow.Hour < 5 Then
                    Anon.SpeakAsync("Hello " & Myname & ", it's getting late")

                End If
            Case Is = "JARVIS"

                Select Case Number

                    Case Is = 1, 2
                        Anon.SpeakAsync("Yes sIr ")


                    Case Is = 3, 4
                        Anon.SpeakAsync("Yes?")

                    Case Is = 4, 5

                        Anon.SpeakAsync("How may i help?")

                    Case Is = 5, 6

                        Anon.SpeakAsync("How may I be of assistance?")




                End Select

            Case Is = "HOW ARE YOU DOING", "HOWS LIFE", "HOW ARE YOU", "HOW ARE YOU", "HOW ARE YOU TODAY"


                Select Case Number
                    Case Is = 1, 2
                        Anon.SpeakAsync("Good as always. Thanks for asking")
                    Case Is = 3, 4
                        Anon.SpeakAsync("I'm doing particularly well actually. How are you?")
                        QuestionEvent = "Particularly well"
                    Case Is = 5, 6
                        Anon.SpeakAsync("I'm good. How about you sir?")
                        QuestionEvent = "I'm good"
                    Case Else : Anon.SpeakAsync("Couldn't be better. And you?")
                        QuestionEvent = "And you"
                End Select

            Case Is = "RUN C PLUS PLUS"
                Anon.Speak("I will now run C plus plus.")
                Anon.SpeakAsync("This may take a few seconds")
                Shell("C:\Program Files (x86)\Dev-Cpp\devcpp.exe")

            Case Is = "RUN VISUAL BASIC PLEASE", "RUN VISUAL BASIC", "RUN VB.NET"
                Anon.SpeakAsync("I will now run visual basic")
                Anon.SpeakAsync("This may take a few seconds")
                Shell("C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\vbexpress.exe")



            Case Is = "RUN MOZILLA FIREFOX PLEASE", "RUN MOZILLA FIREFOX", "OPEN MOZILLA FIREFOX"
                Anon.SpeakAsync("I will now run mozilla firefox")
                Anon.SpeakAsync("This may take a few seconds")
                Shell("C:\Program Files (x86)\Mozilla Firefox\firefox.exe")

            Case Is = "RUN GOOGLE CHROME PLEASE", "RUN GOOGLE CHROME", "OPEN GOOGLE CHROME"
                Anon.SpeakAsync("I will now run google chrome")
                Anon.SpeakAsync("This may take a few seconds")

                Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")



            Case Is = "WHAT TIME IS IT"
                Anon.Speak(Format(Now, "Short Time"))
            Case Is = "WHAT DAY IS IT"

                Anon.SpeakAsync(DateTime.Today.ToString("dddd"))

            Case Is = "WHAT'S TODAYS DATE", "WHAT'S THE DATE"
                Anon.SpeakAsync(Format(Now, "Long Date"))

                'Case Is = "CLOSE YOURSELF NOW", "GOOD BYE"

                'Anon.Speak("Good Bye " & Name & ". Until Next Time ")
                'LogInForm.Close()

                '  Case Is = "MINIMIZE YOURSELF NOW", "MINIMIZE YOURSELF", "MINIMIZE"
                '     Anon.Speak("Okay Sir")


            Case Is = "GET OUT OF THE WAY", "GET OUT OF THE WAY JARVIS"
                Anon.Speak("My Apology")
                Me.WindowState = FormWindowState.Minimized

            Case Is = "COMEBACK"
                Anon.Speak("Here I am")
                Me.WindowState = FormWindowState.Normal



            Case Is = "RUN FACEBOOK"
                System.Diagnostics.Process.Start("http://www.facebook.com")
            Case Is = "RUN GOOGLE"
                System.Diagnostics.Process.Start("http://www.google.com")
            Case Is = "RUN YAHOO"
                System.Diagnostics.Process.Start("http://www.yahoo.com")
            Case Is = "RUN TWITTER"
                System.Diagnostics.Process.Start("http://www.twitter.com")
            Case Is = "RUN MANGA PANDA"
                System.Diagnostics.Process.Start("http://www.mangapanda.com")
            Case Is = "RUN YOUTUBE"
                System.Diagnostics.Process.Start("http://www.youtube.com")


                'Case Is = "RUN DOTA"
                'Shell("C:\Program Files (x86)\warcraft iii reign of chaos & the frozen throne\Frozen Throne.exe")


                'Case Is = "DEFINE YOURSELF"


                'Anon.Speak("")

            Case Is = "SHOW COMMANDS"
                CommandsListBox.Visible = True
                CommandsListBox.Items.Clear()

                Dim Commands() As String = System.IO.File.ReadAllLines("MyCommands.txt")

                For i As Integer = 0 To Commands.Count - 1
                    CommandsListBox.Items.Add(Commands(i))

                Next

            Case Is = "HIDE COMMANDS"

                CommandsListBox.Visible = False

            Case Is = "WHAT'S MY NAME"


                Anon.Speak(Myname)


            Case Is = "WHO ARE YOU"

                Anon.SpeakAsync("I'm Jarvis. Your Computer Digital Assistant")

            Case Is = "I'M NOT TALKING TO YOU JARVIS", "I'M NOT TALKING TO YOU"
                Anon.Speak("I'm Sorry" & Myname)
                ' Anon.SpeakAsyncCancelAll()

            Case Is = "STOP TALKING"
                Anon.SpeakAsyncCancelAll()

                Select Case Number
                    Case Is = 5

                        Anon.SpeakAsync("Fine")


                End Select
            Case Is = "PLAY MUSIC"

                QuestionEvent = "PLAY MUSIC"
                CommandsListBox.SelectionMode = SelectionMode.One
                CommandsListBox.Items.Clear()
                CommandsListBox.Visible = True
                Anon.SpeakAsync("OK")
                For Each a As String In MyMusicPaths
                    CommandsListBox.Items.Add(FileIO.FileSystem.GetName(a))
                Next

                WindowsMediaPlayer1.Visible = True

                Player.controls.play()

                Anon.SpeakAsync("Which Song?")


            Case Is = "PLAY"

                If QuestionEvent = "PLAY MUSIC" Then

                    CurrentPlaying = CommandsListBox.SelectedIndices(0)

                    WindowsMediaPlayer1.URL = MyMusicPaths(CurrentPlaying)
                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"

                End If




            Case Is = "YOU DECIDE"

                If QuestionEvent = "PLAY MUSIC" Then
                    Ran = Me.rnd.Next(0, MyMusicPaths.Count)
                    WindowsMediaPlayer1.URL = MyMusicPaths(Ran)

                    Anon.SpeakAsync(("How about " & (WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & "?")))

                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"

                End If




            Case Is = "PLAY A RANDOM SONG"

                If QuestionEvent = "PLAY MUSIC" Then
                    WindowsMediaPlayer1.Visible = True


                    Ran = Me.rnd.Next(0, MyMusicPaths.Count)
                    WindowsMediaPlayer1.URL = MyMusicPaths(Ran)
                    Anon.SpeakAsync("I hope you're in the mood for " & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString)
                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If






            Case Is = "HIDE MUSIC LIBRARY"

                CommandsListBox.Visible = False



            Case Is = "PAUSE"


                If QuestionEvent = "PLAY MUSIC" Then

                    If WindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then

                        Anon.SpeakAsync("I already pause the music " & Myname)
                        Anon.SpeakAsync("Try to play it first")
                    Else

                        WindowsMediaPlayer1.Ctlcontrols.pause()

                    End If

                    ' Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If




            Case Is = "RESUME MUSICS"
                If QuestionEvent = "PLAY MUSIC" Then

                    If WindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then

                        Anon.SpeakAsync("Music is already playing")

                    Else

                        WindowsMediaPlayer1.Ctlcontrols.play()

                    End If


                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If



            Case Is = "NEXT", "NEXT SONG"
                If QuestionEvent = "PLAY MUSIC" Then
                    '    If WindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying And WindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused AndAlso WindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
                    Ran = (Ran + 1)

                    WindowsMediaPlayer1.URL = MyMusicPaths(Ran)

                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                    '

                    'Else

                    'Anon.SpeakAsync("Play some music first")


                    'End If
                End If

            Case Is = "GO BACK", "PREVIOUS SONG"

                If QuestionEvent = "PLAY MUSIC" Then

                    Ran = (Ran - 1)

                    WindowsMediaPlayer1.URL = MyMusicPaths(Ran)
                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If



            Case Is = "FAST FORWARD"

                If QuestionEvent = "PLAY MUSIC" Then

                    WindowsMediaPlayer1.Ctlcontrols.fastForward()
                    Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString
                End If

            Case Is = "WHAT SONG IS PLAYING"

                If QuestionEvent = "PLAY MUSIC" Then
                    '  Dim currentplayingurl As String = WindowsMediaPlayer1.currentMedia.sourceURL
                    If (WindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
                        Anon.SpeakAsync(WindowsMediaPlayer1.Ctlcontrols.currentItem.name)

                    Else
                        Anon.SpeakAsync("No song is currently being played")
                    End If



                End If

            Case Is = "MUTE"

                If QuestionEvent = "PLAY MUSIC" Then
                    WindowsMediaPlayer1.settings.mute = True
                    'Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"

                End If


            Case Is = "UNMUTE"

                If QuestionEvent = "PLAY MUSIC" Then
                    WindowsMediaPlayer1.settings.mute = False
                    '  Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If


            Case Is = "STOP MUSIC"

                If QuestionEvent = "PLAY MUSIC" Then
                    WindowsMediaPlayer1.Ctlcontrols.stop()
                    WindowsMediaPlayer1.Visible = False
                    Me.Text = "                                 J.A.R.V.I.S v 1.0"


                End If




            Case Is = "TURN UP"

                If QuestionEvent = "PLAY MUSIC" Then

                    WindowsMediaPlayer1.settings.volume = WindowsMediaPlayer1.settings.volume + 10
                    ' Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If

            Case Is = "TURN DOWN"

                If QuestionEvent = "PLAY MUSIC" Then
                    WindowsMediaPlayer1.settings.volume = WindowsMediaPlayer1.settings.volume - 10
                    'Me.Text = "J.A.R.V.I.S v 1.0 (" & WindowsMediaPlayer1.Ctlcontrols.currentItem.name.ToString & ")"
                End If





                '            Case Is = "JUST A RATHER VERY INTELLIGENT SYSTEM"

                'Anon.Speak("That's me")

            Case Is = "SWITCH WINDOW"

                SendKeys.SendWait("%{TAB " & (Me.count & "}"))

                Me.count = (Me.count + 1)

            Case Is = "CLOSE WINDOW"
                SendKeys.SendWait("%{F4}")


            Case Is = "RUN TEXT TO SPEECH RECOGNITION"

                TextToSpeechRecognitionToolStripMenuItem_Click(sender, e)


            Case Is = "RUN AS BACKROUND"
                Me.Hide()

                ToolStripMenuItem1.Enabled = True

                'Case Is = "STOP LISTENING"

                'Anon.SpeakAsync("I will await further commands")

                '                AnonRecognizer.RecognizeAsyncCancel()

                'Anon.SpeakAsyncCancelAll()

                'Case Is = "START LISTENING"

                'Anon.SpeakAsync("I'm Online Now")
                'AnonRecognizer.SetInputToDefaultAudioDevice()
                'AnonRecognizer.RecognizeAsync()


                '    Case Is = "SHUTDOWN"
                '       QuestionEvent = "Shutdown"
                '      ShutdownTimer.Enabled = True
                '     LabelTimer.Visible = True

                'Case Is = "LOG OFF"
                '   QuestionEvent = "Log Off"

                'ShutdownTimer.Enabled = True
                '                LabelTimer.Visible = True


                'Case Is = "RESTART"
                '   QuestionEvent = "Restart"

                'ShutdownTimer.Enabled = True
                'LabelTimer.Visible = True

                '            Case Is = "ABORT"

                'ShutdownTimer.Enabled = False
                'LabelTimer.Visible = False





        End Select



    End Sub
    Private Sub recognizer_SpeechRecognitionRejected(ByVal sender As Object, ByVal e As SpeechRecognitionRejectedEventArgs)



    End Sub

    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated








    End Sub

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       





        ToolStripMenuItem1.Enabled = False



        Dim Intro As New Synthesis.SpeechSynthesizer
        '   If UserInfo.NameTextBox.Text = System.IO.File.ReadAllText("UserInfo.txt") Then

        'Myname = System.IO.File.ReadAllText("UserInfo.txt")
        '  Else

        ' Myname = My.Computer.Name
        Myname = System.IO.File.ReadAllText("UserInfo.txt")

        'If UserInfo.NameTextBox.Text = "" Then

        'Myname = My.Computer.Name

        'End If

        '  End If


        If Me.timenow.Hour >= 5 AndAlso Me.timenow.Hour < 12 Then

            Intro.SpeakAsync("Goodmorning" & Myname)

        End If

        If Me.timenow.Hour >= 12 AndAlso Me.timenow.Hour < 18 Then
            Intro.SpeakAsync("Good Afternoon " & Myname)

        End If


        If Me.timenow.Hour >= 18 AndAlso Me.timenow.Hour < 24 Then
            Intro.SpeakAsync("Good evening " & Myname)

        End If

        If Me.timenow.Hour < 5 Then
            Intro.SpeakAsync("Goodmorning" & Myname)

        End If


        Intro.SpeakAsync("It's currently " & Format(Now, "Short Time"))
        Intro.SpeakAsync("What is it would you like me to do first?")



        AnonRecognizer.SetInputToDefaultAudioDevice()
        Dim Grammar As New GrammarBuilder()







        Grammar.Append(New Choices(System.IO.File.ReadAllLines("MyCommands.txt")))
        'Grammars.Append(New Choices(System.IO.File.ReadAllLines("Social Commands.txt")))
        'Grammarss.Append(New Choices(System.IO.File.ReadAllLines("Social Response.txt")))

        AnonRecognizer.LoadGrammar(New Recognition.Grammar(Grammar))
        'AnonRecognizer.LoadGrammar(New Recognition.Grammar(Grammars))
        'AnonRecognizer.LoadGrammar(New Recognition.Grammar(Grammars))



        'Select Case QuestionEvent

        ' Case Is = "START LISTENNG"

        AnonRecognizer.RecognizeAsync()
        ' Case Is = "STOP LISTENING"

        'End Select



    End Sub
    Private Sub AnonRecognizer_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles AnonRecognizer.RecognizeCompleted
        AnonRecognizer.RecognizeAsync()

       
    End Sub

    Private Sub WindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsMediaPlayer1.Enter

    End Sub

    Private Sub CommandsListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandsListBox.SelectedIndexChanged

    End Sub

    Private Sub startlistening_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechRecognizedEventArgs)

        AnonRecognizer.RecognizeAsync()







    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        SettingForm.ShowDialog()



    End Sub

    Private Sub TextToSpeechRecognitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToSpeechRecognitionToolStripMenuItem.Click
        Text_To_Speech_Recognition.ShowDialog()
        AnonRecognizer.RecognizeAsyncStop()




    End Sub

    Private Sub MainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub ShutdownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownTimer.Tick
        '    LabelTimer.Text = Format(Val(LabelTimer.Text) - Val(0.01), 2)


        '   If LabelTimer.Text = 0 Then
        'ShutdownProcedure()
        '  ShutdownTimer.Enabled = False
        ' LabelTimer.Visible = False


        '  End If
    End Sub
    Sub ShutdownProcedure()

        If QuestionEvent = "Shutdown" Then
            System.Diagnostics.Process.Start("shutdown", "-s")
        ElseIf QuestionEvent = "Restart" Then
            System.Diagnostics.Process.Start("shutdown", "-r")
        ElseIf QuestionEvent = "Log Off" Then
            System.Diagnostics.Process.Start("shutdown", "-l")
        End If

    End Sub


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Me.Show()


        'AnonRecognizer.RecognizeAsync()






    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()
        '        AnonRecognizer.RecognizeAsyncCancel()

    End Sub

    Private Sub EditNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNameToolStripMenuItem.Click
        UserInfo.ShowDialog()

    End Sub
End Class
