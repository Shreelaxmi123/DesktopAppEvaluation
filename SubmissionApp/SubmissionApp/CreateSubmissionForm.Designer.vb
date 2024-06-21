<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStartStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.txtEmailInput = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumberInput = New System.Windows.Forms.TextBox()
        Me.txtGitHubLinkInput = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStartStopwatch
        '
        Me.btnStartStopwatch.Location = New System.Drawing.Point(12, 12)
        Me.btnStartStopwatch.Name = "btnStartStopwatch"
        Me.btnStartStopwatch.Size = New System.Drawing.Size(75, 23)
        Me.btnStartStopwatch.TabIndex = 0
        Me.btnStartStopwatch.Text = "Start"
        Me.btnStartStopwatch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 150)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(100, 50)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(200, 20)
        Me.txtNameInput.TabIndex = 2
        '
        'txtEmailInput
        '
        Me.txtEmailInput.Location = New System.Drawing.Point(100, 76)
        Me.txtEmailInput.Name = "txtEmailInput"
        Me.txtEmailInput.Size = New System.Drawing.Size(200, 20)
        Me.txtEmailInput.TabIndex = 3
        '
        'txtPhoneNumberInput
        '
        Me.txtPhoneNumberInput.Location = New System.Drawing.Point(100, 102)
        Me.txtPhoneNumberInput.Name = "txtPhoneNumberInput"
        Me.txtPhoneNumberInput.Size = New System.Drawing.Size(200, 20)
        Me.txtPhoneNumberInput.TabIndex = 4
        '
        'txtGitHubLinkInput
        '
        Me.txtGitHubLinkInput.Location = New System.Drawing.Point(100, 128)
        Me.txtGitHubLinkInput.Name = "txtGitHubLinkInput"
        Me.txtGitHubLinkInput.Size = New System.Drawing.Size(200, 20)
        Me.txtGitHubLinkInput.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 79)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(12, 105)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 8
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblGitHubLink
        '
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Location = New System.Drawing.Point(12, 131)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(68, 13)
        Me.lblGitHubLink.TabIndex = 9
        Me.lblGitHubLink.Text = "GitHub Link:"
        '
        'CreateSubmissionForm
        '
        Me.ClientSize = New System.Drawing.Size(320, 200)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtGitHubLinkInput)
        Me.Controls.Add(Me.txtPhoneNumberInput)
        Me.Controls.Add(Me.txtEmailInput)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStartStopwatch)
        Me.Name = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents txtEmailInput As TextBox
    Friend WithEvents txtPhoneNumberInput As TextBox
    Friend WithEvents txtGitHubLinkInput As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label

End Class
