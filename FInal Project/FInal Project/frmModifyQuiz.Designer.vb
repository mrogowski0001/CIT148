<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModify
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
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCurrentQuestions = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstCurrentQuestions = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(31, 290)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 0
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(447, 290)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblCurrentQuestions
        '
        Me.lblCurrentQuestions.AutoSize = True
        Me.lblCurrentQuestions.Location = New System.Drawing.Point(12, 19)
        Me.lblCurrentQuestions.Name = "lblCurrentQuestions"
        Me.lblCurrentQuestions.Size = New System.Drawing.Size(94, 13)
        Me.lblCurrentQuestions.TabIndex = 2
        Me.lblCurrentQuestions.Text = "Current Questions:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(174, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstCurrentQuestions
        '
        Me.lstCurrentQuestions.FormattingEnabled = True
        Me.lstCurrentQuestions.Location = New System.Drawing.Point(15, 46)
        Me.lstCurrentQuestions.Name = "lstCurrentQuestions"
        Me.lstCurrentQuestions.Size = New System.Drawing.Size(526, 147)
        Me.lstCurrentQuestions.TabIndex = 5
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(310, 290)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 352)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstCurrentQuestions)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblCurrentQuestions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnModify)
        Me.Name = "frmModify"
        Me.Text = "Modify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblCurrentQuestions As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstCurrentQuestions As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
