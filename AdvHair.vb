Public Class AdvHair

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Customer_Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnWomen_Click(sender As Object, e As EventArgs) Handles btnWomen.Click
        btnMen.Enabled = True
        btnWomen.Enabled = False
        PictureBox1.Visible = False
    End Sub

    Private Sub btnMen_Click(sender As Object, e As EventArgs) Handles btnMen.Click
        btnMen.Enabled = False
        btnWomen.Enabled = True
        PictureBox1.Visible = True
    End Sub
End Class