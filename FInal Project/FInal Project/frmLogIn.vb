Public Class frmLogin
    'use new var for settings
    Dim setting As New My.MySettings()

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmWelcome.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim user, pass As Boolean

        'if text from txt boxes mach what is in stored username and password proceed else throw msgbox
        If txtUserName.Text = setting.saveUser Then
            user = True
        Else : user = False
        End If

        If txtPassword.Text = setting.savePassword Then
            pass = True
        Else : pass = False
        End If

        If user = False Then
            MsgBox("Invalid Credentials", MsgBoxStyle.OkOnly)
        End If
        If pass = False Then
            MsgBox("Invalid Credentials", MsgBoxStyle.OkOnly)
        End If

        If user And pass = True And chkCurrentPass.Checked = True Then
            frmAuthChangePass.Show()
            Me.Close()
        ElseIf user And pass = True Then
            frmModify.Show()
            Me.Close()
        End If






    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        'hides current form and shows forgot password form
        Me.Hide()
        frmForgotPassword.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class