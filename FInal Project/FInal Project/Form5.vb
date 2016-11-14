Public Class frmLogin
    'use new var for settings
    Dim setting As New My.MySettings()

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmWelcome.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'if text from txt boxes mach what is in stored username and password proceed else throw msgbox
        If txtUserName.Text = setting.saveUser Then
            If txtPassword.Text = setting.savePassword Then
                MsgBox("Welcome", MsgBoxStyle.OkOnly)
                'hides current form and shows modify form
                Me.Hide()
                'frmModify.Show()
            Else
                MsgBox("Invalid Password", MsgBoxStyle.OkOnly)
            End If
        Else
            MsgBox("Invalid UserName", MsgBoxStyle.OkOnly)
        End If



    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        'hides current form and shows forgot password form
        Me.Hide()
        frmForgotPassword.Show()
    End Sub
End Class