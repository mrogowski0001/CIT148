Public Class frmAuthChangePass
    Dim setting As New My.MySettings()
    Private Sub lblCurrentPass_Click(sender As Object, e As EventArgs) Handles lblCurrentPass.Click

    End Sub

    Private Sub txtNewPass_textchanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        If txtNewPass.Text <> "" And txtNewPass.TextLength >= 4 Then
            chkNewPass.Enabled = True
            chkNewPass.CheckState = CheckState.Checked
        Else : chkNewPass.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub txtConfirmPass_textchanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If txtConfirmPass.Text = txtNewPass.Text Then
            chkConfirmPass.Enabled = True
            chkConfirmPass.CheckState = CheckState.Checked
        Else : chkConfirmPass.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cp As Boolean
        Dim np As String = txtNewPass.Text
        Dim cnp As String = txtConfirmPass.Text

        'if current password, new password, and confirmed new password = true 
        'then change password
        If txtCurrentPass.Text = setting.savePassword Then
            cp = True
        Else : cp = False
            MsgBox("Current Password Incorrect", MsgBoxStyle.Critical)
        End If

        If np = cnp And np > "" And cnp > "" And cp = True Then
            setting.savePassword = np
            setting.Save()
            MsgBox("Password Changed Successfully", MsgBoxStyle.OkOnly)
            Me.Hide()
            frmLogin.Show()

        Else
            MsgBox("Passwords do not match!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frmAuthChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class