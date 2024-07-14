Public Class SignupPage
    Private Sub btnToSignupBarber_Click(sender As Object, e As EventArgs) Handles btnToSignupBarber.Click
        Me.Hide()
        SignupBarber.Show()
    End Sub

    Private Sub btnToSignupCust_Click(sender As Object, e As EventArgs) Handles btnToSignupCust.Click
        Me.Hide()
        SignupCustomer.Show()
    End Sub

    Private Sub btnBackSignupPage_Click(sender As Object, e As EventArgs) Handles btnBackSignupPage.Click
        Me.Hide()
        StartupPage.Show()
    End Sub
End Class