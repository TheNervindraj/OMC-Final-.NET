Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic.ApplicationServices


Public Class BarberLogin
    Dim connection As New OleDbConnection(My.Settings.logins1ConnectionString)
    Private Sub btnLoginBarber_Click(sender As Object, e As EventArgs) Handles btnLoginBarber.Click


        If txtLoginEmailBarber.Text = Nothing Or txtLoginPassBarber.Text = Nothing Then
            MsgBox("Enter Email and Password", MsgBoxStyle.Exclamation)

        Else



            Dim query As String = "Select count(*) from logins1 where email = ? and password = ?"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UNI FILES\omc code\logins1.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(query, conn)
            conn.Open()
            cmd.Parameters.AddWithValue("@p1", OleDbType.VarChar).Value = txtLoginEmailBarber.Text
            cmd.Parameters.AddWithValue("@p2", OleDbType.VarChar).Value = txtLoginPassBarber.Text

            Dim check As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            Dim query2 As String = "Select ID from logins1 where email = ?"
            Dim cmd2 As New OleDbCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@p1", OleDbType.VarChar).Value = CStr(txtLoginEmailBarber.Text)

            Dim idnum As String = Convert.ToString(cmd2.ExecuteScalar())

            Dim query3 As String = "Select fname from logins1 where ID = " + idnum
            Dim cmd3 As New OleDbCommand(query3, conn)

            Dim number As String = "Select number from logins1 where ID = " + idnum
            Dim cmdnum As New OleDbCommand(number, conn)

            Dim gender As String = "Select gender from logins1 where ID = " + idnum
            Dim cmdgend As New OleDbCommand(gender, conn)

            Dim barbic As String = "Select ic from logins1 where ID = " + idnum
            Dim cmdsid As New OleDbCommand(barbic, conn)

            Dim email As String = "Select email from logins1 where ID = " + idnum
            Dim cmdemail As New OleDbCommand(email, conn)

            Dim barbexp As String = "Select experience from logins1 where ID = " + idnum
            Dim cmdexp As New OleDbCommand(barbexp, conn)




            If check > 0 Then
                MsgBox("Login Successful!", MsgBoxStyle.Information, "Welcome Back!")
                Dim dispFname As String = Convert.ToString(cmd3.ExecuteScalar())
                Dim dispnum As String = Convert.ToString(cmdnum.ExecuteScalar())
                Dim dispGend As String = Convert.ToString(cmdgend.ExecuteScalar())
                Dim dispic As String = Convert.ToString(cmdsid.ExecuteScalar())
                Dim dispemail As String = Convert.ToString(cmdemail.ExecuteScalar())
                Dim dispexp As String = Convert.ToString(cmdexp.ExecuteScalar())

                Me.Hide()
                StartupSplashScreenBarber.Show()
                BarberHomepage.lblNameBarber.Text = dispFname
                BarbSeeAppointments.lblNameBarber.Text = dispFname
                BarberProfile.lblNameBarber.Text = dispFname
                BarberSeeReceipt.lblNameBarber.Text = dispFname
                BarberProfile.lblEmailBarb.Text = dispemail
                BarberProfile.lblExpBarber.Text = dispexp
                BarberProfile.lblGenderBarb.Text = dispGend
                BarberProfile.lblIC.Text = dispic
                BarberProfile.lblNumberBarb.Text = dispnum


            Else
                MsgBox("Incorrect Email or Password", MsgBoxStyle.Critical, "Check Credentials")
            End If
        End If





    End Sub

    Private Sub btnBackBarberLogin_Click(sender As Object, e As EventArgs) Handles btnBackBarberLogin.Click
        Me.Hide()
        StartupPage.Show()
    End Sub

    Private Sub btnResetBarber_Click(sender As Object, e As EventArgs) Handles btnResetBarber.Click
        txtLoginEmailBarber.Clear()
        txtLoginPassBarber.Clear()
    End Sub

    Private Sub btnShowPassCust_Click(sender As Object, e As EventArgs) Handles btnShowPassCust.Click
        If txtLoginPassBarber.UseSystemPasswordChar = False Then

            txtLoginPassBarber.UseSystemPasswordChar = True

        Else
            txtLoginPassBarber.UseSystemPasswordChar = False

        End If
    End Sub
End Class