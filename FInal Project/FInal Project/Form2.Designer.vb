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
        Me.components = New System.ComponentModel.Container()
        Me.grpAnswers = New System.Windows.Forms.GroupBox()
        Me.radAns4 = New System.Windows.Forms.RadioButton()
        Me.radAns3 = New System.Windows.Forms.RadioButton()
        Me.radAns2 = New System.Windows.Forms.RadioButton()
        Me.radAns1 = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.txtTimeLeft = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.grpCheckedAnswers = New System.Windows.Forms.GroupBox()
        Me.txtIncorrectAnswers = New System.Windows.Forms.TextBox()
        Me.lblIncorrectAnswers = New System.Windows.Forms.Label()
        Me.txtCorrectAnswers = New System.Windows.Forms.TextBox()
        Me.lblCorrectAnswers = New System.Windows.Forms.Label()
        Me.grpAnswers.SuspendLayout()
        Me.grpCheckedAnswers.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAnswers
        '
        Me.grpAnswers.Controls.Add(Me.radAns4)
        Me.grpAnswers.Controls.Add(Me.radAns3)
        Me.grpAnswers.Controls.Add(Me.radAns2)
        Me.grpAnswers.Controls.Add(Me.radAns1)
        Me.grpAnswers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpAnswers.Location = New System.Drawing.Point(12, 135)
        Me.grpAnswers.Name = "grpAnswers"
        Me.grpAnswers.Size = New System.Drawing.Size(420, 141)
        Me.grpAnswers.TabIndex = 13
        Me.grpAnswers.TabStop = False
        Me.grpAnswers.Text = "Select an answer below:"
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
        'lblQuestion
        '
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.ForeColor = System.Drawing.Color.Red
        Me.lblQuestion.Location = New System.Drawing.Point(12, 48)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(412, 58)
        Me.lblQuestion.TabIndex = 11
        Me.lblQuestion.Text = "Label1"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Red
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.ForeColor = System.Drawing.Color.Aqua
        Me.btnSubmit.Location = New System.Drawing.Point(333, 289)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Quiz"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.ForeColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(331, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit Quiz"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(11, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 24)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Question"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Red
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.ForeColor = System.Drawing.Color.Aqua
        Me.btnNext.Location = New System.Drawing.Point(119, 289)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.ForeColor = System.Drawing.Color.Yellow
        Me.lblTimeRemaining.Location = New System.Drawing.Point(287, 24)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(72, 13)
        Me.lblTimeRemaining.TabIndex = 22
        Me.lblTimeRemaining.Text = "Time Remain:"
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.BackColor = System.Drawing.SystemColors.Control
        Me.txtTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTimeLeft.Location = New System.Drawing.Point(365, 24)
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.Size = New System.Drawing.Size(59, 13)
        Me.txtTimeLeft.TabIndex = 23
        '
        'Timer2
        '
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Red
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.ForeColor = System.Drawing.Color.Aqua
        Me.btnPrevious.Location = New System.Drawing.Point(12, 289)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(101, 23)
        Me.btnPrevious.TabIndex = 24
        Me.btnPrevious.Text = "Previous Question"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.BackColor = System.Drawing.Color.Red
        Me.btnCheckAnswer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheckAnswer.ForeColor = System.Drawing.Color.Aqua
        Me.btnCheckAnswer.Location = New System.Drawing.Point(225, 289)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(102, 23)
        Me.btnCheckAnswer.TabIndex = 1
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = False
        '
        'grpCheckedAnswers
        '
        Me.grpCheckedAnswers.Controls.Add(Me.txtIncorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.lblIncorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.txtCorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.lblCorrectAnswers)
        Me.grpCheckedAnswers.ForeColor = System.Drawing.Color.Red
        Me.grpCheckedAnswers.Location = New System.Drawing.Point(12, 320)
        Me.grpCheckedAnswers.Name = "grpCheckedAnswers"
        Me.grpCheckedAnswers.Size = New System.Drawing.Size(420, 46)
        Me.grpCheckedAnswers.TabIndex = 32
        Me.grpCheckedAnswers.TabStop = False
        Me.grpCheckedAnswers.Text = "Checked Answers"
        '
        'txtIncorrectAnswers
        '
        Me.txtIncorrectAnswers.Enabled = False
        Me.txtIncorrectAnswers.Location = New System.Drawing.Point(386, 18)
        Me.txtIncorrectAnswers.Name = "txtIncorrectAnswers"
        Me.txtIncorrectAnswers.Size = New System.Drawing.Size(25, 20)
        Me.txtIncorrectAnswers.TabIndex = 3
        '
        'lblIncorrectAnswers
        '
        Me.lblIncorrectAnswers.AutoSize = True
        Me.lblIncorrectAnswers.Location = New System.Drawing.Point(285, 21)
        Me.lblIncorrectAnswers.Name = "lblIncorrectAnswers"
        Me.lblIncorrectAnswers.Size = New System.Drawing.Size(95, 13)
        Me.lblIncorrectAnswers.TabIndex = 2
        Me.lblIncorrectAnswers.Text = "Incorrect Answers:"
        '
        'txtCorrectAnswers
        '
        Me.txtCorrectAnswers.Enabled = False
        Me.txtCorrectAnswers.Location = New System.Drawing.Point(100, 18)
        Me.txtCorrectAnswers.Name = "txtCorrectAnswers"
        Me.txtCorrectAnswers.Size = New System.Drawing.Size(25, 20)
        Me.txtCorrectAnswers.TabIndex = 1
        '
        'lblCorrectAnswers
        '
        Me.lblCorrectAnswers.AutoSize = True
        Me.lblCorrectAnswers.Location = New System.Drawing.Point(7, 21)
        Me.lblCorrectAnswers.Name = "lblCorrectAnswers"
        Me.lblCorrectAnswers.Size = New System.Drawing.Size(87, 13)
        Me.lblCorrectAnswers.TabIndex = 0
        Me.lblCorrectAnswers.Text = "Correct Answers:"
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(451, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpCheckedAnswers)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtTimeLeft)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.grpAnswers)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Project Quiz"
        Me.grpAnswers.ResumeLayout(False)
        Me.grpAnswers.PerformLayout()
        Me.grpCheckedAnswers.ResumeLayout(False)
        Me.grpCheckedAnswers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAnswers As System.Windows.Forms.GroupBox
    Friend WithEvents radAns4 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns3 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimeRemaining As System.Windows.Forms.Label
    Friend WithEvents txtTimeLeft As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents grpCheckedAnswers As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorrectAnswers As System.Windows.Forms.TextBox
    Friend WithEvents lblCorrectAnswers As System.Windows.Forms.Label
    Friend WithEvents txtIncorrectAnswers As System.Windows.Forms.TextBox
    Friend WithEvents lblIncorrectAnswers As System.Windows.Forms.Label
End Class
