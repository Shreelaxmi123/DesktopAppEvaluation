Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize and layout controls
        InitializeControls()
    End Sub

    Private Sub InitializeControls()
        ' This method is no longer necessary if the controls are already defined in the designer file
    End Sub

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStopwatch.Text = "Resume"
        Else
            stopwatch.Start()
            btnStartStopwatch.Text = "Pause"
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect submission data
        Dim submissionData As New Dictionary(Of String, String)()
        submissionData("name") = txtNameInput.Text
        submissionData("email") = txtEmailInput.Text
        submissionData("phone") = txtPhoneNumberInput.Text
        submissionData("github_link") = txtGitHubLinkInput.Text
        submissionData("stopwatch_time") = stopwatch.Elapsed.ToString()

        ' Convert the data to JSON
        Dim json As String = JsonConvert.SerializeObject(submissionData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Send the JSON data to the backend
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                response.EnsureSuccessStatusCode()
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                MessageBox.Show("Submission successful! Response: " & responseContent)
                ClearForm()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ClearForm()
        ' Clear all input fields and reset stopwatch
        txtNameInput.Clear()
        txtEmailInput.Clear()
        txtPhoneNumberInput.Clear()
        txtGitHubLinkInput.Clear()
        stopwatch.Reset()
        btnStartStopwatch.Text = "Start"
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    ' Form controls are already defined in the designer file
End Class
