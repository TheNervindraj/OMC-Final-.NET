Public Class Customer_Homepage
    Private Sub btnLogOutHomepage_Click(sender As Object, e As EventArgs) Handles btnLogOutHomepageCust.Click
        Me.Hide()
        StartupPage.Show()
    End Sub

    Private Sub btnSubscribe_Click(sender As Object, e As EventArgs) Handles btnSubscribe.Click
        SubscriptionPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnMenuCustHome_Click(sender As Object, e As EventArgs) Handles btnMenuCustHome.Click
        MenuCust.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        CustBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdvice_Click(sender As Object, e As EventArgs) Handles btnAdvice.Click
        AdvHair.Show()
        Me.Hide()
    End Sub
End Class