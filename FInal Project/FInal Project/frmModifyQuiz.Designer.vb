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
        Me.txthidden = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModify.ForeColor = System.Drawing.Color.Yellow
        Me.btnModify.Location = New System.Drawing.Point(31, 290)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 0
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.Color.Yellow
        Me.btnCancel.Location = New System.Drawing.Point(447, 290)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCurrentQuestions
        '
        Me.lblCurrentQuestions.AutoSize = True
        Me.lblCurrentQuestions.ForeColor = System.Drawing.Color.Yellow
        Me.lblCurrentQuestions.Location = New System.Drawing.Point(12, 19)
        Me.lblCurrentQuestions.Name = "lblCurrentQuestions"
        Me.lblCurrentQuestions.Size = New System.Drawing.Size(94, 13)
        Me.lblCurrentQuestions.TabIndex = 2
        Me.lblCurrentQuestions.Text = "Current Questions:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.Color.Yellow
        Me.btnAdd.Location = New System.Drawing.Point(233, 290)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lstCurrentQuestions
        '
        Me.lstCurrentQuestions.FormattingEnabled = True
        Me.lstCurrentQuestions.Location = New System.Drawing.Point(15, 46)
        Me.lstCurrentQuestions.Name = "lstCurrentQuestions"
        Me.lstCurrentQuestions.Size = New System.Drawing.Size(526, 147)
        Me.lstCurrentQuestions.TabIndex = 5
        '
        'txthidden
        '
        Me.txthidden.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txthidden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthidden.Location = New System.Drawing.Point(531, 1)
        Me.txthidden.Name = "txthidden"
        Me.txthidden.ReadOnly = True
        Me.txthidden.Size = New System.Drawing.Size(10, 13)
        Me.txthidden.TabIndex = 7
        '
        'frmModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(553, 352)
        Me.Controls.Add(Me.txthidden)
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
    Friend WithEvents txthidden As System.Windows.Forms.TextBox
End Class
