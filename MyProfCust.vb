Public Class MyProfCust
    Private Sub btnBack_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuCust.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        StartupPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OldBookingCust.Show()
        Me.Hide()
    End Sub
End Class