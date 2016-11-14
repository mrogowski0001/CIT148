Module PublicVar
    'Declare arrays and fill arrays with questions and answers
    Public questions() As String = IO.File.ReadAllLines("Questions.txt")
    Public answers() As String = IO.File.ReadAllLines("Answers.txt")
    Public answerKeys() As String = IO.File.ReadAllLines("AnswerKey.txt")

    Public totalQuestions As Integer = questions.Count()        'This is the total number of questions in the text file

    'The rad*Check arrays hold the status of the radio buttons for each question
    Public rad1Check(questions.Count) As Boolean
    Public rad2Check(questions.Count) As Boolean
    Public rad3Check(questions.Count) As Boolean
    Public rad4Check(questions.Count) As Boolean

    'Declare varialbes to be used for the quiz
    Public exitForm As New frmExit
    Public position As Integer = 1                          'This is the number of the current question (Default is 1)
    Public qNum As String = CStr(position)                  'A string version of the current question in position above
    Public currentQuestion As String = ""
    Public correctAnswer As String                          'Variable to hold the correct answer for the current question
    Public totalCorrect As Integer = 0                     'total of correct answers
    Public totalIncorrect As Integer = 0                    'Total of incorrect answers
    Public average As Double = 0                            'The average score fofr the test based on 100%
    Public timeLeft As Integer = (totalQuestions * 20)      'calculates the total time allowed for the quiz in seconds( 20 seconds per questions)
    Public gradedAnswers(questions.Count) As String         'Variable to hold "correct" and "incorrect answers
    Public answerChecked(questions.Count) As Boolean        'Variable to hold status of checked(graded) answers
    Public questionsAnswered(questions.Count) As Integer    'Keeps a count of all answered questions to determine if there are any unanswered question qhwn the user submits the quiz
    Public bNum As Integer = 0                              'Counter for loop to determine if there is a blank answer
    Public blankAnswer As Integer                           'total of blank answers
    Public checkedCorrectCount As Integer = 0               'Total of correct answers that have been checked
    Public checkedInorrectCount As Integer = 0              'Total of incorrect answers that have been checked

    'Function to query the question text based on the current question number
    Public Function Question(qNum As String) As String
        Dim queryQ = From line In questions
                     Let quesNum = line.Split(","c)(0)
                     Let quesQ = line.Split(","c)(1)
                     Where quesNum = qNum
                     Select quesQ

        Return queryQ.First
    End Function
    'Function to query the first radio button answer text based on the current question number
    Public Function Answer1(qNum As String) As String
        Dim queryAns1 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans1 = line.Split(","c)(1)
                      Where ansNum = qNum
                      Select ans1

        Return queryAns1.First
    End Function
    'Function to query the second radio button answer text based on the current question number
    Public Function Answer2(qNum As String) As String
        Dim queryAns2 = From line In answers
                      Let ansNum = line.Split(","c)(0)
                      Let ans2 = line.Split(","c)(2)
                      Where ansNum = qNum
                      Select ans2

        Return queryAns2.First
    End Function
    'Function to query the third radio button answer text based on the current question number
    Public Function Answer3(qNum As String) As String
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
    Public Function AnswerKey(qNum As String) As String
        Dim queryAnsKey = From line In answerKeys
                      Let ansNum = line.Split(","c)(0)
                      Let correctAnswer = line.Split(","c)(1)
                      Where ansNum = qNum
                      Select correctAnswer

        Return queryAnsKey.First
    End Function
    'Function to calculate the average based on the total questions in the questions text file
    Public Function AverageScore(totalCorrect As Integer, totalQuestions As Integer) As Double
        Dim average As Double

        average = (totalCorrect / totalQuestions) * 100
        Return average

    End Function
    'Function to control the countdown timer
    Public Function GetTime(timeLeft As Integer) As String
        Dim Hrs As Double           'number of hours   '
        Dim Min As Double           'number of Minutes '
        Dim Sec As Integer          'number of Sec     '

        'Seconds'
        Sec = timeLeft Mod 60

        'Minutes'
        Min = ((timeLeft - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((timeLeft - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function

End Module
