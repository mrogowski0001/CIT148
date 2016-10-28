Public Class frmQuiz

    'Declare arrays and fill arrays with questions and answers
    Dim questions() As String = IO.File.ReadAllLines("Questions.txt")
    Dim answers() As String = IO.File.ReadAllLines("Answers.txt")
    Dim answerKeys() As String = IO.File.ReadAllLines("AnswerKey.txt")

    'Declare varialbes to be used for the quiz
    Dim exitForm As New frmExit
    Dim numCorrect As Integer = 0
    Dim position As Integer = 1
    Dim totalQuestions As Integer = questions.Count()
    Dim qNum As String = CStr(position)
    Dim currentQuestion As String = ""
    Dim correctAnswer As String
    Dim totalCorrect As Integer = 0
    Dim totalIncorrect As Integer = 0
    Dim average As Double = 0



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Adds 1 to the current position in the quiz
        position += 1
        qNum = CStr(position)

        'Clear all radio buttons
        radAns1.Checked = False
        radAns2.Checked = False
        radAns3.Checked = False
        radAns4.Checked = False

        'Set title text based on question number (position)
        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        'Set question text based on question number (position)
        lblQuestion.Text = Question(qNum)

        'Set radio button answer text based on question number (position)
        radAns1.Text = Answer1(qNum)
        radAns2.Text = Answer2(qNum)
        radAns3.Text = Answer3(qNum)
        radAns4.Text = Answer4(qNum)

        'Set the correct answer to the correct answer based on question number (position)
        correctAnswer = AnswerKey(qNum)

        'Set button enabled properties based on question position
        If position = totalQuestions Then
            btnNext.Enabled = False
            btnSubmit.Enabled = True
            btnGetResults.Enabled = False
            btnSubmit.Focus()
        Else
            btnSubmit.Enabled = True
            btnNext.Enabled = False
            btnSubmit.Focus()
        End If

    End Sub
    Private Sub frmQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the title based on the first question 
        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        'Sets the question text based on the first question 
        lblQuestion.Text = Question(qNum)

        'Sets the radio button answers text based on the first question 
        radAns1.Text = Answer1(qNum)
        radAns2.Text = Answer2(qNum)
        radAns3.Text = Answer3(qNum)
        radAns4.Text = Answer4(qNum)

        'Sets the correct answer based on the first question
        correctAnswer = AnswerKey(qNum)

    End Sub
    'Function to query the question text based on the current question number
    Function Question(qNum As String) As String
        Dim queryQ = From line In questions
                     Let quesNum = line.Split(","c)(0)
                     Let quesQ = line.Split(","c)(1)
                     Where quesNum = qNum
                     Select quesQ

        Return queryQ.First
    End Function
    'Function to query the first radio button answer text based on the current question number
    Function Answer1(qNum As String) As String
        Dim queryAns1 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans1 = line.Split(","c)(1)
                      Where ansNum = qNum
                      Select ans1

        Return queryAns1.First
    End Function
    'Function to query the second radio button answer text based on the current question number
    Function Answer2(qNum As String) As String
        Dim queryAns2 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans2 = line.Split(","c)(2)
                      Where ansNum = qNum
                      Select ans2

        Return queryAns2.First
    End Function
    'Function to query the third radio button answer text based on the current question number
    Function Answer3(qNum As String) As String
        Dim queryAns3 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans3 = line.Split(","c)(3)
                      Where ansNum = qNum
                      Select ans3

        Return queryAns3.First
    End Function
    'Function to query the fourth radio button answer text based on the current question number
    Function Answer4(qNum As String) As String
        Dim queryAns4 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans4 = line.Split(","c)(4)
                      Where ansNum = qNum
                      Select ans4

        Return queryAns4.First
    End Function
    'Function to query the correct answer based on the current question number
    Function AnswerKey(qNum As String) As String
        Dim queryAnsKey = From line In answerKeys
                      Let ansNum = line.Split(","c)(0)
                      Let correctAnswer = line.Split(","c)(1)
                      Where ansNum = qNum
                      Select correctAnswer

        Return queryAnsKey.First
    End Function
    'Function to calculate the average based on the total questions in the questions text file
    Function AverageScore(totalCorrect As Integer, totalQuestions As Integer) As Double
        Dim average As Double

        average = (totalCorrect / totalQuestions) * 100
        Return average

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'If radio button 1 in checked 
        If radAns1.Checked = True Then
            'If radio button 1 is the correct answer add 1 to totalCorrect, display total correct answers and display message box
            If radAns1.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
                MessageBox.Show("You are correct!", "Correct!")
            Else
                'If radio button 1 is the incorrect answer add 1 to totalIncorrect, display total incorrect answers and display message box
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
                MessageBox.Show("Sorry, that is not the correct answer. The correct answer is," & correctAnswer & ".", "Incorrect!")
            End If
            'If this is the last question then disable the submit button and enable the GetResults button
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnGetResults.Enabled = True
            Else
                'If this is not the last question enable the Next button and disable the submit button until the next button is clicked to prevent errors
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If

            'If radio button 2 in checked 
        ElseIf radAns2.Checked = True Then
            'If radio button 2 is the correct answer add 1 to totalCorrect, display total correct answers and display message box
            If radAns2.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
                MessageBox.Show("You are correct!", "Correct!")
            Else
                'If radio button 2 is the incorrect answer add 1 to totalIncorrect, display total incorrect answers and display message box
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
                MessageBox.Show("Sorry, that is not the correct answer. The correct answer is," & correctAnswer & ".", "Incorrect!")
            End If
            'If this is the last question then disable the submit button and enable the GetResults button
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnGetResults.Enabled = True
            Else
                'If this is not the last question enable the Next button and disable the submit button until the next button is clicked to prevent errors
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If

            'If radio button 3 in checked 
        ElseIf radAns3.Checked = True Then
            'If radio button 3 is the correct answer add 1 to totalCorrect, display total correct answers and display message box
            If radAns3.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
                MessageBox.Show("You are correct!", "Correct!")
            Else
                'If radio button 3 is the incorrect answer add 1 to totalIncorrect, display total incorrect answers and display message box
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
                MessageBox.Show("Sorry, that is not the correct answer. The correct answer is," & correctAnswer & ".", "Incorrect!")
            End If
            'If this is the last question then disable the submit button and enable the GetResults button
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnGetResults.Enabled = True
            Else
                'If this is not the last question enable the Next button and disable the submit button until the next button is clicked to prevent errors
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If

            'If radio button 4 in checked 
        ElseIf radAns4.Checked = True Then
            'If radio button 4 is the correct answer add 1 to totalCorrect, display total correct answers and display message box
            If radAns4.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
                MessageBox.Show("You are correct!", "Correct!")
            Else
                'If radio button 4 is the incorrect answer add 1 to totalIncorrect, display total incorrect answers and display message box
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
                MessageBox.Show("Sorry, that is not the correct answer. The correct answer is," & correctAnswer & ".", "Incorrect!")
            End If
            'If this is the last question then disable the submit button and enable the GetResults button
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnGetResults.Enabled = True
            Else
                'If this is not the last question enable the Next button and disable the submit button until the next button is clicked to prevent errors
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If
        Else
            'If no radio button is checked disable the next button until an answer is selected
            MessageBox.Show("Please select an answer from the answerbox above.", "Error")
            btnNext.Enabled = False
            btnSubmit.Enabled = True
        End If
        'Calculate the average score based on the total correct answers from the total questions
        average = AverageScore(totalCorrect, totalQuestions)

        'Give the results button focus if the submit button is clicked on the last question
        If position = totalQuestions Then
            btnGetResults.Focus()
        Else
            'If the question is not the last question then gove focus to the next button
            btnNext.Focus()
        End If

    End Sub

    Private Sub btnGetResults_Click(sender As Object, e As EventArgs) Handles btnGetResults.Click
        'Calculate the final average score
        average = AverageScore(totalCorrect, totalQuestions)
        'Display message box based on the average score
        If average >= 99 Then
            MessageBox.Show("Woo Hoo! You're a genius! You scored " & CStr(average) & "%")
        ElseIf average >= 90 Then
            MessageBox.Show("Sweet!, You totaly scored " & CStr(average) & "%")
        ElseIf average >= 80 Then
            MessageBox.Show(" Righteous! You scored " & CStr(average) & "%")
        ElseIf average >= 70 Then
            MessageBox.Show("Good Job! You scored " & CStr(average) & "%")
        Else
            MessageBox.Show("You suck! You only scored a pathetic " & CStr(average) & "%")
        End If

    End Sub

    Private Sub radAns1_CheckedChanged(sender As Object, e As EventArgs) Handles radAns1.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        btnSubmit.Focus()
    End Sub

    Private Sub radAns2_CheckedChanged(sender As Object, e As EventArgs) Handles radAns2.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        btnSubmit.Focus()
    End Sub

    Private Sub radAns3_CheckedChanged(sender As Object, e As EventArgs) Handles radAns3.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        btnSubmit.Focus()
    End Sub

    Private Sub radAns4_CheckedChanged(sender As Object, e As EventArgs) Handles radAns4.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        btnSubmit.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Show the exit form when the exit quiz button is clicked
        exitForm.Show()
    End Sub

End Class