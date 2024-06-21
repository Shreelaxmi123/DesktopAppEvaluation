Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentSubmissionIndex As Integer = 0 ' Tracks the current submission index
    Private httpClient As HttpClient

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize HttpClient
        httpClient = New HttpClient()

        ' Load the first submission details initially
        Await DisplaySubmission(currentSubmissionIndex)
    End Sub

    Private Async Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click
        ' Logic to move to the next submission
        currentSubmissionIndex += 1
        Await DisplaySubmission(currentSubmissionIndex)
    End Sub

    Private Async Sub btnPREVIOUS_Click(sender As Object, e As EventArgs) Handles btnPREVIOUS.Click
        ' Logic to move to the previous submission
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            Await DisplaySubmission(currentSubmissionIndex)
        End If
    End Sub

    Private Async Function DisplaySubmission(index As Integer) As Task
        Try
            ' Fetch submission data
            Dim response As HttpResponseMessage = Await httpClient.GetAsync($"http://localhost:3000/read?index={index}")

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission As JObject = JObject.Parse(jsonResponse)

                ' Display the fetched data
                btnName.Text = submission("name").ToString()
                btnEmail.Text = submission("email").ToString()
                btnPhone.Text = submission("phone").ToString()
                btnGit.Text = submission("github_link").ToString()
                btnStop.Text = submission("stopwatch_time").ToString()
            Else
                MessageBox.Show("No more submissions available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Reset the index if no more submissions are available
                If index > 0 Then
                    currentSubmissionIndex -= 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' Dispose HttpClient when the form is closed
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        httpClient.Dispose()
        MyBase.OnFormClosed(e)
    End Sub
End Class
