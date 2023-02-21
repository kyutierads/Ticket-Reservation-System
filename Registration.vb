Imports System.Data.OleDb
Public Class Registration

    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand

    Dim connection As New OleDbConnection
    Dim adapt As New OleDbDataAdapter
    Dim sql As String
    Dim dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mancao\Documents\1ST YEAR - SEMESTERS\3rd Semester\MTReservation.accdb"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        customer.Show()
        form1.Show()
        Me.Hide()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim usname = username.Text
        Dim password = passw.Text
        Dim ans = MessageBox.Show("Register Data?", "Registration ", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            connection = New OleDbConnection(dbcon)

            connection.Open()

            sql = "INSERT INTO [Registration]([username],[password]) VALUES ( '" & usname & "','" & password & "') "

            adapt.InsertCommand = New OleDbCommand(sql, connection)

            Dim i = adapt.InsertCommand.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Data Registered")
            Else
                MsgBox("Failed to Register")
            End If

            connection.Close()

        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

        Dim lastname = lname.Text
        Dim firstname = fname.Text
        Dim strphone = phone.Text
        Dim straddress = add.Text
        Dim stremail = email.Text

        Dim ans = MessageBox.Show("Register Data?", "Registration ", MessageBoxButtons.YesNo)
        If (ans = vbYes) Then

            connection = New OleDbConnection(dbcon)

            connection.Open()

            sql = "INSERT INTO [Customers]([Lname],[Fname],[phone],[address],[email]) VALUES ( '" & lastname & "',
                    '" & firstname & "','" & strphone & "','" & straddress & "','" & stremail & "') "

            adapt.InsertCommand = New OleDbCommand(sql, connection)

            Dim i = adapt.InsertCommand.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Data Registered")
            Else
                MsgBox("Failed to Register")
            End If

            connection.Close()

        End If
    End Sub
End Class