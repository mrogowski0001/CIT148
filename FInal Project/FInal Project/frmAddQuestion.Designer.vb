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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblNewAnswer = New System.Windows.Forms.Label()
        Me.txtNewQuestion = New System.Windows.Forms.RichTextBox()
        Me.txtNewAnswer = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(713, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(212, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.txtNewQuestion.Location = New System.Drawing.Point(12, 37)
        Me.txtNewQuestion.Name = "txtNewQuestion"
        Me.txtNewQuestion.Size = New System.Drawing.Size(571, 96)
        Me.txtNewQuestion.TabIndex = 4
        Me.txtNewQuestion.Text = ""
        '
        'txtNewAnswer
        '
        Me.txtNewAnswer.Location = New System.Drawing.Point(604, 37)
        Me.txtNewAnswer.Name = "txtNewAnswer"
        Me.txtNewAnswer.Size = New System.Drawing.Size(571, 95)
        Me.txtNewAnswer.TabIndex = 5
        Me.txtNewAnswer.Text = ""
        '
        'frmAddQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 317)
        Me.Controls.Add(Me.txtNewAnswer)
        Me.Controls.Add(Me.txtNewQuestion)
        Me.Controls.Add(Me.lblNewAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmAddQuestion"
        Me.Text = "frmAddQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblNewAnswer As System.Windows.Forms.Label
    Friend WithEvents txtNewQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNewAnswer As System.Windows.Forms.RichTextBox
End Class
