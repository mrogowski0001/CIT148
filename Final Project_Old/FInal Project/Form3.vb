Public Class frmExit

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        'Hides the exit form 
        Me.Hide()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'Exits the application
        Application.Exit()
    End Sub

End Class