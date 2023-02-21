Imports System.Data.OleDb
Public Class Booking
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim sql As String
    Dim sql2 As String
    Dim sql3 As String
    Dim con As New OleDbConnection

    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Dim connection As New OleDbConnection
    Dim adapt As New OleDbDataAdapter

    Dim dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mancao\Documents\1ST YEAR - SEMESTERS\3rd Semester\MTReservation.accdb"

    Private Sub Booked_Click(sender As Object, e As EventArgs) Handles Booked.Click

        If (IsNumeric(qty.Text) = False) Then
            MsgBox("Please Input Valid quantity")
            qty.Clear()
        Else
            Dim ans = MessageBox.Show("Book Ticket now", "Book ", MessageBoxButtons.YesNo)
            If (ans = vbYes) Then

                connection = New OleDbConnection(dbcon)

                connection.Open()


                sql = "INSERT INTO [Booking] (cusID, locID,ticketID, methodID,booking_date,paydate,quantity,Comment)
                        VALUES (" & ComboBox1.Text & ", " & ComboBox2.Text & "," & ComboBox3.Text & ", " & ComboBox4.Text & ",
                        DATE(), DATE()," & qty.Text & ", 'Received' )"


                adapt.InsertCommand = New OleDbCommand(sql, connection)

                Dim i = adapt.InsertCommand.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfully Purchased")
                Else
                    MsgBox("Failed to Purchased")
                End If

                connection.Close()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = dbcon
        con.Open()

        sql1 = "SELECT Tickets.ticketID, schedule, Mname,Genre,price
        FROM Tickets,Movie
        WHERE 
        Tickets.movieID = Movie.movieID;"


        da = New OleDbDataAdapter(sql1, con)
        da.Fill(ds, "Tickets, Movie")

        DataGridView1.DataSource = ds.Tables("Tickets, Movie")

        con.Close()
    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lname.Enabled = False
        Fname.Enabled = False
        Location.Enabled = False
        Movie.Enabled = False
        schedule.Enabled = False
        Mprice.Enabled = False
        mop.Enabled = False


        con.ConnectionString = dbcon
        con.Open()

        sql = "SELECT cusID from Customer"
        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            ComboBox1.Items.Add(reader("cusID"))
        End While
        con.Close()


        con.Open()
        sql = "SELECT locID from Location"
        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            ComboBox2.Items.Add(reader("locID"))
        End While
        con.Close()

        con.Open()
        sql = "SELECT ticketID from Tickets"
        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            ComboBox3.Items.Add(reader("ticketID"))
        End While
        con.Close()

        con.Open()
        sql = "SELECT methodID from MoP"
        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            ComboBox4.Items.Add(reader("methodID"))
        End While
        con.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.ConnectionString = dbcon
        con.Open()

        sql = "SELECT Lname,Fname from Customer
        WHERE cusID = " & ComboBox1.SelectedItem

        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            Lname.Text = reader("Lname")
            Fname.Text = reader("Fname")
        End While
        con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.ConnectionString = dbcon
        con.Open()

        sql = "SELECT location from Location
               WHERE locID = " & ComboBox2.Text

        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            Location.Text = reader("location")
        End While
        con.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        con.ConnectionString = dbcon
        con.Open()

        sql = "SELECT Mname,schedule,price FROM Tickets,Movie 
               WHERE Tickets.movieID = Movie.movieID AND 
               Tickets.ticketID = " & ComboBox3.Text
        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            Movie.Text = reader("Mname")
            schedule.Text = reader("schedule")
            Mprice.Text = reader("price")

        End While
        con.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        con.ConnectionString = dbcon
        con.Open()

        sql = "SELECT description FROM MoP 
               WHERE MoP.methodID = " & ComboBox4.Text
        cmd = New OleDbCommand(sql, con)
        reader = cmd.ExecuteReader
        While reader.Read
            mop.Text = reader("description")
        End While
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    'Private Sub IconButton3_Click(sender As Object, e As EventArgs)
    '    form1.Show()
    '    Me.Hide()

    'End Sub

    'Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    'End Sub


    'Private Sub CUSTOMERIDToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
    '    con.ConnectionString = dbcon

    '    Try
    '        con.Open()
    '        sql = "select description FROM MoP"
    '        cmd = New OleDbCommand(sql, con)

    '        reader = cmd.ExecuteReader()

    '        While reader.Read
    '            cmbMOP.Items.Add(reader("description"))
    '        End While

    '    Catch ex As OleDbException
    '        MsgBox("Error in collecting data from Records. Error:" & ex.Message)
    '    End Try

    '    reader.Close()
    '    Try
    '        con.Open()
    '        sql = "SELECT Lname FROM Customer;"
    '        cmd = New OleDbCommand(sql, con)

    '        reader = cmd.ExecuteReader()

    '        While reader.Read
    '            cmbCUSID.Items.Add(reader("Lname"))

    '        End While

    '    Catch ex As OleDbException
    '        MsgBox("Error in collecting data from Records. Error:" & ex.Message)
    '    End Try

    '    reader.Close()
    '    con.Close()
    'End Sub

    'Private Sub LOCATIONIDToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    con.ConnectionString = dbcon

    '    Try
    '        con.Open()
    '        sql = "SELECT DISTINCT location FROM Location;"
    '        cmd = New OleDbCommand(sql, con)

    '        reader = cmd.ExecuteReader()

    '        While reader.Read
    '            ComboBox1.Items.Add(reader("location"))

    '        End While

    '    Catch ex As OleDbException
    '        MsgBox("Error in collecting data from Records. Error:" & ex.Message)
    '    End Try

    '    reader.Close()
    '    con.Close()
    'End Sub

    'Private Sub TICKETIDToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    con.ConnectionString = dbcon
    '    Dim Ticket As Integer = Val(TICKETID.Text)
    '    Try
    '        con.Open()
    '        sql = "select * FROM Tickets WHERE ticketID = " & Ticket
    '        cmd = New OleDbCommand(sql, con)

    '        reader = cmd.ExecuteReader()

    '        While reader.Read
    '            strsched.Text = reader("schedule")
    '            'strmovie.Text = reader("Mname")
    '            'strgenre.Text = reader("Genre")
    '            'strprice.Text = reader("price")
    '        End While

    '    Catch ex As OleDbException
    '        MsgBox("Error in collecting data from Records. Error:" & ex.Message)
    '    End Try

    '    reader.Close()
    '    con.Close()
    'End Sub

    'Private Sub METHODIDToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    con.ConnectionString = dbcon

    '    Try
    '        con.Open()
    '        sql = "select description FROM MoP"
    '        cmd = New OleDbCommand(sql, con)

    '        reader = cmd.ExecuteReader()

    '        While reader.Read
    '            cmbMOP.Items.Add(reader("description"))
    '        End While

    '    Catch ex As OleDbException
    '        MsgBox("Error in collecting data from Records. Error:" & ex.Message)
    '    End Try

    '    reader.Close()
    '    con.Close()
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)

    'End Sub
End Class