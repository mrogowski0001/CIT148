<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.lstSummary = New System.Windows.Forms.ListBox()
        Me.lblSummartText = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.btnExitQuiz = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSummary
        '
        Me.lstSummary.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lstSummary.ForeColor = System.Drawing.Color.Red
        Me.lstSummary.FormattingEnabled = True
        Me.lstSummary.Location = New System.Drawing.Point(12, 131)
        Me.lstSummary.Name = "lstSummary"
        Me.lstSummary.Size = New System.Drawing.Size(558, 251)
        Me.lstSummary.TabIndex = 0
        '
        'lblSummartText
        '
        Me.lblSummartText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummartText.ForeColor = System.Drawing.Color.Red
        Me.lblSummartText.Location = New System.Drawing.Point(12, 59)
        Me.lblSummartText.Name = "lblSummartText"
        Me.lblSummartText.Size = New System.Drawing.Size(558, 69)
        Me.lblSummartText.TabIndex = 1
        Me.lblSummartText.Text = "Summary"
        '
        'lblTitle1
        '
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.ForeColor = System.Drawing.Color.Red
        Me.lblTitle1.Location = New System.Drawing.Point(12, 13)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(558, 23)
        Me.lblTitle1.TabIndex = 2
        Me.lblTitle1.Text = "Title"
        Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle2
        '
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.Red
        Me.lblTitle2.Location = New System.Drawing.Point(12, 36)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(558, 23)
        Me.lblTitle2.TabIndex = 3
        Me.lblTitle2.Text = "Title"
        Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExitQuiz
        '
        Me.btnExitQuiz.BackColor = System.Drawing.Color.Red
        Me.btnExitQuiz.ForeColor = System.Drawing.Color.Yellow
        Me.btnExitQuiz.Location = New System.Drawing.Point(58, 401)
        Me.btnExitQuiz.Name = "btnExitQuiz"
        Me.btnExitQuiz.Size = New System.Drawing.Size(75, 23)
        Me.btnExitQuiz.TabIndex = 1
        Me.btnExitQuiz.Text = "Exit Quiz"
        Me.btnExitQuiz.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Red
        Me.btnsave.ForeColor = System.Drawing.Color.Yellow
        Me.btnsave.Location = New System.Drawing.Point(455, 401)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save Quiz"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 448)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'saveFile
        '
        Me.saveFile.DefaultExt = "txt"
        '
        'btnTryAgain
        '
        Me.btnTryAgain.BackColor = System.Drawing.Color.Red
        Me.btnTryAgain.ForeColor = System.Drawing.Color.Yellow
        Me.btnTryAgain.Location = New System.Drawing.Point(259, 401)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnTryAgain.TabIndex = 2
        Me.btnTryAgain.Text = "Try Again"
        Me.btnTryAgain.UseVisualStyleBackColor = False
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(585, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTryAgain)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnExitQuiz)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.lblSummartText)
        Me.Controls.Add(Me.lstSummary)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSummary As System.Windows.Forms.ListBox
    Friend WithEvents lblSummartText As System.Windows.Forms.Label
    Public WithEvents lblTitle1 As System.Windows.Forms.Label
    Public WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents btnExitQuiz As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents saveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnTryAgain As System.Windows.Forms.Button
End Class
