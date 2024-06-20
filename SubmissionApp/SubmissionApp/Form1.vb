Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show a message box to confirm that the event is triggered
        MessageBox.Show("Form loaded")

        ' Set the background color of the View Submissions button to yellow
        btnViewSubmissions.BackColor = Color.LightYellow
        ' Set the background color of the Create New Submission button to blue
        btnCreateNewSubmission.BackColor = Color.SkyBlue

    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub
End Class
