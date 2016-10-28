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
        Me.grpAnswers = New System.Windows.Forms.GroupBox()
        Me.radAns4 = New System.Windows.Forms.RadioButton()
        Me.radAns3 = New System.Windows.Forms.RadioButton()
        Me.radAns2 = New System.Windows.Forms.RadioButton()
        Me.radAns1 = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnGetResults = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtIncorrectAns = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblIncorrectAns = New System.Windows.Forms.Label()
        Me.txtCorrectAns = New System.Windows.Forms.TextBox()
        Me.lblCorrectAns = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpAnswers.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAnswers
        '
        Me.grpAnswers.Controls.Add(Me.radAns4)
        Me.grpAnswers.Controls.Add(Me.radAns3)
        Me.grpAnswers.Controls.Add(Me.radAns2)
        Me.grpAnswers.Controls.Add(Me.radAns1)
        Me.grpAnswers.Location = New System.Drawing.Point(11, 157)
        Me.grpAnswers.Name = "grpAnswers"
        Me.grpAnswers.Size = New System.Drawing.Size(410, 141)
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
        Me.lblQuestion.Location = New System.Drawing.Point(11, 62)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(410, 58)
        Me.lblQuestion.TabIndex = 11
        Me.lblQuestion.Text = "Label1"
        '
        'btnGetResults
        '
        Me.btnGetResults.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGetResults.Enabled = False
        Me.btnGetResults.Location = New System.Drawing.Point(218, 333)
        Me.btnGetResults.Name = "btnGetResults"
        Me.btnGetResults.Size = New System.Drawing.Size(94, 23)
        Me.btnGetResults.TabIndex = 15
        Me.btnGetResults.Text = "Get Results"
        Me.btnGetResults.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Location = New System.Drawing.Point(15, 333)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 23)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit Answer"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtIncorrectAns
        '
        Me.txtIncorrectAns.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.txtIncorrectAns.Enabled = False
        Me.txtIncorrectAns.Location = New System.Drawing.Point(388, 368)
        Me.txtIncorrectAns.Name = "txtIncorrectAns"
        Me.txtIncorrectAns.Size = New System.Drawing.Size(33, 20)
        Me.txtIncorrectAns.TabIndex = 21
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(318, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit Quiz"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblIncorrectAns
        '
        Me.lblIncorrectAns.AutoSize = True
        Me.lblIncorrectAns.Location = New System.Drawing.Point(287, 371)
        Me.lblIncorrectAns.Name = "lblIncorrectAns"
        Me.lblIncorrectAns.Size = New System.Drawing.Size(95, 13)
        Me.lblIncorrectAns.TabIndex = 20
        Me.lblIncorrectAns.Text = "Incorrect Answers:"
        '
        'txtCorrectAns
        '
        Me.txtCorrectAns.Enabled = False
        Me.txtCorrectAns.Location = New System.Drawing.Point(101, 368)
        Me.txtCorrectAns.Name = "txtCorrectAns"
        Me.txtCorrectAns.Size = New System.Drawing.Size(33, 20)
        Me.txtCorrectAns.TabIndex = 19
        '
        'lblCorrectAns
        '
        Me.lblCorrectAns.AutoSize = True
        Me.lblCorrectAns.Location = New System.Drawing.Point(8, 371)
        Me.lblCorrectAns.Name = "lblCorrectAns"
        Me.lblCorrectAns.Size = New System.Drawing.Size(87, 13)
        Me.lblCorrectAns.TabIndex = 18
        Me.lblCorrectAns.Text = "Correct Answers:"
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(11, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 24)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Question"
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(118, 333)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(94, 23)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpAnswers)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnGetResults)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtIncorrectAns)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblIncorrectAns)
        Me.Controls.Add(Me.txtCorrectAns)
        Me.Controls.Add(Me.lblCorrectAns)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.grpAnswers.ResumeLayout(False)
        Me.grpAnswers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAnswers As System.Windows.Forms.GroupBox
    Friend WithEvents radAns4 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns3 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAns1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnGetResults As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtIncorrectAns As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblIncorrectAns As System.Windows.Forms.Label
    Friend WithEvents txtCorrectAns As System.Windows.Forms.TextBox
    Friend WithEvents lblCorrectAns As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
