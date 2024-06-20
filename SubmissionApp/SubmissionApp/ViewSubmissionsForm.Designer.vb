<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPREVIOUS = New System.Windows.Forms.Button()
        Me.btnNEXT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnPhone = New System.Windows.Forms.Button()
        Me.btnGit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPREVIOUS
        '
        Me.btnPREVIOUS.Location = New System.Drawing.Point(80, 455)
        Me.btnPREVIOUS.Name = "btnPREVIOUS"
        Me.btnPREVIOUS.Size = New System.Drawing.Size(251, 42)
        Me.btnPREVIOUS.TabIndex = 0
        Me.btnPREVIOUS.Text = "PREVIOUS (CTRL + P)"
        Me.btnPREVIOUS.UseVisualStyleBackColor = True
        '
        'btnNEXT
        '
        Me.btnNEXT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNEXT.Location = New System.Drawing.Point(362, 455)
        Me.btnNEXT.Name = "btnNEXT"
        Me.btnNEXT.Size = New System.Drawing.Size(304, 42)
        Me.btnNEXT.TabIndex = 1
        Me.btnNEXT.Text = "NEXT (CTRL + N)"
        Me.btnNEXT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Johh Doe, Slidely Task 2 - View Submissions"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(90, 81)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(90, 130)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(90, 207)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(92, 20)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGit
        '
        Me.lblGit.AutoSize = True
        Me.lblGit.Location = New System.Drawing.Point(90, 292)
        Me.lblGit.Name = "lblGit"
        Me.lblGit.Size = New System.Drawing.Size(169, 20)
        Me.lblGit.TabIndex = 6
        Me.lblGit.Text = "Github Link For Task 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Stopwatchtime"
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(362, 72)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(304, 39)
        Me.btnName.TabIndex = 8
        Me.btnName.Text = "John Doe"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(362, 130)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(304, 43)
        Me.btnEmail.TabIndex = 9
        Me.btnEmail.Text = "johndoe@gmail.com"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'btnPhone
        '
        Me.btnPhone.Location = New System.Drawing.Point(362, 207)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(304, 43)
        Me.btnPhone.TabIndex = 10
        Me.btnPhone.Text = "9876543210"
        Me.btnPhone.UseVisualStyleBackColor = True
        '
        'btnGit
        '
        Me.btnGit.Location = New System.Drawing.Point(362, 292)
        Me.btnGit.Name = "btnGit"
        Me.btnGit.Size = New System.Drawing.Size(304, 53)
        Me.btnGit.TabIndex = 11
        Me.btnGit.Text = "https://github.com/john_doe/my_slidely_task/"
        Me.btnGit.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(362, 377)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(304, 37)
        Me.btnStop.TabIndex = 12
        Me.btnStop.Text = "00:01:19"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 509)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnGit)
        Me.Controls.Add(Me.btnPhone)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGit)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNEXT)
        Me.Controls.Add(Me.btnPREVIOUS)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPREVIOUS As Button
    Friend WithEvents btnNEXT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnName As Button
    Friend WithEvents btnEmail As Button
    Friend WithEvents btnPhone As Button
    Friend WithEvents btnGit As Button
    Friend WithEvents btnStop As Button
End Class
