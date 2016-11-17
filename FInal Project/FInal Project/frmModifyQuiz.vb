Public Class frmModify

    Private Sub lstCurrentQuestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCurrentQuestions.SelectedIndexChanged

       


    End Sub

    Private Sub frmModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCurrentQuestions.Items.Clear()

        'Read txt file and populate lstbox with array of questions
            Dim q() As String = IO.File.ReadAllLines("Questions.txt")
            For Each line In q
                lstCurrentQuestions.Items.Add(line)

            Next

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        'Check to see if selected list item is index 0 
        'if not selected becomes index 0
        If lstCurrentQuestions.TopIndex <> lstCurrentQuestions.SelectedIndex Then

            lstCurrentQuestions.TopIndex = lstCurrentQuestions.SelectedIndex

        End If

        Me.Hide()
        frmQuestionModify.Show()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmWelcome.Show()
        Me.Close()
    End Sub
End Class