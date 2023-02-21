Imports System.Data.OleDb
Public Class MovieCrud
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ans = MessageBox.Show("Do you want to delete this customer from the system?", "DELETE", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            connection = New OleDbConnection(dbcon)

            connection.Open()

            sql = "Delete from Movie where movieID = " & ID.Text & ";"

            cmd = New OleDbCommand(sql, connection)
            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd.Parameters.AddWithValue("@regID", ID.Text)

            If i > 0 Then
                MsgBox(" Movie Deleted")
            Else
                MsgBox("Movie Delete")
            End If

            connection.Close()
        End If
    End Sub

    'Private Sub MovieCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim movie = strmovie.Text
        Dim genre = strgenre.Text
        Dim price = strprice.Text
        Dim textID = ID.Text
        Dim ans = MessageBox.Show("Do you want to Update this Registration Data?", "Registration Update ", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            con = New OleDbConnection(dbcon)
            con.ConnectionString = dbcon
            con.Open()
            'Label9.Text = sql1
            sql = " UPDATE [Movie] set [Mnane] = '" & movie & "',[Genre] = '" & genre & "' ,[price] = '" & price & "' 
                    WHERE Registration.regID = " & CInt(textID) & " "

            adapt.UpdateCommand = New OleDbCommand(sql, con)

            Dim i = adapt.UpdateCommand.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Record Updated")
            End If
            con.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.ConnectionString = dbcon
        Dim Customers As Integer = Val(ID.Text)
        Try
            con.Open()
            sql = "select * FROM Movie WHERE movieID = " & Customers
            cmd = New OleDbCommand(sql, con)

            reader = cmd.ExecuteReader()

            While reader.Read
                strmovie.Text = reader("Mname")
                strgenre.Text = reader("Genre")
                strprice.Text = reader("price")
                'Str.Text = reader("Fname")
                'Phone.Text = reader("phone")
                'address.Text = reader("address")
                'email.Text = reader("email")

            End While

        Catch ex As OleDbException
            MsgBox("Error in collecting data from Records. Error:" & ex.Message)
        End Try

        reader.Close()
        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.ConnectionString = dbcon
        con.Open()

        sql1 = "SELECT * from Movie"

        'sql1 = "ALTER TABLE Customer SET cusID Auto_Increment = 0"
        'cmd = New OleDbCommand(sql1, con)
        'cmd.ExecuteNonQuery()
        'Label9.Text = sql1
        da = New OleDbDataAdapter(sql1, con)
        da.Fill(ds, "Movie")

        DataGridView1.DataSource = ds.Tables("Movie")

        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class