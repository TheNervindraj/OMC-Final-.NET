Public Class StartupPage
    Private Sub btnBarberLogin_Click(sender As Object, e As EventArgs) Handles btnBarberLogin.Click
        Me.Hide()
        BarberLogin.Show()
    End Sub

    Private Sub btnCustLogin_Click(sender As Object, e As EventArgs) Handles btnCustLogin.Click
        Me.Hide()
        CustLogin.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignupPage.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
