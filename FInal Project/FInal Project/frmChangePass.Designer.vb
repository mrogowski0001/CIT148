<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
    Inherits System.Windows.Forms.Form
    Dim setting As New My.MySettings()

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtConfirmPass = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewPass = New System.Windows.Forms.MaskedTextBox()
        Me.chkNewPass = New System.Windows.Forms.CheckBox()
        Me.chkConfirmPass = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(30, 34)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(81, 13)
        Me.lblNewPass.TabIndex = 0
        Me.lblNewPass.Text = "New Password:"
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Location = New System.Drawing.Point(14, 81)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(97, 13)
        Me.lblConfirmPass.TabIndex = 1
        Me.lblConfirmPass.Text = "ReType Password:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(48, 142)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(91, 25)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(243, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 25)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(142, 78)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(192, 20)
        Me.txtConfirmPass.TabIndex = 2
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(142, 31)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(192, 20)
        Me.txtNewPass.TabIndex = 1
        '
        'chkNewPass
        '
        Me.chkNewPass.AutoSize = True
        Me.chkNewPass.Checked = Global.FInal_Project.My.MySettings.Default.chkNewPass
        Me.chkNewPass.Enabled = False
        Me.chkNewPass.ForeColor = System.Drawing.Color.DarkRed
        Me.chkNewPass.Location = New System.Drawing.Point(340, 34)
        Me.chkNewPass.Name = "chkNewPass"
        Me.chkNewPass.Size = New System.Drawing.Size(15, 14)
        Me.chkNewPass.TabIndex = 0
        Me.chkNewPass.TabStop = False
        Me.chkNewPass.UseCompatibleTextRendering = True
        Me.chkNewPass.UseVisualStyleBackColor = True
        '
        'chkConfirmPass
        '
        Me.chkConfirmPass.AutoSize = True
        Me.chkConfirmPass.Enabled = False
        Me.chkConfirmPass.ForeColor = System.Drawing.Color.DarkRed
        Me.chkConfirmPass.Location = New System.Drawing.Point(340, 81)
        Me.chkConfirmPass.Name = "chkConfirmPass"
        Me.chkConfirmPass.Size = New System.Drawing.Size(15, 14)
        Me.chkConfirmPass.TabIndex = 0
        Me.chkConfirmPass.TabStop = False
        Me.chkConfirmPass.UseVisualStyleBackColor = True
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 183)
        Me.Controls.Add(Me.chkConfirmPass)
        Me.Controls.Add(Me.chkNewPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.lblNewPass)
        Me.Name = "frmChangePass"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
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
        'Dim cp As Boolean
        Dim np As String = txtNewPass.Text
        Dim cnp As String = txtConfirmPass.Text

        'If txtCurrentPass.Text = setting.savePassword Then
        'cp = True
        ' Else : cp = False
        ' MsgBox("Current Password Incorrect", MsgBoxStyle.Critical)
        '  End If

        ' If cp = False Then
        'MsgBox("Current Password Incorrect", MsgBoxStyle.Critical)
        ' End If

        If np = cnp And np > "" And cnp > "" Then 'And cp = True Then
            setting.savePassword = np
            setting.Save()
            MsgBox("Password Changed Successfully", MsgBoxStyle.OkOnly)
            Me.Hide()
            frmLogin.Show()

        Else
            MsgBox("Passwords do not match!", MsgBoxStyle.Critical)
        End If


    End Sub
    Friend WithEvents txtConfirmPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNewPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkConfirmPass As System.Windows.Forms.CheckBox
    Friend WithEvents chkNewPass As System.Windows.Forms.CheckBox

    Private Sub chkNewPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewPass.CheckedChanged
       

    End Sub

    Private Sub chkConfirmPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirmPass.CheckedChanged
       
        
    End Sub

    Private Sub txtNewPass_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtNewPass.MaskInputRejected
        
    End Sub

    Private Sub txtConfirmPass_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtConfirmPass.MaskInputRejected
        If txtConfirmPass.Text = txtNewPass.Text Then
            chkConfirmPass.Checked = True
        Else : chkConfirmPass.Checked = False
        End If
    End Sub

    Private Sub frmChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
    End Sub
End Class
