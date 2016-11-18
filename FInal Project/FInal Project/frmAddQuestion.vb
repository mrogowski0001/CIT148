Imports System
Imports System.IO
Public Class frmAddQuestion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'write new question, possible answers and correct answer to the respecting files into the next index
        Try
            Using nq As StreamWriter = File.AppendText("Questions.txt")
                nq.WriteLine(txtNewQuestion.Text)
            End Using
            Using na As StreamWriter = File.AppendText("Answers.txt")
                na.WriteLine(txtNewAnswer.Text)
            End Using
            Using nca As StreamWriter = File.AppendText("AnswerKey.txt")
                nca.WriteLine(txtCorrectAnswer.Text)
            End Using
            MsgBox("Question Submitted Successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmAddQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reads files and populates the txtboxes with the correct next question number with respect to their index
        Dim linesQ() As String = System.IO.File.ReadAllLines("Questions.txt")
        Dim linesA() As String = System.IO.File.ReadAllLines("Answers.txt")
        Dim linesAk() As String = System.IO.File.ReadAllLines("AnswerKey.txt")

        txtNewQuestion.Text = CStr(linesQ.Count + 1) + ", "
        txtNewAnswer.Text = CStr(linesA.Count + 1) + ", "
        txtCorrectAnswer.Text = CStr(linesAk.Count + 1) + ", "

    End Sub
End Class