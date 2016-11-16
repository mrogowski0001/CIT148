<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
    Inherits System.Windows.Forms.Form

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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.cbxSecurityq1 = New System.Windows.Forms.ComboBox()
        Me.cbxSecurityq2 = New System.Windows.Forms.ComboBox()
        Me.txtsecurityq1 = New System.Windows.Forms.TextBox()
        Me.txtsecurityq2 = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuestionAnsr1 = New System.Windows.Forms.Label()
        Me.lblQuestionAnsr2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(55, 50)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "User Name"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(223, 47)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(253, 20)
        Me.txtUserName.TabIndex = 1
        '
        'cbxSecurityq1
        '
        Me.cbxSecurityq1.FormattingEnabled = True
        Me.cbxSecurityq1.Items.AddRange(New Object() {"Where were you born?", "What is your mothers maiden name?", "What was the make of your first car?"})
        Me.cbxSecurityq1.Location = New System.Drawing.Point(58, 98)
        Me.cbxSecurityq1.Name = "cbxSecurityq1"
        Me.cbxSecurityq1.Size = New System.Drawing.Size(418, 21)
        Me.cbxSecurityq1.TabIndex = 2
        Me.cbxSecurityq1.Text = "Where were you born?"
        '
        'cbxSecurityq2
        '
        Me.cbxSecurityq2.FormattingEnabled = True
        Me.cbxSecurityq2.Items.AddRange(New Object() {"What is your favorit drink?", "What was the name of your first pet?"})
        Me.cbxSecurityq2.Location = New System.Drawing.Point(58, 220)
        Me.cbxSecurityq2.Name = "cbxSecurityq2"
        Me.cbxSecurityq2.Size = New System.Drawing.Size(418, 21)
        Me.cbxSecurityq2.TabIndex = 4
        Me.cbxSecurityq2.Text = "What was the name of your first pet?"
        '
        'txtsecurityq1
        '
        Me.txtsecurityq1.Location = New System.Drawing.Point(58, 147)
        Me.txtsecurityq1.Name = "txtsecurityq1"
        Me.txtsecurityq1.Size = New System.Drawing.Size(418, 20)
        Me.txtsecurityq1.TabIndex = 3
        '
        'txtsecurityq2
        '
        Me.txtsecurityq2.Location = New System.Drawing.Point(58, 268)
        Me.txtsecurityq2.Name = "txtsecurityq2"
        Me.txtsecurityq2.Size = New System.Drawing.Size(418, 20)
        Me.txtsecurityq2.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(58, 344)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(401, 344)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Location = New System.Drawing.Point(55, 82)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(168, 13)
        Me.lblQuestion1.TabIndex = 9
        Me.lblQuestion1.Text = "Please Select A Security Question"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Please Select A Security Question"
        '
        'lblQuestionAnsr1
        '
        Me.lblQuestionAnsr1.AutoSize = True
        Me.lblQuestionAnsr1.Location = New System.Drawing.Point(55, 131)
        Me.lblQuestionAnsr1.Name = "lblQuestionAnsr1"
        Me.lblQuestionAnsr1.Size = New System.Drawing.Size(163, 13)
        Me.lblQuestionAnsr1.TabIndex = 11
        Me.lblQuestionAnsr1.Text = "Please Answer Security Question"
        '
        'lblQuestionAnsr2
        '
        Me.lblQuestionAnsr2.AutoSize = True
        Me.lblQuestionAnsr2.Location = New System.Drawing.Point(55, 252)
        Me.lblQuestionAnsr2.Name = "lblQuestionAnsr2"
        Me.lblQuestionAnsr2.Size = New System.Drawing.Size(163, 13)
        Me.lblQuestionAnsr2.TabIndex = 12
        Me.lblQuestionAnsr2.Text = "Please Answer Security Question"
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(563, 422)
        Me.Controls.Add(Me.lblQuestionAnsr2)
        Me.Controls.Add(Me.lblQuestionAnsr1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtsecurityq2)
        Me.Controls.Add(Me.txtsecurityq1)
        Me.Controls.Add(Me.cbxSecurityq2)
        Me.Controls.Add(Me.cbxSecurityq1)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Name = "frmForgotPassword"
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents cbxSecurityq1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSecurityq2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtsecurityq1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsecurityq2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblQuestion1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQuestionAnsr1 As System.Windows.Forms.Label
    Friend WithEvents lblQuestionAnsr2 As System.Windows.Forms.Label
End Class
