Public Class frmWelcome

    'Declare variables for welcome text and quizForm
    Dim welcomeText() As String = IO.File.ReadAllLines("WelcomeText.txt")
    Dim quizForm As New frmQuiz

    Private Sub btnBegin_Click() Handles btnBegin.Click

        'Open the quiz form and hides the welcome form
        quizForm.Show()
        Me.Hide()

    End Sub

    Private Sub frmWelcome_Load() Handles MyBase.Load

        'Set welcome label text.
        lblWelcomeText.Text = welcomeText(0) & Environment.NewLine
        'Set instructions label text.
        lblInstructionsText.Text = welcomeText(2) & Environment.NewLine & Environment.NewLine & welcomeText(4) & Environment.NewLine & Environment.NewLine & welcomeText(6)

    End Sub

    Private Sub lblInstructionsText_Click(sender As Object, e As EventArgs) Handles lblInstructionsText.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'hides current form and shows login form
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class
