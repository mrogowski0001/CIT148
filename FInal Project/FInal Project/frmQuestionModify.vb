Public Class frmQuestionModify

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmModify.Show()
        Me.Close()
    End Sub

    Private Sub frmQuestionModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBeforeChangeQ.Items.Clear()
        lstBeforeChangeA.Items.Clear()
        'populates the lst from the selected index 
        lstBeforeChangeQ.Items.Add(frmModify.lstCurrentQuestions.Text)

        Dim linesA() As String = System.IO.File.ReadAllLines("Answers.txt")

        lstBeforeChangeA.Items.Add(linesA(frmModify.lstCurrentQuestions.SelectedIndex))

        'uses the selected index to fill in the txtModifiedQ text field with the question number
        'being modified to keep the indexes correct.
        Dim tm As Integer = frmModify.lstCurrentQuestions.SelectedIndex + 1
        txtModifiedQ.Text = tm.ToString + ", "
        txtModifiedA.Text = tm.ToString + ", "

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Reads all lines in the txt file
        Dim linesQ() As String = System.IO.File.ReadAllLines("Questions.txt")
        Dim linesA() As String = System.IO.File.ReadAllLines("Answers.txt")


        'match this index of selected question with the index of in answers.txt 
        'modify to new answers
        Try
            linesQ(frmModify.lstCurrentQuestions.SelectedIndex) = txtModifiedQ.Text

            System.IO.File.WriteAllLines("Questions.txt", linesQ)

        Catch ex As Exception
            MsgBox("Exception" & vbCrLf & ex.Message)
        End Try


        Try
            linesA(frmModify.lstCurrentQuestions.SelectedIndex) = txtModifiedA.Text

            System.IO.File.WriteAllLines("Answers.txt", linesA)

            MsgBox("Saved Successfull", MsgBoxStyle.OkOnly)

            frmModify.Close()
            frmModify.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("Exception" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub lstBeforeChangeQ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBeforeChangeQ.SelectedIndexChanged

    End Sub
End Class