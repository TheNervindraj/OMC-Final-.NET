Public Class BarberHomepage
    Private Sub btnLogOutBarberHomepage_Click(sender As Object, e As EventArgs) Handles btnLogOutBarberHomepage.Click
        Me.Hide()
        StartupPage.Show()
    End Sub

    Private Sub btnAppointmentBarber_Click(sender As Object, e As EventArgs) Handles btnAppointmentBarber.Click
        BarbSeeAppointments.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuBarbHome_Click(sender As Object, e As EventArgs) Handles btnMenuBarbHome.Click
        MenuBarber.Show()
        Me.Hide()
    End Sub
End Class