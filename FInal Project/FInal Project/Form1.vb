Public Class frmWelcome
    Dim welcomeText() As String = IO.File.ReadAllLines("WelcomeText.txt")
    Dim quizForm As New frmQuiz

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        quizForm.Show()
        Me.Hide()

    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeText.Text = welcomeText(0) & Environment.NewLine & Environment.NewLine & welcomeText(2)
    End Sub
End Class
