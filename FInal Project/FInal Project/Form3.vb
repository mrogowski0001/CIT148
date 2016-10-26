Public Class frmExit

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Application.Exit()
    End Sub

    Private Sub frmExit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNo.Focus()
    End Sub
End Class