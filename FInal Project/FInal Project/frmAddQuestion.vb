Public Class frmAddQuestion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub frmAddQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim linesQ() As String = System.IO.File.ReadAllLines("Questions.txt")
        Dim index As String = linesQ(+1).Last


        'txtNewQuestion.Text = linesQ(+1).Last

    End Sub
End Class