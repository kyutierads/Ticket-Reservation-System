Imports System.Data.OleDb
Public Class adminlogin

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stremail.Text = "" And strpassword.Text = "" Then
            MessageBox.Show("Please enter email and password", "Credentials", MessageBoxButtons.OK)
            Exit Sub
        Else
            connection.ConnectionString = dbcon
            connection.Open()

            sql = "SELECT * FROM  [admin] WHERE admin.email = '" & stremail.Text & "' AND admin.password = '" & strpassword.Text & "' "
            cmd = New OleDbCommand(sql, connection)
            reader = cmd.ExecuteReader
            If reader.Read() Then
                Dim ans = MessageBox.Show("Acount logged in, Would you like to continue?", "Confirmation", MessageBoxButtons.YesNo)

                If ans = DialogResult.Yes Then
                    form1.Show()
                    Me.Hide()
                End If

            Else
                MessageBox.Show("Username and password doesn't exist", "Error", MessageBoxButtons.OK)
                stremail.Text = ""
                strpassword.Text = ""
            End If
        End If
        connection.Close()

    End Sub
End Class