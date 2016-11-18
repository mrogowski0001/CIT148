<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddQuestion
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblNewAnswer = New System.Windows.Forms.Label()
        Me.txtNewQuestion = New System.Windows.Forms.RichTextBox()
        Me.txtNewAnswer = New System.Windows.Forms.RichTextBox()
        Me.txtCorrectAnswer = New System.Windows.Forms.RichTextBox()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Red
        Me.btnSubmit.ForeColor = System.Drawing.Color.Yellow
        Me.btnSubmit.Location = New System.Drawing.Point(212, 227)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(212, 66)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.ForeColor = System.Drawing.Color.Yellow
        Me.btnCancel.Location = New System.Drawing.Point(713, 227)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(212, 66)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(12, 21)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(149, 13)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Please type the new question:"
        '
        'lblNewAnswer
        '
        Me.lblNewAnswer.AutoSize = True
        Me.lblNewAnswer.Location = New System.Drawing.Point(601, 21)
        Me.lblNewAnswer.Name = "lblNewAnswer"
        Me.lblNewAnswer.Size = New System.Drawing.Size(128, 13)
        Me.lblNewAnswer.TabIndex = 3
        Me.lblNewAnswer.Text = "Please type the answers: "
        '
        'txtNewQuestion
        '
        Me.txtNewQuestion.BackColor = System.Drawing.Color.White
        Me.txtNewQuestion.ForeColor = System.Drawing.Color.Black
        Me.txtNewQuestion.Location = New System.Drawing.Point(12, 37)
        Me.txtNewQuestion.Name = "txtNewQuestion"
        Me.txtNewQuestion.Size = New System.Drawing.Size(571, 171)
        Me.txtNewQuestion.TabIndex = 4
        Me.txtNewQuestion.Text = ""
        '
        'txtNewAnswer
        '
        Me.txtNewAnswer.BackColor = System.Drawing.Color.White
        Me.txtNewAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtNewAnswer.Location = New System.Drawing.Point(604, 37)
        Me.txtNewAnswer.Name = "txtNewAnswer"
        Me.txtNewAnswer.Size = New System.Drawing.Size(571, 95)
        Me.txtNewAnswer.TabIndex = 5
        Me.txtNewAnswer.Text = ""
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.BackColor = System.Drawing.Color.White
        Me.txtCorrectAnswer.ForeColor = System.Drawing.Color.Black
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(604, 151)
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(571, 57)
        Me.txtCorrectAnswer.TabIndex = 6
        Me.txtCorrectAnswer.Text = ""
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.AutoSize = True
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(601, 135)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(162, 13)
        Me.lblCorrectAnswer.TabIndex = 7
        Me.lblCorrectAnswer.Text = "Please type the corrrect answer: "
        '
        'frmAddQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1200, 317)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.txtCorrectAnswer)
        Me.Controls.Add(Me.txtNewAnswer)
        Me.Controls.Add(Me.txtNewQuestion)
        Me.Controls.Add(Me.lblNewAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "frmAddQuestion"
        Me.Text = "frmAddQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblNewAnswer As System.Windows.Forms.Label
    Friend WithEvents txtNewQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNewAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCorrectAnswer As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCorrectAnswer As System.Windows.Forms.Label
End Class
