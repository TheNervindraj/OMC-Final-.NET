Public Class CustPayMethod
    Private Sub btnToQR_Click(sender As Object, e As EventArgs) Handles btnToQR.Click

        QRandPrice.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustBook.Show()
        Me.Hide()
    End Sub
End Class