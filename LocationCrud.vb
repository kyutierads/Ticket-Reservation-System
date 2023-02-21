Imports System.Data.OleDb
Public Class LocationCrud
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

            sql = "Delete from Movie where locID = " & ID.Text & ";"

            cmd = New OleDbCommand(Sql, connection)
            Dim i As Integer = cmd.ExecuteNonQuery()
            cmd.Parameters.AddWithValue("@locID", ID.Text)

            If i > 0 Then
                MsgBox(" Location Deleted")
            Else
                MsgBox("Location Delete")
            End If

            connection.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Location = strLoc.Text
        Dim textID = ID.Text
        Dim ans = MessageBox.Show("Do you want to Update this Location Data?", "Location Update ", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            con = New OleDbConnection(dbcon)
            con.ConnectionString = dbcon
            con.Open()
            'Label9.Text = sql1
            sql = " UPDATE [Location] set [Location] = '" & Location & "'
                    WHERE Location.locID = " & CInt(textID) & " "

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
        con.Open()

        sql1 = "SELECT * from Location"

        'sql1 = "ALTER TABLE Customer SET cusID Auto_Increment = 0"
        'cmd = New OleDbCommand(sql1, con)
        'cmd.ExecuteNonQuery()
        'Label9.Text = sql1
        da = New OleDbDataAdapter(sql1, con)
        da.Fill(ds, "Location")

        DataGridView1.DataSource = ds.Tables("Location")

        con.Close()
    End Sub
End Class