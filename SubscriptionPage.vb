Public Class SubscriptionPage
    Private Sub btnSubsHere_Click(sender As Object, e As EventArgs) Handles btnSubsHere.Click

        SubscribePay.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Customer_Homepage.Show()
        Me.Hide()
    End Sub


End Class
