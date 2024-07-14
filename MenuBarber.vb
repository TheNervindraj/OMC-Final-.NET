Public Class MenuBarber
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        StartupPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BarberHomepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        BarberProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btnMybooking_Click(sender As Object, e As EventArgs) Handles btnMybooking.Click
        BarberSeeReceipt.Show()
        Me.Hide()
    End Sub
End Class