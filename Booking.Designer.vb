<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Movie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Booked = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.mop = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.print = New System.Windows.Forms.Button()
        Me.strshow = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Mprice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.schedule = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 74)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1102, 580)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOOK NOW"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gray
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.print)
        Me.GroupBox4.Controls.Add(Me.strshow)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(43, 35)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1004, 489)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESERVE MOVIE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.schedule)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Fname)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Mprice)
        Me.GroupBox2.Controls.Add(Me.Movie)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Lname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Location)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 221)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMATIONS"
        '
        'Movie
        '
        Me.Movie.Location = New System.Drawing.Point(175, 118)
        Me.Movie.Name = "Movie"
        Me.Movie.Size = New System.Drawing.Size(165, 23)
        Me.Movie.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Method of payment"
        '
        'Booked
        '
        Me.Booked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Booked.Location = New System.Drawing.Point(39, 173)
        Me.Booked.Name = "Booked"
        Me.Booked.Size = New System.Drawing.Size(180, 29)
        Me.Booked.TabIndex = 10
        Me.Booked.Text = "BOOK TICKETS"
        Me.Booked.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "MOVIE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Location"
        '
        'Lname
        '
        Me.Lname.Location = New System.Drawing.Point(175, 31)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(165, 23)
        Me.Lname.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Lname"
        '
        'Location
        '
        Me.Location.Location = New System.Drawing.Point(175, 89)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(165, 23)
        Me.Location.TabIndex = 42
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(39, 57)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(181, 23)
        Me.qty.TabIndex = 45
        '
        'mop
        '
        Me.mop.Location = New System.Drawing.Point(39, 118)
        Me.mop.Name = "mop"
        Me.mop.Size = New System.Drawing.Size(181, 23)
        Me.mop.TabIndex = 44
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 254)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 221)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INDENTIFICATIONS"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(142, 112)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 39
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(142, 142)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox4.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Location ID"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(142, 82)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "TICKET ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Method ID"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(801, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 29)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "SHOW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(19, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(341, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "SHOW AVAILABLE MOVIES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(157, 51)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(609, 197)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "MOVIES"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(597, 164)
        Me.DataGridView1.TabIndex = 0
        '
        'print
        '
        Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print.Location = New System.Drawing.Point(380, 16)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(183, 29)
        Me.print.TabIndex = 12
        Me.print.Text = "PRINT RECEIPT"
        Me.print.UseVisualStyleBackColor = True
        '
        'strshow
        '
        Me.strshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strshow.Location = New System.Drawing.Point(584, 16)
        Me.strshow.Name = "strshow"
        Me.strshow.Size = New System.Drawing.Size(192, 29)
        Me.strshow.TabIndex = 11
        Me.strshow.Text = "REVIEW TICKET"
        Me.strshow.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(968, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 28)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "LOGOUT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Mprice
        '
        Me.Mprice.Location = New System.Drawing.Point(175, 176)
        Me.Mprice.Name = "Mprice"
        Me.Mprice.Size = New System.Drawing.Size(165, 23)
        Me.Mprice.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(66, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Movie Price"
        '
        'Fname
        '
        Me.Fname.Location = New System.Drawing.Point(175, 60)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(165, 23)
        Me.Fname.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Fname"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.mop)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Booked)
        Me.GroupBox6.Controls.Add(Me.qty)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(729, 260)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(255, 215)
        Me.GroupBox6.TabIndex = 51
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'schedule
        '
        Me.schedule.Location = New System.Drawing.Point(175, 147)
        Me.schedule.Name = "schedule"
        Me.schedule.Size = New System.Drawing.Size(165, 23)
        Me.schedule.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(66, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 17)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "schedule"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1102, 654)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Booking"
        Me.Text = "Booking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents print As Button
    Friend WithEvents strshow As Button
    Friend WithEvents Booked As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents mop As TextBox
    Friend WithEvents Movie As TextBox
    Friend WithEvents Location As TextBox
    Friend WithEvents Lname As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Mprice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Fname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents schedule As TextBox
End Class
