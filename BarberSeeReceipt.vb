Public Class BarberSeeReceipt
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuBarber.ShowDialog()
        Me.Hide()
    End Sub
End Class