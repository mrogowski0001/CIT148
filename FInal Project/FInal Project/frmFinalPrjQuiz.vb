Public Class frmQuiz

    Private Sub btnNext_Click() Handles btnNext.Click


        'Clear all radio buttons to prevent carryover from the last question
        radAns1.Checked = False
        radAns2.Checked = False
        radAns3.Checked = False
        radAns4.Checked = False

        'Disable the next button on the last question to prevent an error and ensure the back button is enabled.
        If position = totalQuestions - 1 Then
            btnNext.Enabled = False
        Else
            btnPrevious.Enabled = True
        End If

        'Adds 1 to the current position in the quiz
        position += 1
        qNum = CStr(position)

        'Disable the answer radio buttons if the answer has been checked.
        If answerChecked(position - 1) = True Then
            grpAnswers.Enabled = False
            btnCheckAnswer.Enabled = False
        Else
            grpAnswers.Enabled = True
            btnCheckAnswer.Enabled = True
        End If

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

        'Set all radio buttons if the question has been previously answered
        radAns1.Checked = rad1Check(position - 1)
        radAns2.Checked = rad2Check(position - 1)
        radAns3.Checked = rad3Check(position - 1)
        radAns4.Checked = rad4Check(position - 1)

    End Sub

    Private Sub btnPrevious_Click() Handles btnPrevious.Click

        'Disable the answer radio buttons if the answer has been checked.
        If answerChecked(position - 2) = True Then
            grpAnswers.Enabled = False
            btnCheckAnswer.Enabled = False
        Else
            grpAnswers.Enabled = True
            btnCheckAnswer.Enabled = True
        End If

        'Disable the previous question button if this is the first question
        If position = 2 Then
            btnPrevious.Enabled = False
        Else
            btnNext.Enabled = True
        End If

        'Clear all check boxes to prevent carryover from the previous question
        radAns1.Checked = False
        radAns2.Checked = False
        radAns3.Checked = False
        radAns4.Checked = False

        'Subtracts 1 from the current position in the quiz
        position -= 1
        qNum = CStr(position)

        'Set all radio buttons to stored values if applicable
        radAns1.Checked = rad1Check(position - 1)
        radAns2.Checked = rad2Check(position - 1)
        radAns3.Checked = rad3Check(position - 1)
        radAns4.Checked = rad4Check(position - 1)

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

    End Sub
    Private Sub frmQuiz_Load() Handles MyBase.Load
       
        For i As Integer = 0 To totalQuestions

            'Set all answers to not graded
            gradedAnswers(i) = "N/A"

            'Set radio button checked status for all questions to false
            rad1Check(i) = False
            rad2Check(i) = False
            rad3Check(i) = False
            rad4Check(i) = False

            'Set all answers checked and questions answered to false because no questions have been answered yet
            answerChecked(i) = False
            questionsAnswered(i) = 0
        Next

        btnPrevious.Enabled = False 'Set the back button to disabled because this is the first question
        Timer1.Interval = 1000      'Set the time interval of the countdown timer to 1000 milliseconds.
        Timer1.Enabled = True       'Enable the countdown timer to start counting down when the quiz begns.
        Timer2.Interval = 500       'Set the blink timer to 500 milliseconds (1/2 second) so the countdown timer will blink on and off every second.
        Timer2.Enabled = False      'Disable timer 2, this timer will be enabled in timer 1 when the countdown reaches 60 seconds.

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
        btnNext.Focus()

    End Sub

    Private Sub btnSubmit_Click() Handles btnSubmit.Click
        bNum = 0                                    'Set the counter to 0
        'If the question has been answered then the questionsAnswered value for the question should be 1
        'If the question has been answered then add 1 to the blankAnswer variable
        'Repeat this for all questions
        Do
            If questionsAnswered(bNum) = 1 Then
                blankAnswer += 1
            End If
            bNum += 1
        Loop Until bNum = totalQuestions

        'If there is a blank answer give the student a chance to either continue or submit the quiz
        If blankAnswer < totalQuestions Then
            frmSubmitVerify.Show()
            Me.AddOwnedForm(frmSubmitVerify)
        Else
            'If there are no blank answers disable all timers and buttons and open the summary form
            Timer1.Enabled = False
            Timer2.Enabled = False
            grpAnswers.Enabled = False
            btnPrevious.Enabled = False
            btnCheckAnswer.Enabled = False
            btnNext.Enabled = False

            frmSummary.Show()
            Me.Hide()
        End If

        'Reset blank answers to 0
        'This ensures that any answers marked blank will not be marked as blank the next time the submit button is clicked.
        blankAnswer = 0

    End Sub

    Private Sub radAns1_CheckedChanged() Handles radAns1.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 1 to true and all other radio buttons to false
        rad1Check(position - 1) = True
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False

        'Set answer to correct or incorrect
        If radAns1.Text = correctAnswer Then
            gradedAnswers(position - 1) = "Correct"
        Else
            gradedAnswers(position - 1) = "Incorrect"
        End If

        'Give focus to the next button
        btnNext.Focus()

    End Sub

    Private Sub radAns2_CheckedChanged() Handles radAns2.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = True
        rad3Check(position - 1) = False
        rad4Check(position - 1) = False

        'Set answer to correct or incorrect 
        If radAns2.Text = correctAnswer Then
            gradedAnswers(position - 1) = "Correct"
        Else
            gradedAnswers(position - 1) = "Incorrect"
        End If

        'Give focus to the next button
        btnNext.Focus()
    End Sub

    Private Sub radAns3_CheckedChanged() Handles radAns3.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = True
        rad4Check(position - 1) = False

        'Set answer to correct or incorrect 
        If radAns3.Text = correctAnswer Then
            gradedAnswers(position - 1) = "Correct"
        Else
            gradedAnswers(position - 1) = "Incorrect"
        End If

        'Give focus to the next button
       btnNext.Focus()
    End Sub

    Private Sub radAns4_CheckedChanged() Handles radAns4.CheckedChanged
        'If the radio button is selected then give focus to the  submit button
        If questionsAnswered(position - 1) = 0 Then
            questionsAnswered(position - 1) = 1
        End If

        'Set radio button 2 to true and all other radio buttons to false
        rad1Check(position - 1) = False
        rad2Check(position - 1) = False
        rad3Check(position - 1) = False
        rad4Check(position - 1) = True

        'Set answer to correct or incorrect 
        If radAns4.Text = correctAnswer Then
            gradedAnswers(position - 1) = "Correct"
        Else
            gradedAnswers(position - 1) = "Incorrect"
        End If

        'Give focus to the next button
       btnNext.Focus()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click

        'Show the exit form when the exit quiz button is clicked
        exitForm.Show()

    End Sub

    Public Sub Timer1_Tick() Handles Timer1.Tick

        If timeLeft <= 0 Then                               'Determine if time has run out
            txtTimeLeft.Text = "00:00:00"                   'Set timer text to all zeros
        Else
            txtTimeLeft.Text = GetTime(timeLeft)            'Gets the current timer if the timer has not reached zero
        End If

        'I set the timeLeft variable to be -1 so the timer would continue to blink on and off until the time reached 0
        'Otherwise the timer would stop blinking at 1 second...
        If timeLeft = -1 Then                               'Determine if the timer has reached -1 
            Timer1.Enabled = False                          'If yes then stop timer
        Else
            timeLeft -= 1                                   'Decrease timer by 1

            If timeLeft < 0 Then                            'Determine if time is less than zero 
                frmSummary.Show()                           'Show the quiz summary
                Me.Hide()                                   'Hide the quiz form
                btnSubmit.Enabled = False                   'Disable the submit button
                Timer2.Enabled = False                      'Disable timer2
                txtTimeLeft.Visible = True                  'Ensure the final time is visible
                txtTimeLeft.ForeColor = Color.Red           'Keep time color red
            ElseIf timeLeft < 60 Then                       'Determine if time left is less than 60 seconds
                Timer2.Enabled = True                       'Enable timer2 (blinking)
                txtTimeLeft.ForeColor = Color.Red           'Set text forcolor to red
            End If
        End If
    End Sub

    Public Sub Timer2_Tick() Handles Timer2.Tick

        'This timer is used to make the timer start blinking when the timer has 60 seconds or less remaining.
        If timeLeft < 60 Then                               'Determine if the time left is 60 seconds or less
            If txtTimeLeft.Visible = True Then              'If yes, then determine if the timetext is visible
                txtTimeLeft.Visible = False                 'If yes, then set as false
            ElseIf txtTimeLeft.Visible = False Then         'If the timer is not visible
                txtTimeLeft.Visible = True                  'Set timer visibility to true
            End If
        End If
    End Sub

    Private Sub btnCheckAnswer_Click() Handles btnCheckAnswer.Click

        'Determine which radio button is checked then 
        'Set add one to correct or incorrect count to display in the window and display a message box
        If radAns1.Checked = True Then
            If radAns1.Text = correctAnswer Then
                checkedCorrectCount += 1
                txtCorrectAnswers.Text = checkedCorrectCount.ToString
                MessageBox.Show("Correct", "Correct")
            Else
                checkedInorrectCount += 1
                txtIncorrectAnswers.Text = checkedInorrectCount.ToString
                MessageBox.Show("Incorrect, the correect answer is:" & correctAnswer, "Incorrect")
            End If
            grpAnswers.Enabled = False              'Disable radio buttons for the current answer to prevent changes after grading
            answerChecked(position - 1) = True      'Indicate that this answer has been checked (for next and back button use)
            btnCheckAnswer.Enabled = False          'Disable the check answer button for current question (for next and back button use)

        ElseIf radAns2.Checked = True Then
            If radAns2.Text = correctAnswer Then
                checkedCorrectCount += 1
                txtCorrectAnswers.Text = checkedCorrectCount.ToString
                MessageBox.Show("Correct", "Correct")
            Else
                checkedInorrectCount += 1
                txtIncorrectAnswers.Text = checkedInorrectCount.ToString
                MessageBox.Show("Incorrect, the correect answer is:" & correctAnswer, "Incorrect")
            End If
            grpAnswers.Enabled = False              'Disable radio buttons for the current answer to prevent changes after grading
            answerChecked(position - 1) = True      'Indicate that this answer has been checked (for next and back button use)
            btnCheckAnswer.Enabled = False          'Disable the check answer button for current question (for next and back button use)

        ElseIf radAns3.Checked = True Then
            If radAns3.Text = correctAnswer Then
                checkedCorrectCount += 1
                txtCorrectAnswers.Text = checkedCorrectCount.ToString
                MessageBox.Show("Correct", "Correct")
            Else
                checkedInorrectCount += 1
                txtIncorrectAnswers.Text = checkedInorrectCount.ToString
                MessageBox.Show("Incorrect, the correect answer is:" & correctAnswer, "Incorrect")
            End If
            grpAnswers.Enabled = False              'Disable radio buttons for the current answer to prevent changes after grading
            answerChecked(position - 1) = True      'Indicate that this answer has been checked (for next and back button use)
            btnCheckAnswer.Enabled = False          'Disable the check answer button for current question (for next and back button use)

        ElseIf radAns4.Checked = True Then
            If radAns4.Text = correctAnswer Then
                checkedCorrectCount += 1
                txtCorrectAnswers.Text = checkedCorrectCount.ToString
                MessageBox.Show("Correct", "Correct")
            Else
                checkedInorrectCount += 1
                txtIncorrectAnswers.Text = checkedInorrectCount.ToString
                MessageBox.Show("Incorrect, the correect answer is:" & correctAnswer, "Incorrect")
            End If
            grpAnswers.Enabled = False              'Disable radio buttons for the current answer to prevent changes after grading
            answerChecked(position - 1) = True      'Indicate that this answer has been checked (for next and back button use)
            btnCheckAnswer.Enabled = False          'Disable the check answer button for current question (for next and back button use)

        Else
            'If no answer has been checked show a message box to indicate the user must select an answer before grading.
            MessageBox.Show("You must select an answer before you can check the answer.", "Error")
        End If

    End Sub

    Private Sub lblQuestion_Click(sender As Object, e As EventArgs) Handles lblQuestion.Click

    End Sub
End Class