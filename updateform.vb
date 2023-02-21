Imports System.Data.OleDb
Public Class updateform
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
        Dim uname = username.Text
        Dim paswurd = pass.Text
        Dim textID = ID.Text
        Dim ans = MessageBox.Show("Do you want to Update this Registration Data?", "Registration Update ", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            con = New OleDbConnection(dbcon)
            con.ConnectionString = dbcon
            con.Open()
            'Label9.Text = sql1
            sql = " UPDATE [Registration] set [username] = '" & uname & "',[password] = '" & paswurd & "' 
                    WHERE Registration.regID = " & CInt(textID) & " "

            adapt.UpdateCommand = New OleDbCommand(sql, con)

            Dim i = adapt.UpdateCommand.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Record Updated")
            End If
            con.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ds.Clear()

        con.ConnectionString = dbcon
        con.Open()

        sql1 = "SELECT Customer.cusID,username,Registration.password,Customer.Lname,Customer.Fname,
        Customer.phone,Customer.address,Customer.email
        FROM Registration,Customer
        WHERE
        Registration.regID = Customer.cusID;"

        'sql1 = "ALTER TABLE Customer SET cusID Auto_Increment = 0"
        'cmd = New OleDbCommand(sql1, con)
        'cmd.ExecuteNonQuery()
        'Label9.Text = sql1
        da = New OleDbDataAdapter(sql1, con)
        da.Fill(ds, "Registration,Customer")

        DataGridView1.DataSource = ds.Tables("Registration,Customer")

        con.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ans = MessageBox.Show("Do you want to delete this customer from the system?", "DELETE", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            connection = New OleDbConnection(dbcon)

            connection.Open()

            sql = "Delete from Registration where regID = " & ID.Text & ";"

            cmd = New OleDbCommand(sql, connection)
            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd.Parameters.AddWithValue("@regID", ID.Text)

            If i > 0 Then
                MsgBox("Row(s) Deleted")
            Else
                MsgBox("No row(s) Delete")
            End If

            connection.Close()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim textID = ID.Text
        Dim ans = MessageBox.Show("Do you want to update this customer personal information?", "INFROMATION UPDATE ", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            con = New OleDbConnection(dbcon)
            con.ConnectionString = dbcon
            con.Open()
            'Label9.Text = sql1
            sql = " UPDATE [Customer] set [Lname] = '" & Lname.Text & "',[Fname] = '" & Fname.Text & "',
            [phone] = '" & Phone.Text & "',[address] = '" & address.Text & "', 
            [email] = '" & email.Text & "'  WHERE Customer.cusID = " & textID & " "

            adapt.UpdateCommand = New OleDbCommand(sql, con)
            Dim i = adapt.UpdateCommand.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Record Updated")
            End If
            con.Close()
        End If
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.ConnectionString = dbcon
        Dim Customers As Integer = Val(ID.Text)
        Try
            con.Open()
            sql = "select * FROM Registration,Customer WHERE regID = " & Customers
            cmd = New OleDbCommand(sql, con)

            reader = cmd.ExecuteReader()

            While reader.Read
                username.Text = reader("username")
                pass.Text = reader("password")
                Lname.Text = reader("Lname")
                Fname.Text = reader("Fname")
                Phone.Text = reader("phone")
                address.Text = reader("address")
                email.Text = reader("email")

            End While

        Catch ex As OleDbException
            MsgBox("Error in collecting data from Records. Error:" & ex.Message)
        End Try

        reader.Close()
        con.Close()
    End Sub

    Private Sub ID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub updateform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class