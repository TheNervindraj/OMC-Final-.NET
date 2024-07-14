Imports System.Data.OleDb
Imports System.Runtime.Remoting.Contexts
Imports System.Data

Public Class SignupCustomer

    Dim connect As New OleDbConnection
    Dim command As OleDbCommand
    Dim sql As String = Nothing


    Private Sub btnBackSignupCust_Click(sender As Object, e As EventArgs) Handles btnBackSignupCust.Click
        Me.Hide()
        SignupPage.Show()
    End Sub

    Private Sub btnNextSignupCust_Click(sender As Object, e As EventArgs) Handles btnNextSignupCust.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim email As String = txtRegEmailCust.Text
        Dim password As String = txtRegPassCust.Text
        Dim number = txtRegNumCust.Text
        Dim fname As String = txtRegNameCust.Text
        Dim gender = cboGenderCust.SelectedItem
        Dim id = txtRegIDCust.Text

        If txtRegEmailCust.Text = Nothing Or txtRegIDCust.Text = Nothing Or txtRegIDCust.Text = Nothing Or txtRegNameCust.Text = Nothing Or txtRegNumCust.Text = Nothing Or txtRegPassCust.Text = Nothing Or txtRegConfPassCust.Text = Nothing Or cboGenderCust.SelectedItem = Nothing Then
            MsgBox("Please fill up all fields", MsgBoxStyle.OkOnly, "Error!")

        Else
            Dim checkData As String = "SELECT * FROM logins1 WHERE email = '" & txtRegEmailCust.Text & "' "



            command = New OleDbCommand(checkData, connect)

            Dim check = Convert.ToInt32(Command.ExecuteScalar())

            If check > 0 Then
                MsgBox("Email: " & txtRegEmailCust.Text & " already exists!", MsgBoxStyle.OkOnly, "Invalid Entry")

            Else
                If txtRegConfPassCust.Text = txtRegPassCust.Text Then

                    sql = "INSERT INTO logins1 ([email], [password], [number], [fname], [gender], [sID]) VALUES(?,?,?,?,?,?)"

                    command = New OleDbCommand(Sql, connect)

                    command.Parameters.AddWithValue("@p1", CStr(txtRegEmailCust.Text))
                    command.Parameters.AddWithValue("@p2", CStr(txtRegPassCust.Text))
                    command.Parameters.AddWithValue("@p3", CStr(txtRegNumCust.Text))
                    command.Parameters.AddWithValue("@p4", CStr(txtRegNameCust.Text))
                    command.Parameters.AddWithValue("@p5", CStr(cboGenderCust.SelectedItem.ToString()))
                    command.Parameters.AddWithValue("@p7", CStr(txtRegIDCust.Text))


                    command.ExecuteNonQuery()

                    MsgBox("Successfully created new account!", MsgBoxStyle.OkOnly, "Welcome!")
                    Me.Hide()
                    StartupPage.Show()

                    txtRegConfPassCust.Clear()
                    txtRegEmailCust.Clear()
                    txtRegIDCust.Clear()
                    txtRegNameCust.Clear()
                    txtRegNumCust.Clear()
                    txtRegPassCust.Clear()




                Else

                    MsgBox("Please ensure you entered the password correctly in both fields", MsgBoxStyle.Critical, "Passwords do not match")

                End If
            End If

            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
        End If


    End Sub

    Private Sub SignupCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UNI FILES\omc code\logins1.accdb"
    End Sub

    Private Sub btnShowPassRegCust_Click(sender As Object, e As EventArgs) Handles btnShowPassRegCust.Click
        If txtRegPassCust.UseSystemPasswordChar = False Then

            txtRegPassCust.UseSystemPasswordChar = True
            txtRegConfPassCust.UseSystemPasswordChar = True
        Else
            txtRegPassCust.UseSystemPasswordChar = False
            txtRegConfPassCust.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtRegNameCust_TextChanged(sender As Object, e As EventArgs) Handles txtRegNameCust.TextChanged

    End Sub
End Class