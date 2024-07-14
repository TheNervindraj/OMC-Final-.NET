Public Class CustBook

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Customer_Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnToPayment_Click(sender As Object, e As EventArgs) Handles btnToPayment.Click

        If txtDate.Text = "" Or txtService.Text = "" Or txtTime.Text = "" Or CStr(cboSelBarber.SelectedItem) = "" Then
            MsgBox("Please Enter details correctly", MsgBoxStyle.OkOnly, "Error!")

        Else

            CustPayMethod.lblBarberName.Text = CStr(cboSelBarber.SelectedItem)
            CustPayMethod.lblDate.Text = txtDate.Text
            CustPayMethod.lblTime.Text = txtTime.Text
            CustPayMethod.lblService.Text = txtService.Text

            CustPayMethod.Show()
            Me.Hide()
        End If
    End Sub
End Class