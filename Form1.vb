Imports System.Data.OleDb
Imports FontAwesome.Sharp
Public Class form1
    Private crtbutton As IconButton
    Private leftborderbtn As Panel

    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand

    Dim connection As New OleDbConnection
    Dim adapt As New OleDbDataAdapter
    Dim sql As String
    Dim dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mancao\Documents\1ST YEAR - SEMESTERS\3rd Semester\MTReservation.accdb"


    'Private Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    '    leftborderbtn = New Panel
    '    leftborderbtn.Size = New Size(7, 71)
    '    sidepanel.Controls.Add(leftborderbtn)

    'End Sub
    Private Sub addform(frm As Form)
        panelcontainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        panelcontainer.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub change_menu(menu As String)
        Select Case menu
            Case "admin"
                addform(adminForm2)
            Case "home"
                addform(formhome)
            Case "customer"
                addform(customer)

        End Select
    End Sub

    Private Sub activebutton(senderbtn As Object, customcolor As Color)
        If crtbutton IsNot Nothing Then
            disable()

            crtbutton = CType(senderbtn, IconButton)
            crtbutton.BackColor = Color.FromArgb(44, 62, 80)
            crtbutton.ForeColor = Color.White
            crtbutton.IconColor = Color.White

            leftborderbtn.BackColor = customcolor
            leftborderbtn.Location = New Point(0, crtbutton.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()

        End If
    End Sub

    Private Sub disable()
        If crtbutton IsNot Nothing Then
            crtbutton.BackColor = Color.FromArgb(30, 39, 46)
            crtbutton.ForeColor = Color.Blue
            crtbutton.IconColor = Color.Blue

        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        adminlogin.Show()
        Me.Hide()

        activebutton(sender, Class1.color14)
        change_menu("admin")



    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        activebutton(sender, Class1.color14)
        change_menu("customer")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("home")
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        change_menu("home")
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

        Dim ext = MessageBox.Show("Do you want to exit?", "EXIT", MessageBoxButtons.YesNo)
        If ext = vbYes Then
            MsgBox("Thank you for using our system, Have a great day!")
            Me.Close()
        Else
            MsgBox("Keep using our system")
        End If

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub sidepanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
