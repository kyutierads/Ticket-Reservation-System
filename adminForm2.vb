
Public Class adminForm2

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
            Case "Transactions"
                addform(Transactionss)
            Case "CRUD"
                addform(updateform)
            Case "CRUDmovie"
                addform(MovieCrud)
            Case "CRUDLocation"
                addform(LocationCrud)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        change_menu("CRUD")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        change_menu("Transactions")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        change_menu("CRUDmovie")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        change_menu("CRUDLocation")
    End Sub
End Class