Imports System.Speech
Imports System.Speech.Recognition



Public Class CalculatorForm



    Dim WithEvents Calculatorrecognizer As New SpeechRecognitionEngine


    Sub New()


        ' This call is required by the designer.
        InitializeComponent()
        AddHandler Calculatorrecognizer.SpeechRecognized, AddressOf CalcRecognizer_SpeechRecognized


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CalcRecognizer_SpeechRecognized(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)
        Dim mycalc As New Synthesis.SpeechSynthesizer

        Select Case e.Result.Text.ToUpper

            Case Is = "ONE"


                Number1Button_Click(sender, e)



            Case Is = "TWO"
                Number2Button_Click(sender, e)
                mycalc.Speak("")
            Case Is = "THREE"
                Number3Button_Click(sender, e)

            Case Is = "FOUR"
                Number4Button_Click(sender, e)

            Case Is = "FIVE"
                Number5Button_Click(sender, e)
            Case Is = "SIX"
                Number6Button_Click(sender, e)
            Case Is = "SEVEN"
                Number7Button_Click(sender, e)
            Case Is = "EIGHT"
                Number8Button_Click(sender, e)
            Case Is = "NINE"
                n9_Click(sender, e)
            Case Is = "ZERO"
                n0_Click(sender, e)
            Case Is = "EQUAL"
                EqualButton_Click(sender, e)

            Case Is = "PLUS"
                AddButton_Click(sender, e)

            Case Is = "MINUS"
                SubtractButton_Click(sender, e)

            Case Is = "TIMES"
                MutiplyButton_Click(sender, e)

            Case Is = "DEVIDED BY"
                DevideButton_Click(sender, e)

            Case Is = "CLEAR"
                ClearButton_Click(sender, e)



        End Select



    End Sub
    Dim FirstNumber As Decimal
    Dim Operation As String
    Private Sub Number1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then

            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text & "1"
        End If
    End Sub

    Private Sub Number2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text & "2"
        End If
    End Sub
    Private Sub Number3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = TextBox1.Text & "3"
        End If
    End Sub

    Private Sub Number4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text & "4"
        End If
    End Sub
    Private Sub Number5Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text & "5"
        End If
    End Sub

    Private Sub Number6Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text & "6"
        End If
    End Sub
    Private Sub Number7Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text & "7"
        End If
    End Sub
    Private Sub Number8Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text & "8"
        End If
    End Sub

    Private Sub n9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text & "9"
        End If
    End Sub
    Private Sub n0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text & "0"
        End If

    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = "0"
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FirstNumber = TextBox1.Text
        TextBox1.Text = 0



        Operation = "+"
    End Sub
    Private Sub SubtractButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FirstNumber = TextBox1.Text
        TextBox1.Text = 0

        Operation = "-"
    End Sub
    Private Sub MutiplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FirstNumber = TextBox1.Text
        TextBox1.Text = 0
        Operation = "*"
    End Sub

    Private Sub DevideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FirstNumber = TextBox1.Text
        TextBox1.Text = 0
        Operation = "/"
    End Sub

    Private Sub EqualButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SecondNumber As Decimal
        Dim Result As Decimal

        Try



            SecondNumber = Decimal.Parse(TextBox1.Text)
            If Operation = "+" Then
                Result = FirstNumber + SecondNumber
            ElseIf Operation = "-" Then
                Result = FirstNumber - SecondNumber
            ElseIf Operation = "*" Then
                Result = FirstNumber * SecondNumber
            ElseIf Operation = "/" Then
                Result = FirstNumber / SecondNumber
            End If
            FirstNumber = Result
            TextBox1.Text = Result

        Catch LCD As ArithmeticException


            MessageBox.Show("You can't devide it by zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CalculatorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calculatorrecognizer.SetInputToDefaultAudioDevice()

        Dim Grammar As New GrammarBuilder()
        Grammar.Append(New Choices(System.IO.File.ReadAllLines("Calculator Commands.txt")))

        Calculatorrecognizer.LoadGrammar(New Recognition.Grammar(Grammar))


        Calculatorrecognizer.RecognizeAsync()
    End Sub

    Private Sub CalculatorRecognizer_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles Calculatorrecognizer.RecognizeCompleted
        Calculatorrecognizer.RecognizeAsync()

    End Sub
End Class