Public Class SubscribePay
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Customer_Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SubscriptionPage.Show()
        Me.Hide()
    End Sub
End Class