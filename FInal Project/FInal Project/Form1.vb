Public Class frmQuiz

    Dim numCorrect As Integer = 0
    Dim questions() As String = IO.File.ReadAllLines("Questions.txt")
    Dim answers() As String = IO.File.ReadAllLines("Answers.txt")
    Dim answerKeys() As String = IO.File.ReadAllLines("AnswerKey.txt")

    Dim position As Integer = 1
    Dim totalQuestions As Integer = questions.Count()
    Dim qNum As String = CStr(position)
    Dim currentQuestion As String = ""
    Dim correctAnswer As String
    Dim totalCorrect As Integer = 0
    Dim totalIncorrect As Integer = 0
    Dim average As Double = 0
    Dim ans_1 As Boolean = False
    Dim ans_2 As Boolean = False
    Dim ans_3 As Boolean = False
    Dim ans_4 As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        position += 1
        qNum = CStr(position)

        radAns1.Checked = False
        radAns2.Checked = False
        radAns3.Checked = False
        radAns4.Checked = False

        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        lblQuestion.Text = Question(qNum)

        radAns1.Text = Answer1(qNum)
        radAns2.Text = Answer2(qNum)
        radAns3.Text = Answer3(qNum)
        radAns4.Text = Answer4(qNum)

        correctAnswer = AnswerKey(qNum)

        If position = totalQuestions Then
            btnNext.Enabled = False
            btnSubmit.Enabled = True
            btnEnd.Enabled = False
            btnSubmit.Focus()
        Else
            btnSubmit.Enabled = True
            btnNext.Enabled = False
            btnSubmit.Focus()
        End If





    End Sub

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        btnBegin.Visible = False
        lblTitle.Visible = True
        lblQuestion.Visible = True
        grpAnswers.Visible = True
        btnNext.Visible = True
        btnNext.Enabled = False
        btnSubmit.Visible = True
        lblCorrectAns.Visible = True
        txtCorrectAns.Visible = True
        lblIncorrectAns.Visible = True
        txtIncorrectAns.Visible = True
        btnEnd.Visible = True
        btnEnd.Enabled = False
        btnSubmit.Focus()


        lblTitle.Text = ("Question " & position & " of " & totalQuestions & ":")

        lblQuestion.Text = Question(qNum)

        radAns1.Text = Answer1(qNum)
        radAns2.Text = Answer2(qNum)
        radAns3.Text = Answer3(qNum)
        radAns4.Text = Answer4(qNum)

        correctAnswer = AnswerKey(qNum)


    End Sub

    Function Question(qNum As String) As String
        Dim queryQ = From line In questions
                     Let quesNum = line.Split(","c)(0)
                     Let quesQ = line.Split(","c)(1)
                     Where quesNum = qNum
                     Select quesQ

        Return queryQ.First
    End Function

    Function Answer1(qNum As String) As String
        Dim queryAns1 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans1 = line.Split(","c)(1)
                      Where ansNum = qNum
                      Select ans1

        Return queryAns1.First
    End Function

    Function Answer2(qNum As String) As String
        Dim queryAns2 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans2 = line.Split(","c)(2)
                      Where ansNum = qNum
                      Select ans2

        Return queryAns2.First
    End Function

    Function Answer3(qNum As String) As String
        Dim queryAns3 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans3 = line.Split(","c)(3)
                      Where ansNum = qNum
                      Select ans3

        Return queryAns3.First
    End Function

    Function Answer4(qNum As String) As String
        Dim queryAns4 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans4 = line.Split(","c)(4)
                      Where ansNum = qNum
                      Select ans4

        Return queryAns4.First
    End Function

    Function AnswerKey(qNum As String) As String
        Dim queryAnsKey = From line In answerKeys
                      Let ansNum = line.Split(","c)(0)
                      Let correctAnswer = line.Split(","c)(1)
                      Where ansNum = qNum
                      Select correctAnswer

        Return queryAnsKey.First
    End Function

    Function AverageScore(totalCorrect As Integer, totalQuestions As Integer) As Double
        Dim average As Double

        average = (totalCorrect / totalQuestions) * 100
        Return average

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If radAns1.Checked = True Then
            If radAns1.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
            Else
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
            End If
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnEnd.Enabled = True
            Else
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If
        ElseIf radAns2.Checked = True Then
            If radAns2.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
            Else
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
            End If
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnEnd.Enabled = True
            Else
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If
        ElseIf radAns3.Checked = True Then
            If radAns3.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
            Else
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
            End If
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnEnd.Enabled = True
            Else
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If
        ElseIf radAns4.Checked = True Then
            If radAns4.Text = correctAnswer Then
                totalCorrect += 1
                txtCorrectAns.Text = totalCorrect.ToString()
            Else
                totalIncorrect += 1
                txtIncorrectAns.Text = totalIncorrect.ToString()
            End If
            If position = totalQuestions Then
                btnSubmit.Enabled = False
                btnEnd.Enabled = True
            Else
                btnNext.Enabled = True
                btnSubmit.Enabled = False
            End If
        Else
            MessageBox.Show("Please select an answer from the answerbox above.", "Error")
            btnNext.Enabled = False
            btnSubmit.Enabled = True
        End If
        average = AverageScore(totalCorrect, totalQuestions)
        If position = totalQuestions Then
            btnEnd.Focus()
        Else
            btnNext.Focus()
        End If


    End Sub


    
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        average = AverageScore(totalCorrect, totalQuestions)
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

        Me.Close()

    End Sub

    Private Sub radAns1_CheckedChanged(sender As Object, e As EventArgs) Handles radAns1.CheckedChanged
        btnSubmit.Focus()
    End Sub

    Private Sub radAns2_CheckedChanged(sender As Object, e As EventArgs) Handles radAns2.CheckedChanged
        btnSubmit.Focus()
    End Sub

    Private Sub radAns3_CheckedChanged(sender As Object, e As EventArgs) Handles radAns3.CheckedChanged
        btnSubmit.Focus()
    End Sub

    Private Sub radAns4_CheckedChanged(sender As Object, e As EventArgs) Handles radAns4.CheckedChanged
        btnSubmit.Focus()
    End Sub
End Class
