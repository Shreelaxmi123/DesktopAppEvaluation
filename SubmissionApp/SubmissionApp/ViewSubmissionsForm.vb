Public Class ViewSubmissionsForm

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Ctrl + P for "Previous"
            btnPREVIOUS.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N for "Next"
            btnNEXT.PerformClick()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPREVIOUS.Click

    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPREVIOUS.BackColor = Color.LightYellow
        btnNEXT.BackColor = Color.SkyBlue
    End Sub
End Class