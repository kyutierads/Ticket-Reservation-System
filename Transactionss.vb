Imports System.Data.OleDb
Public Class Transactionss
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim con As New OleDb.OleDbConnection

    Dim connection As OleDbConnection
    Dim adapt As New OleDbDataAdapter
    Dim sql As String
    Dim dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mancao\Documents\1ST YEAR - SEMESTERS\3rd Semester\MTReservation.accdb"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = dbcon
        con.Open()

        sql1 = "SELECT Customer.cusID, customer.Lname, customer.Fname, Mname, Genre,px1rice, quantity, booking_date, paydate, schedule, location, description, Comment
FROM Customer,Booking, Tickets,Movie,Location,MoP
WHERE Customer.cusID = Booking.cusID AND 
Booking.locID = Location.locID AND 
Booking.ticketID = Tickets.ticketID AND 
Tickets.movieID = Movie.movieID AND 
Booking.methodID = MoP.methodID;"

        da = New OleDbDataAdapter(sql1, con)
        da.Fill(ds, " Customer,Booking, Tickets,Movie,Location,MoP")

        DataGridView1.DataSource = ds.Tables(" Customer,Booking, Tickets,Movie,Location,MoP")

        con.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'ds.Clear()
        'con = New OleDbConnection(dbcon)
        'con.Open()
        'sql = "SELECT * From Registration"

        'adapt.SelectCommand = New OleDbCommand(sql, con)
        'adapt.Fill(ds, "Registration")

        'For I = 1 To ds.Tables("Registration").Rows.Count - 0
        '    ComboBox1.Items.Add(I)
        '    DataGridView1.DataSource = ds.Tables("Registration")
        'Next
        'con.Close()
    End Sub
End Class