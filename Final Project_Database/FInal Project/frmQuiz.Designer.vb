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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizDataSet = New FInal_Project.QuizDataSet()
        Me.QuestionsTableAdapter = New FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpAnswers.SuspendLayout()
        Me.grpCheckedAnswers.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAnswers
        '
        Me.grpAnswers.Controls.Add(Me.radAns4)
        Me.grpAnswers.Controls.Add(Me.radAns3)
        Me.grpAnswers.Controls.Add(Me.radAns2)
        Me.grpAnswers.Controls.Add(Me.radAns1)
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
        Me.lblQuestion.Location = New System.Drawing.Point(12, 48)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(399, 58)
        Me.lblQuestion.TabIndex = 11
        Me.lblQuestion.Text = "Label1"
        '
        'btnSubmit
        '
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Location = New System.Drawing.Point(333, 289)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Quiz"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(331, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit Quiz"
        Me.btnExit.UseVisualStyleBackColor = True
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
        Me.btnNext.Location = New System.Drawing.Point(119, 289)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
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
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(12, 289)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(101, 23)
        Me.btnPrevious.TabIndex = 24
        Me.btnPrevious.Text = "Previous Question"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheckAnswer.Location = New System.Drawing.Point(225, 289)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(102, 23)
        Me.btnCheckAnswer.TabIndex = 1
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'grpCheckedAnswers
        '
        Me.grpCheckedAnswers.Controls.Add(Me.txtIncorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.lblIncorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.txtCorrectAnswers)
        Me.grpCheckedAnswers.Controls.Add(Me.lblCorrectAnswers)
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
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Questions"
        Me.BindingSource1.DataSource = Me.QuizDataSet
        '
        'QuizDataSet
        '
        Me.QuizDataSet.DataSetName = "QuizDataSet"
        Me.QuizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 381)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 33
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
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
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents QuizDataSet As FInal_Project.QuizDataSet
    Friend WithEvents QuestionsTableAdapter As FInal_Project.QuizDataSetTableAdapters.QuestionsTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
