Public Class BarberProfile


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        StartupPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuBarber.Show()
        Me.Hide()
    End Sub
End Class