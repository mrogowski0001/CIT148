﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestionModify
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
        Me.lblQuestionNow = New System.Windows.Forms.Label()
        Me.lblModifiedQuestion = New System.Windows.Forms.Label()
        Me.lstBeforeChangeQ = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtModifiedQ = New System.Windows.Forms.TextBox()
        Me.txtModifiedA = New System.Windows.Forms.TextBox()
        Me.lblModifiedAnswer = New System.Windows.Forms.Label()
        Me.lstBeforeChangeA = New System.Windows.Forms.ListBox()
        Me.lblAnswersNow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuestionNow
        '
        Me.lblQuestionNow.AutoSize = True
        Me.lblQuestionNow.ForeColor = System.Drawing.Color.Yellow
        Me.lblQuestionNow.Location = New System.Drawing.Point(12, 15)
        Me.lblQuestionNow.Name = "lblQuestionNow"
        Me.lblQuestionNow.Size = New System.Drawing.Size(126, 13)
        Me.lblQuestionNow.TabIndex = 0
        Me.lblQuestionNow.Text = "Question Before Change:"
        '
        'lblModifiedQuestion
        '
        Me.lblModifiedQuestion.AutoSize = True
        Me.lblModifiedQuestion.ForeColor = System.Drawing.Color.Yellow
        Me.lblModifiedQuestion.Location = New System.Drawing.Point(13, 118)
        Me.lblModifiedQuestion.Name = "lblModifiedQuestion"
        Me.lblModifiedQuestion.Size = New System.Drawing.Size(143, 13)
        Me.lblModifiedQuestion.TabIndex = 1
        Me.lblModifiedQuestion.Text = "Please Type Question Here: "
        '
        'lstBeforeChangeQ
        '
        Me.lstBeforeChangeQ.FormattingEnabled = True
        Me.lstBeforeChangeQ.Location = New System.Drawing.Point(12, 31)
        Me.lstBeforeChangeQ.Name = "lstBeforeChangeQ"
        Me.lstBeforeChangeQ.Size = New System.Drawing.Size(506, 56)
        Me.lstBeforeChangeQ.TabIndex = 2
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Yellow
        Me.btnConfirm.Location = New System.Drawing.Point(285, 332)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(233, 60)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.Color.Yellow
        Me.btnCancel.Location = New System.Drawing.Point(641, 332)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(233, 60)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtModifiedQ
        '
        Me.txtModifiedQ.Location = New System.Drawing.Point(12, 134)
        Me.txtModifiedQ.Multiline = True
        Me.txtModifiedQ.Name = "txtModifiedQ"
        Me.txtModifiedQ.Size = New System.Drawing.Size(506, 57)
        Me.txtModifiedQ.TabIndex = 6
        '
        'txtModifiedA
        '
        Me.txtModifiedA.Location = New System.Drawing.Point(641, 134)
        Me.txtModifiedA.Multiline = True
        Me.txtModifiedA.Name = "txtModifiedA"
        Me.txtModifiedA.Size = New System.Drawing.Size(506, 57)
        Me.txtModifiedA.TabIndex = 7
        '
        'lblModifiedAnswer
        '
        Me.lblModifiedAnswer.AutoSize = True
        Me.lblModifiedAnswer.ForeColor = System.Drawing.Color.Yellow
        Me.lblModifiedAnswer.Location = New System.Drawing.Point(638, 118)
        Me.lblModifiedAnswer.Name = "lblModifiedAnswer"
        Me.lblModifiedAnswer.Size = New System.Drawing.Size(170, 13)
        Me.lblModifiedAnswer.TabIndex = 8
        Me.lblModifiedAnswer.Text = "Please Type Correct Answer Here:"
        '
        'lstBeforeChangeA
        '
        Me.lstBeforeChangeA.FormattingEnabled = True
        Me.lstBeforeChangeA.Location = New System.Drawing.Point(641, 31)
        Me.lstBeforeChangeA.Name = "lstBeforeChangeA"
        Me.lstBeforeChangeA.Size = New System.Drawing.Size(506, 56)
        Me.lstBeforeChangeA.TabIndex = 9
        '
        'lblAnswersNow
        '
        Me.lblAnswersNow.AutoSize = True
        Me.lblAnswersNow.ForeColor = System.Drawing.Color.Yellow
        Me.lblAnswersNow.Location = New System.Drawing.Point(638, 15)
        Me.lblAnswersNow.Name = "lblAnswersNow"
        Me.lblAnswersNow.Size = New System.Drawing.Size(180, 13)
        Me.lblAnswersNow.TabIndex = 10
        Me.lblAnswersNow.Text = "Please Type Possible Answers Here:"
        '
        'frmQuestionModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1162, 455)
        Me.Controls.Add(Me.lblAnswersNow)
        Me.Controls.Add(Me.lstBeforeChangeA)
        Me.Controls.Add(Me.lblModifiedAnswer)
        Me.Controls.Add(Me.txtModifiedA)
        Me.Controls.Add(Me.txtModifiedQ)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lstBeforeChangeQ)
        Me.Controls.Add(Me.lblModifiedQuestion)
        Me.Controls.Add(Me.lblQuestionNow)
        Me.Name = "frmQuestionModify"
        Me.Text = "Modify Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestionNow As System.Windows.Forms.Label
    Friend WithEvents lblModifiedQuestion As System.Windows.Forms.Label
    Friend WithEvents lstBeforeChangeQ As System.Windows.Forms.ListBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtModifiedQ As System.Windows.Forms.TextBox
    Friend WithEvents txtModifiedA As System.Windows.Forms.TextBox
    Friend WithEvents lblModifiedAnswer As System.Windows.Forms.Label
    Friend WithEvents lstBeforeChangeA As System.Windows.Forms.ListBox
    Friend WithEvents lblAnswersNow As System.Windows.Forms.Label
End Class
