Public Class frmSummary

    Private Sub frmSummary_Load() Handles MyBase.Load

        Dim count As Integer = 0        'Declare a counter variable to get the total number of correctly answered questions to display to the user

        Do
            If gradedAnswers(count) = "Correct" Then
                totalCorrect += 1                       'adds 1 to the total of correct answers
            End If
            count += 1                                  'Adds 1 to the counter variable
        Loop Until count = totalQuestions + 1           'Stops the loop when the counter has reached the total number of questions in the quiz

        'Declare a variable to hold the summary text to display to the user to prevent haveing to have multiple instances of the same information
        Dim sumText As String = ("You correctly answered " & totalCorrect.ToString & " questions out of " & totalQuestions.ToString & ".")

        'Set summary label text
        lblTitle1.Text = "Summary"
        lblTitle2.Text = "Here are the results of your quiz."


        'Calculate the final average score using the AverageScore function located in PublicVar.vb
        average = AverageScore(totalCorrect, totalQuestions)

        'Display message box based on the average score
        If average >= 99 Then
            lblSummartText.Text = ("Woo Hoo! You're a genius! You scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        ElseIf average >= 90 Then
            lblSummartText.Text = ("Sweet!, You totaly scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        ElseIf average >= 80 Then
            lblSummartText.Text = (" Righteous! You scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        ElseIf average >= 70 Then
            lblSummartText.Text = ("Good Job! You scored " & CStr(average) & "%" & Environment.NewLine & sumText)
        Else
            lblSummartText.Text = ("You suck! You only scored a pathetic " & CStr(average) & "%" & Environment.NewLine & sumText)
        End If

        'Clear the list box before populating the list box with the results
        lstSummary.Items.Clear()

        'Get and display the answer status (correct or incorrect) next to the question text
        For i As Integer = 0 To totalQuestions - 1
            lstSummary.Items.Add(gradedAnswers(i) & vbTab & vbTab & questions(i))
            lstSummary.Items.Add("")                            'Add a space between questions to make the list easier to read
        Next

    End Sub

    Private Sub btnExitQuiz_Click() Handles btnExitQuiz.Click

        'Exit the application
        Application.Exit()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Creates a variable for the SaveFileDialog (This is not required)
        Dim saveFile As New SaveFileDialog

        'Supplies a list of formats allowed to save as when dialog is open
        saveFile.Filter = "Text Files|*.txt|Microsoft Word|.docx|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"

        'Simple title
        saveFile.Title = "Save File"

        'Shows the dialog to save file as
        saveFile.ShowDialog()
        saveFile.FileName = saveFile.FileName

        'variabale for streamwriter, to write to a txt, ect file
        Dim Write As New System.IO.StreamWriter(saveFile.FileName)

        'writes the information associated with title1
        Write.Write(lblTitle1.Text + ": ")

        'wrights the information associated with title2
        Write.Write(lblTitle2.Text + vbNewLine)

        'wrights the information associated with summarytext
        Write.Write(lblSummartText.Text + vbNewLine + vbNewLine + vbNewLine)

        'writes simple text
        Write.Write("Try Again?")

        'closes the write method
        Write.Close()




    End Sub

    Private Sub btnExitQuiz_Click(sender As Object, e As EventArgs) Handles btnExitQuiz.Click

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub

    Private Sub lstSummary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSummary.SelectedIndexChanged

    End Sub

    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click
        'Hides current form
        Me.Hide()
        'Brings back the welcome form to retake the quiz
        frmWelcome.Show()

    End Sub
End Class