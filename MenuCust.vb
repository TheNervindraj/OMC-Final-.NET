Public Class MenuCust


    Private Sub btnMybooking_Click(sender As Object, e As EventArgs) Handles btnMybooking.Click
        OldBookingCust.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        StartupPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        MyProfCust.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewreceipt_Click(sender As Object, e As EventArgs) Handles btnViewreceipt.Click
        CustReceipt.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Customer_Homepage.Show()
        Me.Hide()
    End Sub
End Class

