Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel

Public Class CustLogin
    Private Sub btnLoginCust_Click(sender As Object, e As EventArgs) Handles btnLoginCust.Click
        If txtLoginEmailCust.Text = Nothing Or txtLoginPasswordCust.Text = Nothing Then
            MsgBox("Enter Email and Password", MsgBoxStyle.Exclamation)

        Else



            Dim query As String = "Select count(*) from logins1 where email = ? and password = ?"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UNI FILES\omc code\logins1.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(query, conn)
            conn.Open()
            cmd.Parameters.AddWithValue("@p1", OleDbType.VarChar).Value = txtLoginEmailCust.Text
            cmd.Parameters.AddWithValue("@p2", OleDbType.VarChar).Value = txtLoginPasswordCust.Text

            Dim check As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            Dim query2 As String = "Select ID from logins1 where email = ?"
            Dim cmd2 As New OleDbCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@p1", OleDbType.VarChar).Value = CStr(txtLoginEmailCust.Text)

            Dim idnum As String = Convert.ToString(cmd2.ExecuteScalar())

            Dim query3 As String = "Select fname from logins1 where ID = " + idnum
            Dim cmd3 As New OleDbCommand(query3, conn)

            Dim number As String = "Select number from logins1 where ID = " + idnum
            Dim cmdnum As New OleDbCommand(number, conn)

            Dim gender As String = "Select gender from logins1 where ID = " + idnum
            Dim cmdgend As New OleDbCommand(gender, conn)

            Dim studentid As String = "Select sID from logins1 where ID = " + idnum
            Dim cmdsid As New OleDbCommand(studentid, conn)

            Dim email As String = "Select email from logins1 where ID = " + idnum
            Dim cmdemail As New OleDbCommand(email, conn)





            If check > 0 Then
                MsgBox("Login Successful!", MsgBoxStyle.Information, "Welcome Back!")
                Dim dispFname As String = Convert.ToString(cmd3.ExecuteScalar())
                Dim dispnum As String = Convert.ToString(cmdnum.ExecuteScalar())
                Dim dispGend As String = Convert.ToString(cmdgend.ExecuteScalar())
                Dim dispsid As String = Convert.ToString(cmdsid.ExecuteScalar())
                Dim dispemail As String = Convert.ToString(cmdemail.ExecuteScalar())

                Me.Hide()
                StartupSplashScreenCust.Show()
                Customer_Homepage.lblCustName.Text = dispFname
                SubscriptionPage.lblCustName.Text = dispFname
                MyProfCust.lblCustName.Text = dispFname
                MyProfCust.lblNumberCust.Text = dispnum
                MyProfCust.lblGenderCust.Text = dispGend
                MyProfCust.lblStuID.Text = dispsid
                MyProfCust.lblEmailCust.Text = dispemail
                CustBook.lblCustName.Text = dispFname
                CustPayMethod.lblCustName.Text = dispFname
                QRandPrice.lblCustName.Text = dispFname
                AdvHair.lblCustName.Text = dispFname
                SubscribePay.lblCustName.Text = dispFname
                SubscriptionPage.lblCustName.Text = dispFname
                OldBookingCust.lblCustName.Text = dispFname
                CustReceipt.lblCustName.Text = dispFname


            Else
                MsgBox("Incorrect Email or Password", MsgBoxStyle.Critical, "Check Credentials")
            End If
        End If
    End Sub

    Private Sub btnBackCustLogin_Click(sender As Object, e As EventArgs) Handles btnBackCustLogin.Click
        Me.Hide()
        StartupPage.Show()
    End Sub

    Private Sub btnResetCust_Click(sender As Object, e As EventArgs) Handles btnResetCust.Click
        txtLoginEmailCust.Clear()
        txtLoginPasswordCust.Clear()
    End Sub

    Private Sub btnShowPassCust_Click(sender As Object, e As EventArgs) Handles btnShowPassCust.Click
        If txtLoginPasswordCust.UseSystemPasswordChar = False Then

            txtLoginPasswordCust.UseSystemPasswordChar = True

        Else
            txtLoginPasswordCust.UseSystemPasswordChar = False

        End If
    End Sub


End Class