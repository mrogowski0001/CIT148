Public Class frmForgotPassword
    'use new var for settings
    Dim setting As New My.MySettings()
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim user, q1, q2 As Boolean
        'if text from txt boxes mach what is in stored username proceed else throw msgbox
        If (txtUserName.Text = setting.saveUser) Then
            user = True
        Else : user = False
        End If
        'if securtyquestion answered correctly then contenu else throw msgbox
        If txtsecurityq1.Text = setting.whereBorn Or txtsecurityq1.Text = setting.mothersName Or txtsecurityq1.Text = setting.firstCar Then
            q1 = True
        Else : q1 = False
        End If
        'if securtyquestion answered correctly then contenu else throw msgbox
        If txtsecurityq2.Text = setting.firstDog Or txtsecurityq2.Text = setting.favoritDrink Then
            q2 = True
        Else : q2 = False
        End If

        'if everything passes proceed to next form
        If user And q2 = True Then
            Me.Hide()
            'frmChangePass.Show()

        ElseIf user = False Then
            MsgBox("Wrong UserName", MsgBoxStyle.OkOnly)
        ElseIf q1 = False Then
            MsgBox("Wrong answer to question 1", MsgBoxStyle.OkOnly)
        ElseIf q2 = False Then
            MsgBox("Wrong answer to question 2", MsgBoxStyle.OkOnly)



        End If





    End Sub

    Private Sub btnForgotUserName_Click(sender As Object, e As EventArgs) Handles btnForgotUserName.Click

    End Sub

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class