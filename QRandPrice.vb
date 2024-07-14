Public Class QRandPrice
    Private Sub btnToQR_Click(sender As Object, e As EventArgs) Handles btnToQR.Click
        Customer_Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustPayMethod.Show()
        Me.Hide()
    End Sub
End Class