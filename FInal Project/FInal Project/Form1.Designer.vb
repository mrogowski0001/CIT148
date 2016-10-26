<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.grpAnswers = New System.Windows.Forms.GroupBox()
        Me.radAns4 = New System.Windows.Forms.RadioButton()
        Me.radAns3 = New System.Windows.Forms.RadioButton()
        Me.radAns2 = New System.Windows.Forms.RadioButton()
        Me.radAns1 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCorrectAns = New System.Windows.Forms.Label()
        Me.txtCorrectAns = New System.Windows.Forms.TextBox()
        Me.txtIncorrectAns = New System.Windows.Forms.TextBox()
        Me.lblIncorrectAns = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.grpAnswers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.Location = New System.Drawing.Point(12, 47)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(403, 58)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        Me.lblQuestion.Visible = False
        '
        'grpAnswers
        '
        Me.grpAnswers.Controls.Add(Me.radAns4)
        Me.grpAnswers.Controls.Add(Me.radAns3)
        Me.grpAnswers.Controls.Add(Me.radAns2)
        Me.grpAnswers.Controls.Add(Me.radAns1)
        Me.grpAnswers.Location = New System.Drawing.Point(5, 142)
        Me.grpAnswers.Name = "grpAnswers"
        Me.grpAnswers.Size = New System.Drawing.Size(410, 141)
        Me.grpAnswers.TabIndex = 1
        Me.grpAnswers.TabStop = False
        Me.grpAnswers.Text = "Select an answer below:"
        Me.grpAnswers.Visible = False
        '
        'radAns4
        '
        Me.radAns4.AutoSize = True
        Me.radAns4.Location = New System.Drawing.Point(7, 92)
        Me.radAns4.Name = "radAns4"
        Me.radAns4.Size = New System.Drawing.Size(90, 17)
        Me.radAns4.TabIndex = 3
        Me.radAns4.TabStop = True
        Me.radAns4.Text = "RadioButton4"
        Me.radAns4.UseVisualStyleBackColor = True
        '
        'radAns3
        '
        Me.radAns3.AutoSize = True
        Me.radAns3.Location = New System.Drawing.Point(7, 68)
        Me.radAns3.Name = "radAns3"
        Me.radAns3.Size = New System.Drawing.Size(90, 17)
        Me.radAns3.TabIndex = 2
        Me.radAns3.TabStop = True
        Me.radAns3.Text = "RadioButton3"
        Me.radAns3.UseVisualStyleBackColor = True
        '
        'radAns2
        '
        Me.radAns2.AutoSize = True
        Me.radAns2.Location = New System.Drawing.Point(7, 44)
        Me.radAns2.Name = "radAns2"
        Me.radAns2.Size = New System.Drawing.Size(90, 17)
        Me.radAns2.TabIndex = 1
        Me.radAns2.TabStop = True
        Me.radAns2.Text = "RadioButton2"
        Me.radAns2.UseVisualStyleBackColor = True
        '
        'radAns1
        '
        Me.radAns1.AutoSize = True
        Me.radAns1.Location = New System.Drawing.Point(7, 20)
        Me.radAns1.Name = "radAns1"
        Me.radAns1.Size = New System.Drawing.Size(90, 17)
        Me.radAns1.TabIndex = 0
        Me.radAns1.TabStop = True
        Me.radAns1.Text = "RadioButton1"
        Me.radAns1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(115, 318)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(94, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 318)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(98, 289)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(237, 23)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Begin the Quiz"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(161, 24)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Question"
        Me.lblTitle.Visible = False
        '
        'lblCorrectAns
        '
        Me.lblCorrectAns.AutoSize = True
        Me.lblCorrectAns.Location = New System.Drawing.Point(5, 353)
        Me.lblCorrectAns.Name = "lblCorrectAns"
        Me.lblCorrectAns.Size = New System.Drawing.Size(87, 13)
        Me.lblCorrectAns.TabIndex = 6
        Me.lblCorrectAns.Text = "Correct Answers:"
        Me.lblCorrectAns.Visible = False
        '
        'txtCorrectAns
        '
        Me.txtCorrectAns.Location = New System.Drawing.Point(98, 350)
        Me.txtCorrectAns.Name = "txtCorrectAns"
        Me.txtCorrectAns.Size = New System.Drawing.Size(33, 20)
        Me.txtCorrectAns.TabIndex = 7
        Me.txtCorrectAns.Visible = False
        '
        'txtIncorrectAns
        '
        Me.txtIncorrectAns.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.txtIncorrectAns.Location = New System.Drawing.Point(392, 350)
        Me.txtIncorrectAns.Name = "txtIncorrectAns"
        Me.txtIncorrectAns.Size = New System.Drawing.Size(33, 20)
        Me.txtIncorrectAns.TabIndex = 9
        Me.txtIncorrectAns.Visible = False
        '
        'lblIncorrectAns
        '
        Me.lblIncorrectAns.AutoSize = True
        Me.lblIncorrectAns.Location = New System.Drawing.Point(291, 353)
        Me.lblIncorrectAns.Name = "lblIncorrectAns"
        Me.lblIncorrectAns.Size = New System.Drawing.Size(95, 13)
        Me.lblIncorrectAns.TabIndex = 8
        Me.lblIncorrectAns.Text = "Incorrect Answers:"
        Me.lblIncorrectAns.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 318)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        Me.btnSubmit.Visible = False
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(215, 318)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(94, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "End Quiz"
        Me.btnEnd.UseVisualStyleBackColor = True
        Me.btnEnd.Visible = False
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 408)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtIncorrectAns)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblIncorrectAns)
        Me.Controls.Add(Me.txtCorrectAns)
        Me.Controls.Add(Me.lblCorrectAns)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpAnswers)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.grpAnswers.ResumeLayout(False)
        Me.grpAnswers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents grpAnswers As System.Windows.Forms.GroupBox
    Friend WithEvents radAns4 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns3 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCorrectAns As System.Windows.Forms.Label
    Friend WithEvents txtCorrectAns As System.Windows.Forms.TextBox
    Friend WithEvents txtIncorrectAns As System.Windows.Forms.TextBox
    Friend WithEvents lblIncorrectAns As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
