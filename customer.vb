Imports System.Data.OleDb
Public Class customer


    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Dim connection As New OleDbConnection
    Dim adapt As New OleDbDataAdapter
    Dim sql As String
    Dim dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mancao\Documents\1ST YEAR - SEMESTERS\3rd Semester\MTReservation.accdb"

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles registerbutton.Click
        Registration.Show()
        form1.Hide()
        Me.Hide()
    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click

        If strusername.Text = "" And strpassword.Text = "" Then
            MessageBox.Show("Please enter email and password", "Credentials", MessageBoxButtons.OK)
            Exit Sub
        Else
            connection.ConnectionString = dbcon
            connection.Open()

            sql = "SELECT * FROM  [Registration] WHERE username = '" & strusername.Text & "' AND Registration.password = '" & strpassword.Text & "' "

            cmd = New OleDbCommand(sql, connection)
            reader = cmd.ExecuteReader

            If reader.Read() Then
                Dim ans = MessageBox.Show("Account Logged in, Would you like to continue?", "Confirmation", MessageBoxButtons.OKCancel)


                If CheckBox1.Checked = False Then
                    MsgBox("Please Agree terms")
                Else
                    Booking.Show()
                End If

            Else
                MessageBox.Show("Username and password doesn't exist", "Error", MessageBoxButtons.OK)
                strusername.Text = ""
                strpassword.Text = ""
            End If
            connection.Close()
        End If

    End Sub


End Class