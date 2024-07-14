Imports System.Data.OleDb
Imports System.Data
Imports System.ComponentModel
Imports OMC_1_12__.NET_.logins1DataSetTableAdapters


Public Class SignupBarber
    Dim connect As New OleDbConnection
    Dim command As OleDbCommand
    Dim sql As String = Nothing

    Private Sub btnBackSignupBarber_Click(sender As Object, e As EventArgs) Handles btnBackSignupBarber.Click

        Me.Hide()
        SignupPage.Show()
    End Sub

    Private Sub btnNextSignupBarber_Click(sender As Object, e As EventArgs) Handles btnNextSignupBarber.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim email As String = txtRegEmailBarber.Text
        Dim password As String = txtRegPassBarber.Text
        Dim number = txtRegNumBarber.Text
        Dim fname As String = txtRegNameBarber.Text
        Dim gender = cboGenderBarber.SelectedItem
        Dim ic = txtRegICBarber.Text
        Dim exp As String = txtRegExpBarber.Text

        If txtRegEmailBarber.Text = Nothing Or txtRegExpBarber.Text = Nothing Or txtRegICBarber.Text = Nothing Or txtRegNameBarber.Text = Nothing Or txtRegNumBarber.Text = Nothing Or txtRegPassBarber.Text = Nothing Or txtRegConfPassBarber.Text = Nothing Or cboGenderBarber.SelectedItem = Nothing Then
            MsgBox("Please fill up all fields", MsgBoxStyle.OkOnly, "Error!")

        Else
            Dim checkData As String = "SELECT * FROM logins1 WHERE email = '" & txtRegEmailBarber.Text & "' "



            command = New OleDbCommand(checkData, connect)

            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                MsgBox("Email: " & txtRegEmailBarber.Text & " already exists!", MsgBoxStyle.OkOnly, "Invalid Entry")

            Else
                If txtRegConfPassBarber.Text = txtRegPassBarber.Text Then


                    sql = "INSERT INTO logins1 ([email], [password], [number], [fname], [gender], [ic], [experience]) VALUES(?,?,?,?,?,?,?)"

                    command = New OleDbCommand(sql, connect)

                    command.Parameters.AddWithValue("@p1", CStr(txtRegEmailBarber.Text))
                    command.Parameters.AddWithValue("@p2", CStr(txtRegPassBarber.Text))
                    command.Parameters.AddWithValue("@p3", CStr(txtRegNumBarber.Text))
                    command.Parameters.AddWithValue("@p4", CStr(txtRegNameBarber.Text))
                    command.Parameters.AddWithValue("@p5", CStr(cboGenderBarber.SelectedItem.ToString()))
                    command.Parameters.AddWithValue("@p6", CStr(txtRegICBarber.Text))
                    command.Parameters.AddWithValue("@p7", CStr(txtRegExpBarber.Text))

                    command.ExecuteNonQuery()

                    MsgBox("Successfully created new account!", MsgBoxStyle.OkOnly, "Welcome!")
                    Me.Hide()
                    StartupPage.Show()

                    txtRegConfPassBarber.Clear()
                    txtRegEmailBarber.Clear()
                    txtRegExpBarber.Clear()
                    txtRegICBarber.Clear()
                    txtRegNameBarber.Clear()
                    txtRegNumBarber.Clear()
                    txtRegPassBarber.Clear()
                Else
                    MsgBox("Please ensure you entered the password correctly in both fields", MsgBoxStyle.Critical, "Passwords do not match")
                End If
            End If

            If connect.State = ConnectionState.Open Then
                connect.Close()
            End If
        End If








    End Sub

    Private Sub SignupBarber_Load(sender As Object, e As EventArgs) Handles Me.Load

        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UNI FILES\omc code\logins1.accdb"

    End Sub



    Private Sub btnShowPassRegBarber_Click(sender As Object, e As EventArgs) Handles btnShowPassRegBarber.Click
        If txtRegPassBarber.UseSystemPasswordChar = False Then

            txtRegPassBarber.UseSystemPasswordChar = True
            txtRegConfPassBarber.UseSystemPasswordChar = True
        Else
            txtRegPassBarber.UseSystemPasswordChar = False
            txtRegConfPassBarber.UseSystemPasswordChar = False
        End If
    End Sub
End Class