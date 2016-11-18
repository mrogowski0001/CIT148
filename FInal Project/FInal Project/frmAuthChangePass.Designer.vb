<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthChangePass
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
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.MaskedTextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.MaskedTextBox()
        Me.chkNewPass = New System.Windows.Forms.CheckBox()
        Me.chkConfirmPass = New System.Windows.Forms.CheckBox()
        Me.lblCurrentPass = New System.Windows.Forms.Label()
        Me.txtCurrentPass = New System.Windows.Forms.MaskedTextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.ForeColor = System.Drawing.Color.Yellow
        Me.lblNewPass.Location = New System.Drawing.Point(32, 82)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(81, 13)
        Me.lblNewPass.TabIndex = 1
        Me.lblNewPass.Text = "New Password:"
        '
        'txtNewPass
        '
        Me.txtNewPass.ForeColor = System.Drawing.Color.Black
        Me.txtNewPass.Location = New System.Drawing.Point(157, 79)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(192, 20)
        Me.txtNewPass.TabIndex = 2
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.ForeColor = System.Drawing.Color.Yellow
        Me.lblConfirmPass.Location = New System.Drawing.Point(16, 141)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(97, 13)
        Me.lblConfirmPass.TabIndex = 11
        Me.lblConfirmPass.Text = "ReType Password:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPass.Location = New System.Drawing.Point(157, 138)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(192, 20)
        Me.txtConfirmPass.TabIndex = 3
        '
        'chkNewPass
        '
        Me.chkNewPass.AutoCheck = False
        Me.chkNewPass.AutoSize = True
        Me.chkNewPass.BackColor = System.Drawing.Color.Black
        Me.chkNewPass.Checked = Global.FInal_Project.My.MySettings.Default.chkNewPass
        Me.chkNewPass.Enabled = False
        Me.chkNewPass.ForeColor = System.Drawing.SystemColors.Control
        Me.chkNewPass.Location = New System.Drawing.Point(355, 82)
        Me.chkNewPass.Name = "chkNewPass"
        Me.chkNewPass.Size = New System.Drawing.Size(15, 14)
        Me.chkNewPass.TabIndex = 0
        Me.chkNewPass.TabStop = False
        Me.chkNewPass.UseCompatibleTextRendering = True
        Me.chkNewPass.UseVisualStyleBackColor = False
        '
        'chkConfirmPass
        '
        Me.chkConfirmPass.AutoCheck = False
        Me.chkConfirmPass.AutoSize = True
        Me.chkConfirmPass.BackColor = System.Drawing.Color.Black
        Me.chkConfirmPass.Enabled = False
        Me.chkConfirmPass.ForeColor = System.Drawing.SystemColors.Control
        Me.chkConfirmPass.Location = New System.Drawing.Point(355, 141)
        Me.chkConfirmPass.Name = "chkConfirmPass"
        Me.chkConfirmPass.Size = New System.Drawing.Size(15, 14)
        Me.chkConfirmPass.TabIndex = 0
        Me.chkConfirmPass.TabStop = False
        Me.chkConfirmPass.UseVisualStyleBackColor = False
        '
        'lblCurrentPass
        '
        Me.lblCurrentPass.AutoSize = True
        Me.lblCurrentPass.ForeColor = System.Drawing.Color.Yellow
        Me.lblCurrentPass.Location = New System.Drawing.Point(20, 38)
        Me.lblCurrentPass.Name = "lblCurrentPass"
        Me.lblCurrentPass.Size = New System.Drawing.Size(93, 13)
        Me.lblCurrentPass.TabIndex = 15
        Me.lblCurrentPass.Text = "Current Password:"
        '
        'txtCurrentPass
        '
        Me.txtCurrentPass.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentPass.Location = New System.Drawing.Point(157, 35)
        Me.txtCurrentPass.Name = "txtCurrentPass"
        Me.txtCurrentPass.Size = New System.Drawing.Size(192, 20)
        Me.txtCurrentPass.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Yellow
        Me.btnSubmit.Location = New System.Drawing.Point(62, 186)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(91, 25)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.Color.Yellow
        Me.btnCancel.Location = New System.Drawing.Point(225, 186)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 25)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmAuthChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(379, 223)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCurrentPass)
        Me.Controls.Add(Me.lblCurrentPass)
        Me.Controls.Add(Me.chkConfirmPass)
        Me.Controls.Add(Me.chkNewPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.lblNewPass)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmAuthChangePass"
        Me.Text = "frmAuthChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkNewPass As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmPass As System.Windows.Forms.CheckBox
    Friend WithEvents lblCurrentPass As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
