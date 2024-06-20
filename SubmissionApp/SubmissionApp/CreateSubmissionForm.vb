Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero
    Private pauseTime As TimeSpan = TimeSpan.Zero ' Store the pause time

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ' Ctrl + T for toggling the stopwatch
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            ' Ctrl + S for submitting the form
            btnSubmit.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Ctrl + S for submitting the form
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            ' If stopwatch is running, pause it
            stopwatchRunning = False
            pauseTime = stopwatchTime ' Store the pause time
            btnToggleStopwatch.Text = "Start"
            ' Stop the stopwatch logic here
            ' For example, if using a Timer control named timerStopwatch, you would stop it like this:
            ' timerStopwatch.Stop()
        Else
            ' If stopwatch is not running, start it or resume from pause
            If pauseTime > TimeSpan.Zero Then
                ' Resuming from pause
                stopwatchTime = pauseTime
            Else
                ' Starting the stopwatch
                stopwatchTime = TimeSpan.Zero
            End If
            stopwatchRunning = True
            btnToggleStopwatch.Text = "Stop"
            ' Start the stopwatch logic here
            ' For example, if using a Timer control named timerStopwatch, you would start it like this:
            ' timerStopwatch.Start()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate form fields here if needed
        If txtName.Text = "" OrElse txtEmail.Text = "" OrElse txtPhone.Text = "" OrElse txtGit.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Submit form details to backend
        ' Add your submission logic here
        ' For example, you might send the form data to a server or save it to a database

        MessageBox.Show("Form submitted successfully.")

        ' Clear form fields after submission if needed
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGit.Text = ""
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click
        ' Event handler for label click
    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click
        ' Event handler for label click
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        ' Event handler for text changed
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' Event handler for text changed
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        ' Event handler for text changed
    End Sub

    Private Sub txtGit_TextChanged(sender As Object, e As EventArgs) Handles txtGit.TextChanged
        ' Event handler for text changed
    End Sub

    Private Sub lblPhone_Click(sender As Object, e As EventArgs) Handles lblPhone.Click

    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnToggleStopwatch.BackColor = Color.LightYellow
        btnSubmit.BackColor = Color.SkyBlue
    End Sub

    Private Sub lblGit_Click(sender As Object, e As EventArgs) Handles lblGit.Click

    End Sub
End Class
